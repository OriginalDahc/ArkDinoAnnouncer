using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using ArkSavegameToolkitNet.Domain;
using System.Globalization;

namespace ArkDinoAnnouncer
{
    public partial class frmMain : Form
    {
        Discord.Webhook.DiscordWebhookClient client;

        private string ClusterFolder = "";
        private string SaveFilePath = "";

        private bool MessageTooLong = false;
        private bool MessageFragsSent = false;

        public frmMain()
        {
            InitializeComponent();
            IntervalTimer.Interval = 1800 * 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SendAnnouncement()
        {
            if (string.IsNullOrWhiteSpace(ClusterFolder) || string.IsNullOrWhiteSpace(SaveFilePath))
            {
                MessageBox.Show("You must select both a cluster folder and a save file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtWebhookID.Text) || string.IsNullOrWhiteSpace(txtWebhookToken.Text) || !IsInt(txtWebhookID.Text))
            {
                MessageBox.Show("Invalid Webhook data. ID must be an integer and both fields must have an entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var currentEntry = "";

            try
            {
                client = new Discord.Webhook.DiscordWebhookClient(Convert.ToUInt64(txtWebhookID.Text), txtWebhookToken.Text);

                var cd = new ArkClusterData(ClusterFolder, loadOnlyPropertiesInDomain: true);
                var gd = new ArkGameData(SaveFilePath, cd, loadOnlyPropertiesInDomain: true);

                //extract savegame
                var upd = gd.Update(CancellationToken.None, deferApplyNewData: true);
                if (upd == null) return;
                if (upd.Success == true)
                {
                    //extract cluster data
                    var cr = cd.Update(CancellationToken.None);

                    //assign the new data to the domain model
                    gd.ApplyPreviousUpdate();

                    // Populate Wild dinos
                    var wildDinos = gd.WildCreatures;

                    // Disable for publish
                    //var wildNames = new List<string>();

                    //foreach (var dino in wildDinos)
                    //{
                    //    wildNames.Add(dino.ClassName.Split('_').First());
                    //}

                    //var maxLength = wildNames.Max(q => q.Length);
                    ///////////////////////////////

                    // init message
                    var message = @"```autohotkey" + Environment.NewLine;

                    // Go through entries
                    foreach (DataGridViewRow row in dgvTrackList.Rows)
                    {
                        if (string.IsNullOrWhiteSpace(row.Cells[0].Value.ToString()) || string.IsNullOrWhiteSpace(row.Cells[1].Value.ToString()))
                        {
                            MessageBox.Show("Incomplete Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var dType = row.Cells[0].Value.ToString();
                        var searchString = row.Cells[1].Value.ToString().ToLower();

                        currentEntry = dType + " | " + searchString;

                        //init controllers
                        var foundDinos = false;

                        // Get desired Dinos
                        var queriedDinos = new List<ArkWildCreature>();
                        queriedDinos = wildDinos.Where(q => q.ClassName.ToLower().Contains(searchString)).ToList();

                        // testing message length
                        //queriedDinos = wildDinos.ToList();
                        
                        // Discord
                        if (queriedDinos.Count > 0)
                        {
                            foundDinos = true;
                            message += $"Recent {dType} sightings on " + queriedDinos.First().Location.MapName + ":" + Environment.NewLine;

                            //message += $"_{"_______",-7}_{"________________",-16}_{"_______",-7}_{"_________",-9}_" + Environment.NewLine; // With level
                            message += $"_{"_______",-7}_{"________________",-16}_{"_________",-9}_" + Environment.NewLine;
                            //message += $"|{"Gender",-7}|{"Type",-16}|{"Level",-7}|{"Location",-9}|" + Environment.NewLine; // With level
                            message += $"|{"Gender",-7}|{"Type",-16}|{"Location",-9}|" + Environment.NewLine;
                            //message += $"|{"_______",-7}|{"________________",-16}|{"_______",-7}|{"_________",-9}|" + Environment.NewLine; // With level
                            message += $"|{"_______",-7}|{"________________",-16}|{"_________",-9}|" + Environment.NewLine;
                            foreach (var dino in queriedDinos)
                            {
                                var gender = $" {dino.Gender.ToString()}";
                                var name = $" {dino.ClassName.Split('_').First()}";
                                var level = $" {dino.BaseLevel.ToString()}";
                                var loc = $" {(Math.Round(dino.Location.Latitude.Value / 5) * 5).ToString("N0", CultureInfo.InvariantCulture)}, {(Math.Round(dino.Location.Longitude.Value / 5) * 5).ToString("N0", CultureInfo.InvariantCulture)}";
                                //message += $"|{gender,-7}|{name,-16}|{level,-7}|{loc,-9}|" + Environment.NewLine; // With level
                                message += $"|{gender,-7}|{name,-16}|{loc,-9}|" + Environment.NewLine;
                            }
                            //message += $"|{"_______",-7}|{"________________",-16}|{"_______",-7}|{"_________",-9}|" + Environment.NewLine; // With level
                            message += $"|{"_______",-7}|{"________________",-16}|{"_________",-9}|" + Environment.NewLine;
                        }

                        if (MessageTooLong)
                        {
                            message += Environment.NewLine + "```";
                            if (!string.IsNullOrWhiteSpace(message) && message != @"```autohotkey" + Environment.NewLine + Environment.NewLine + "```") client.SendMessageAsync(message).Wait();
                            MessageFragsSent = true;
                            message = @"```autohotkey" + Environment.NewLine;
                        }

                        if (!MessageTooLong && foundDinos && row.Index < dgvTrackList.RowCount)
                        {
                            message += Environment.NewLine + Environment.NewLine + Environment.NewLine;
                        }
                    }

                    MessageTooLong = message.Length >= 2000 && !MessageFragsSent;

                    if (MessageTooLong)
                    {
                        SendAnnouncement();
                        MessageTooLong = false;
                    }
                    else if (!MessageTooLong && !MessageFragsSent)
                    {
                        message += Environment.NewLine + "```";
                        if (!string.IsNullOrWhiteSpace(message) && message != @"```autohotkey" + Environment.NewLine + Environment.NewLine + "```") client.SendMessageAsync(message).Wait();
                    }
                }
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrWhiteSpace(currentEntry))
                {
                    MessageBox.Show("Too many dinos were returned from enty . Please narrow your search.");
                }
                else
                {
                    Clipboard.SetText("Message: " + Environment.NewLine + ex.Message + Environment.NewLine + Environment.NewLine + "Stack Trace: " + Environment.NewLine + ex.StackTrace);
                    MessageBox.Show("An unhandled exception has occurred. Please report steps to reproduce to Dahc. Details have been copied to your clipboard.");
                }
            }
            finally
            {

                MessageTooLong = false;
                MessageFragsSent = false;
            }
        }

        private void btnClusterBrowse_Click(object sender, EventArgs e)
        {
            var result = fbdCluster.ShowDialog();
            if (result != DialogResult.OK) { return; }

            txtCluster.Text = fbdCluster.SelectedPath;
            ClusterFolder = fbdCluster.SelectedPath;
        }

        private void btnSaveBrowse_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ClusterFolder))
            {
                ofdSaveFile.InitialDirectory = ClusterFolder;
            }

            ofdSaveFile.FileName = "";
            ofdSaveFile.Filter = "ARK map save files (*.ark)|*.ark";
            var result = ofdSaveFile.ShowDialog();
            if (result != DialogResult.OK) { return; }

            txtSave.Text = ofdSaveFile.FileName;
            SaveFilePath = ofdSaveFile.FileName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDinoType.Text) || string.IsNullOrWhiteSpace(txtClassContains.Text))
            {
                MessageBox.Show("Incomplete Data. You must fill both Dino Type and Class Name Contains.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvTrackList.Rows.Add(new[] { txtDinoType.Text, txtClassContains.Text });

            txtDinoType.Text = "";
            txtClassContains.Text = "";

            txtDinoType.Focus();
        }

        private void btnResetData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will clear the current Cluster folder and Save File locations. Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtCluster.Text = "";
                txtSave.Text = "";
                ClusterFolder = "";
                SaveFilePath = "";
            }
        }

        private void btnResetSettings_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will clear the current Announcer settings. Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgvTrackList.Rows.Clear();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvTrackList.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvTrackList.SelectedRows)
                {
                    dgvTrackList.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInterval.Text) || !IsInt(txtInterval.Text))
            {
                MessageBox.Show("Invalid interval.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvTrackList.RowCount < 1)
            {
                MessageBox.Show("There are no rows in the Settings grid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(ClusterFolder) || string.IsNullOrWhiteSpace(SaveFilePath))
            {
                MessageBox.Show("You must select both a cluster folder and a save file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtWebhookID.Text) || string.IsNullOrWhiteSpace(txtWebhookToken.Text) || !IsInt(txtWebhookID.Text))
            {
                MessageBox.Show("Invalid Webhook data. ID must be an integer and both fields must have an entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IntervalTimer.Interval = Convert.ToInt32(txtInterval.Text) * 1000;

            foreach (Control ctrl in Controls)
            {
                if (ctrl.Name != "btnStop") ctrl.Enabled = false;
            }

            IntervalTimer.Start();
            IntervalTimer_Tick(null, null);
        }

        #region Helpers

        public static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
                if (c < '0' || c > '9')
                    return false;
            return str.Length >= 1; //there must be at least one character here to continue
        }

        public static bool IsInt(string str)
        { //is not designed to handle null input or empty string
            if (string.IsNullOrWhiteSpace(str))
                return false;
            return str[0] == '-' && str.Length > 1 ? IsDigitsOnly(str.Substring(1)) : IsDigitsOnly(str);
        }

        #endregion

        private void IntervalTimer_Tick(object sender, EventArgs e)
        {
            SendAnnouncement();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            IntervalTimer.Stop();

            foreach (Control ctrl in Controls)
            {
                ctrl.Enabled = true;
            }
        }

        private void btnToggleToken_Click(object sender, EventArgs e)
        {
            if (txtWebhookToken.PasswordChar == char.MinValue)
            {
                txtWebhookToken.PasswordChar = '*';
                btnToggleToken.Text = "Show";
            }
            else
            {
                txtWebhookToken.PasswordChar = char.MinValue;
                btnToggleToken.Text = "Hide";
            }
        }
    }
}

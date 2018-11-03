namespace ArkDinoAnnouncer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveBrowse = new System.Windows.Forms.Button();
            this.btnClusterBrowse = new System.Windows.Forms.Button();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.txtCluster = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtClassContains = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDinoType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTrackList = new System.Windows.Forms.DataGridView();
            this.colTrackType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSearchString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnResetSettings = new System.Windows.Forms.Button();
            this.fbdCluster = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdSaveFile = new System.Windows.Forms.OpenFileDialog();
            this.btnResetData = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.IntervalTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnToggleToken = new System.Windows.Forms.Button();
            this.txtWebhookToken = new System.Windows.Forms.TextBox();
            this.txtWebhookID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrackList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSaveBrowse);
            this.groupBox1.Controls.Add(this.btnClusterBrowse);
            this.groupBox1.Controls.Add(this.txtSave);
            this.groupBox1.Controls.Add(this.txtCluster);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARK Data Location";
            // 
            // btnSaveBrowse
            // 
            this.btnSaveBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveBrowse.Location = new System.Drawing.Point(492, 44);
            this.btnSaveBrowse.Name = "btnSaveBrowse";
            this.btnSaveBrowse.Size = new System.Drawing.Size(75, 21);
            this.btnSaveBrowse.TabIndex = 5;
            this.btnSaveBrowse.Text = "Browse...";
            this.btnSaveBrowse.UseVisualStyleBackColor = true;
            this.btnSaveBrowse.Click += new System.EventHandler(this.btnSaveBrowse_Click);
            // 
            // btnClusterBrowse
            // 
            this.btnClusterBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClusterBrowse.Location = new System.Drawing.Point(492, 18);
            this.btnClusterBrowse.Name = "btnClusterBrowse";
            this.btnClusterBrowse.Size = new System.Drawing.Size(75, 21);
            this.btnClusterBrowse.TabIndex = 4;
            this.btnClusterBrowse.Text = "Browse...";
            this.btnClusterBrowse.UseVisualStyleBackColor = true;
            this.btnClusterBrowse.Click += new System.EventHandler(this.btnClusterBrowse_Click);
            // 
            // txtSave
            // 
            this.txtSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSave.Location = new System.Drawing.Point(86, 45);
            this.txtSave.Name = "txtSave";
            this.txtSave.ReadOnly = true;
            this.txtSave.Size = new System.Drawing.Size(390, 20);
            this.txtSave.TabIndex = 3;
            // 
            // txtCluster
            // 
            this.txtCluster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCluster.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCluster.Location = new System.Drawing.Point(86, 19);
            this.txtCluster.Name = "txtCluster";
            this.txtCluster.ReadOnly = true;
            this.txtCluster.Size = new System.Drawing.Size(390, 20);
            this.txtCluster.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Save File Path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cluster Folder:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtClassContains);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDinoType);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Announcer Settings";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(458, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Entry";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtClassContains
            // 
            this.txtClassContains.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassContains.Location = new System.Drawing.Point(131, 47);
            this.txtClassContains.Name = "txtClassContains";
            this.txtClassContains.Size = new System.Drawing.Size(310, 20);
            this.txtClassContains.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Class Name Containing:";
            // 
            // txtDinoType
            // 
            this.txtDinoType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDinoType.Location = new System.Drawing.Point(131, 19);
            this.txtDinoType.Name = "txtDinoType";
            this.txtDinoType.Size = new System.Drawing.Size(310, 20);
            this.txtDinoType.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dino Type:";
            // 
            // dgvTrackList
            // 
            this.dgvTrackList.AllowUserToAddRows = false;
            this.dgvTrackList.AllowUserToDeleteRows = false;
            this.dgvTrackList.AllowUserToResizeRows = false;
            this.dgvTrackList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrackList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrackList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTrackType,
            this.colSearchString});
            this.dgvTrackList.Location = new System.Drawing.Point(12, 187);
            this.dgvTrackList.Name = "dgvTrackList";
            this.dgvTrackList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTrackList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrackList.Size = new System.Drawing.Size(441, 227);
            this.dgvTrackList.TabIndex = 2;
            // 
            // colTrackType
            // 
            this.colTrackType.Frozen = true;
            this.colTrackType.HeaderText = "Dino Type";
            this.colTrackType.Name = "colTrackType";
            this.colTrackType.ReadOnly = true;
            this.colTrackType.Width = 180;
            // 
            // colSearchString
            // 
            this.colSearchString.Frozen = true;
            this.colSearchString.HeaderText = "Class Name Containing";
            this.colSearchString.Name = "colSearchString";
            this.colSearchString.ReadOnly = true;
            this.colSearchString.Width = 220;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(478, 187);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(109, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove Selection";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(478, 362);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start Announcer";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(478, 391);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(109, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop Announcer";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetSettings.Location = new System.Drawing.Point(478, 216);
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.Size = new System.Drawing.Size(109, 23);
            this.btnResetSettings.TabIndex = 8;
            this.btnResetSettings.Text = "Reset Settings";
            this.btnResetSettings.UseVisualStyleBackColor = true;
            this.btnResetSettings.Click += new System.EventHandler(this.btnResetSettings_Click);
            // 
            // ofdSaveFile
            // 
            this.ofdSaveFile.FileName = "openFileDialog1";
            // 
            // btnResetData
            // 
            this.btnResetData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetData.Location = new System.Drawing.Point(478, 245);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(109, 23);
            this.btnResetData.TabIndex = 9;
            this.btnResetData.Text = "Reset Folder/File";
            this.btnResetData.UseVisualStyleBackColor = true;
            this.btnResetData.Click += new System.EventHandler(this.btnResetData_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Interval (s):";
            // 
            // txtInterval
            // 
            this.txtInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInterval.Location = new System.Drawing.Point(537, 336);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtInterval.Size = new System.Drawing.Size(50, 20);
            this.txtInterval.TabIndex = 11;
            this.txtInterval.Text = "1800";
            // 
            // IntervalTimer
            // 
            this.IntervalTimer.Tick += new System.EventHandler(this.IntervalTimer_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnToggleToken);
            this.groupBox3.Controls.Add(this.txtWebhookToken);
            this.groupBox3.Controls.Add(this.txtWebhookID);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 420);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 77);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Discord Webhook";
            // 
            // btnToggleToken
            // 
            this.btnToggleToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleToken.Location = new System.Drawing.Point(492, 43);
            this.btnToggleToken.Name = "btnToggleToken";
            this.btnToggleToken.Size = new System.Drawing.Size(77, 23);
            this.btnToggleToken.TabIndex = 4;
            this.btnToggleToken.Text = "Hide";
            this.btnToggleToken.UseVisualStyleBackColor = true;
            this.btnToggleToken.Click += new System.EventHandler(this.btnToggleToken_Click);
            // 
            // txtWebhookToken
            // 
            this.txtWebhookToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWebhookToken.Location = new System.Drawing.Point(106, 45);
            this.txtWebhookToken.Name = "txtWebhookToken";
            this.txtWebhookToken.Size = new System.Drawing.Size(370, 20);
            this.txtWebhookToken.TabIndex = 3;
            // 
            // txtWebhookID
            // 
            this.txtWebhookID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWebhookID.Location = new System.Drawing.Point(106, 19);
            this.txtWebhookID.Name = "txtWebhookID";
            this.txtWebhookID.Size = new System.Drawing.Size(189, 20);
            this.txtWebhookID.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Webhook Token:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Webhook ID:";
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 509);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnResetData);
            this.Controls.Add(this.btnResetSettings);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvTrackList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "ARK Dino Announcer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrackList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveBrowse;
        private System.Windows.Forms.Button btnClusterBrowse;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.TextBox txtCluster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTrackList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtClassContains;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDinoType;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnResetSettings;
        private System.Windows.Forms.FolderBrowserDialog fbdCluster;
        private System.Windows.Forms.OpenFileDialog ofdSaveFile;
        private System.Windows.Forms.Button btnResetData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrackType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSearchString;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Timer IntervalTimer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnToggleToken;
        private System.Windows.Forms.TextBox txtWebhookToken;
        private System.Windows.Forms.TextBox txtWebhookID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}


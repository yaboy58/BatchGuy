namespace BatchGuy.App
{
    partial class CreateEAC3ToBatchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEAC3ToPath = new System.Windows.Forms.TextBox();
            this.txtBluRayPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBatFilePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBluRayEpisodeFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtChapterStreamNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMainSubtitleStreamNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMainAudioStreamNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMovieStreamNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBluRayStreamNumber = new System.Windows.Forms.TextBox();
            this.btnWriteToBatFile = new System.Windows.Forms.Button();
            this.lblAudioType = new System.Windows.Forms.Label();
            this.cbAudioType = new System.Windows.Forms.ComboBox();
            this.txtAudioSettings = new System.Windows.Forms.TextBox();
            this.lblAudioLanguage = new System.Windows.Forms.Label();
            this.cbAudioLanguage = new System.Windows.Forms.ComboBox();
            this.btnLoadBluRay = new System.Windows.Forms.Button();
            this.dgvBluRaySummary = new System.Windows.Forms.DataGridView();
            this.ignoreDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBluRaySummaryInfo = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBluRaySummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRaySummaryInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "eac3To Path";
            // 
            // txtEAC3ToPath
            // 
            this.txtEAC3ToPath.Location = new System.Drawing.Point(122, 54);
            this.txtEAC3ToPath.Name = "txtEAC3ToPath";
            this.txtEAC3ToPath.Size = new System.Drawing.Size(508, 20);
            this.txtEAC3ToPath.TabIndex = 1;
            this.txtEAC3ToPath.Text = "C:\\exe\\eac3to\\eac3to.exe";
            // 
            // txtBluRayPath
            // 
            this.txtBluRayPath.Location = new System.Drawing.Point(122, 19);
            this.txtBluRayPath.Name = "txtBluRayPath";
            this.txtBluRayPath.Size = new System.Drawing.Size(624, 20);
            this.txtBluRayPath.TabIndex = 0;
            this.txtBluRayPath.Text = "\\\\KENSHIRO\\My Old Encodes\\Blu-ray\\Hatchet II 2010 Unrated Directors Cut BluRay 72" +
    "0p DTS x264-EbP\\DISC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Blu-Ray Path";
            // 
            // txtBatFilePath
            // 
            this.txtBatFilePath.Location = new System.Drawing.Point(124, 90);
            this.txtBatFilePath.Name = "txtBatFilePath";
            this.txtBatFilePath.Size = new System.Drawing.Size(508, 20);
            this.txtBatFilePath.TabIndex = 2;
            this.txtBatFilePath.Text = "C:\\temp\\My Torrent Encodes\\Blu-ray";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bat File Path";
            // 
            // txtBluRayEpisodeFolder
            // 
            this.txtBluRayEpisodeFolder.Location = new System.Drawing.Point(139, 64);
            this.txtBluRayEpisodeFolder.Name = "txtBluRayEpisodeFolder";
            this.txtBluRayEpisodeFolder.Size = new System.Drawing.Size(53, 20);
            this.txtBluRayEpisodeFolder.TabIndex = 7;
            this.txtBluRayEpisodeFolder.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Blu-Ray Episode Folder";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtChapterStreamNumber);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMainSubtitleStreamNumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMainAudioStreamNumber);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMovieStreamNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBluRayStreamNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBluRayEpisodeFolder);
            this.groupBox1.Location = new System.Drawing.Point(35, 510);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 246);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stream Information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Chapter Stream#";
            // 
            // txtChapterStreamNumber
            // 
            this.txtChapterStreamNumber.Location = new System.Drawing.Point(139, 96);
            this.txtChapterStreamNumber.Name = "txtChapterStreamNumber";
            this.txtChapterStreamNumber.Size = new System.Drawing.Size(53, 20);
            this.txtChapterStreamNumber.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Main Subtitle Stream#";
            // 
            // txtMainSubtitleStreamNumber
            // 
            this.txtMainSubtitleStreamNumber.Location = new System.Drawing.Point(139, 188);
            this.txtMainSubtitleStreamNumber.Name = "txtMainSubtitleStreamNumber";
            this.txtMainSubtitleStreamNumber.Size = new System.Drawing.Size(53, 20);
            this.txtMainSubtitleStreamNumber.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Main Audio Stream#";
            // 
            // txtMainAudioStreamNumber
            // 
            this.txtMainAudioStreamNumber.Location = new System.Drawing.Point(139, 156);
            this.txtMainAudioStreamNumber.Name = "txtMainAudioStreamNumber";
            this.txtMainAudioStreamNumber.Size = new System.Drawing.Size(53, 20);
            this.txtMainAudioStreamNumber.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Movie Stream#";
            // 
            // txtMovieStreamNumber
            // 
            this.txtMovieStreamNumber.Location = new System.Drawing.Point(139, 126);
            this.txtMovieStreamNumber.Name = "txtMovieStreamNumber";
            this.txtMovieStreamNumber.Size = new System.Drawing.Size(53, 20);
            this.txtMovieStreamNumber.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Blu-Ray Stream#";
            // 
            // txtBluRayStreamNumber
            // 
            this.txtBluRayStreamNumber.Location = new System.Drawing.Point(139, 38);
            this.txtBluRayStreamNumber.Name = "txtBluRayStreamNumber";
            this.txtBluRayStreamNumber.Size = new System.Drawing.Size(53, 20);
            this.txtBluRayStreamNumber.TabIndex = 6;
            // 
            // btnWriteToBatFile
            // 
            this.btnWriteToBatFile.Location = new System.Drawing.Point(1144, 718);
            this.btnWriteToBatFile.Name = "btnWriteToBatFile";
            this.btnWriteToBatFile.Size = new System.Drawing.Size(133, 28);
            this.btnWriteToBatFile.TabIndex = 12;
            this.btnWriteToBatFile.Text = "Write To Bat File";
            this.btnWriteToBatFile.UseVisualStyleBackColor = true;
            this.btnWriteToBatFile.Click += new System.EventHandler(this.btnWriteToBatFile_Click);
            // 
            // lblAudioType
            // 
            this.lblAudioType.AutoSize = true;
            this.lblAudioType.Location = new System.Drawing.Point(32, 131);
            this.lblAudioType.Name = "lblAudioType";
            this.lblAudioType.Size = new System.Drawing.Size(64, 13);
            this.lblAudioType.TabIndex = 18;
            this.lblAudioType.Text = "Audio Type:";
            // 
            // cbAudioType
            // 
            this.cbAudioType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAudioType.FormattingEnabled = true;
            this.cbAudioType.Items.AddRange(new object[] {
            "DTS",
            "AC3",
            "FLAC",
            "TrueHD"});
            this.cbAudioType.Location = new System.Drawing.Point(122, 124);
            this.cbAudioType.Name = "cbAudioType";
            this.cbAudioType.Size = new System.Drawing.Size(148, 21);
            this.cbAudioType.TabIndex = 3;
            this.cbAudioType.SelectedIndexChanged += new System.EventHandler(this.cbAudioType_SelectedIndexChanged);
            // 
            // txtAudioSettings
            // 
            this.txtAudioSettings.Location = new System.Drawing.Point(276, 124);
            this.txtAudioSettings.Name = "txtAudioSettings";
            this.txtAudioSettings.Size = new System.Drawing.Size(356, 20);
            this.txtAudioSettings.TabIndex = 4;
            this.txtAudioSettings.Text = "-core";
            // 
            // lblAudioLanguage
            // 
            this.lblAudioLanguage.AutoSize = true;
            this.lblAudioLanguage.Location = new System.Drawing.Point(32, 164);
            this.lblAudioLanguage.Name = "lblAudioLanguage";
            this.lblAudioLanguage.Size = new System.Drawing.Size(88, 13);
            this.lblAudioLanguage.TabIndex = 20;
            this.lblAudioLanguage.Text = "Audio Language:";
            // 
            // cbAudioLanguage
            // 
            this.cbAudioLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAudioLanguage.FormattingEnabled = true;
            this.cbAudioLanguage.ItemHeight = 13;
            this.cbAudioLanguage.Items.AddRange(new object[] {
            "English",
            "Chinese",
            "Danish",
            "French",
            "Korean",
            "Spanish",
            "Swedish"});
            this.cbAudioLanguage.Location = new System.Drawing.Point(122, 157);
            this.cbAudioLanguage.Name = "cbAudioLanguage";
            this.cbAudioLanguage.Size = new System.Drawing.Size(148, 21);
            this.cbAudioLanguage.TabIndex = 5;
            // 
            // btnLoadBluRay
            // 
            this.btnLoadBluRay.Location = new System.Drawing.Point(1144, 178);
            this.btnLoadBluRay.Name = "btnLoadBluRay";
            this.btnLoadBluRay.Size = new System.Drawing.Size(133, 28);
            this.btnLoadBluRay.TabIndex = 21;
            this.btnLoadBluRay.Text = "Load Blu-ray";
            this.btnLoadBluRay.UseVisualStyleBackColor = true;
            this.btnLoadBluRay.Click += new System.EventHandler(this.btnLoadBluRay_Click);
            // 
            // dgvBluRaySummary
            // 
            this.dgvBluRaySummary.AllowUserToAddRows = false;
            this.dgvBluRaySummary.AutoGenerateColumns = false;
            this.dgvBluRaySummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBluRaySummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ignoreDataGridViewCheckBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.headerTextDataGridViewTextBoxColumn,
            this.detailTextDataGridViewTextBoxColumn});
            this.dgvBluRaySummary.DataSource = this.bsBluRaySummaryInfo;
            this.dgvBluRaySummary.Location = new System.Drawing.Point(26, 212);
            this.dgvBluRaySummary.Name = "dgvBluRaySummary";
            this.dgvBluRaySummary.Size = new System.Drawing.Size(1251, 150);
            this.dgvBluRaySummary.TabIndex = 22;
            this.dgvBluRaySummary.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBluRaySummary_CellDoubleClick);
            // 
            // ignoreDataGridViewCheckBoxColumn
            // 
            this.ignoreDataGridViewCheckBoxColumn.DataPropertyName = "Ignore";
            this.ignoreDataGridViewCheckBoxColumn.HeaderText = "Ignore";
            this.ignoreDataGridViewCheckBoxColumn.Name = "ignoreDataGridViewCheckBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // headerTextDataGridViewTextBoxColumn
            // 
            this.headerTextDataGridViewTextBoxColumn.DataPropertyName = "HeaderText";
            this.headerTextDataGridViewTextBoxColumn.HeaderText = "HeaderText";
            this.headerTextDataGridViewTextBoxColumn.Name = "headerTextDataGridViewTextBoxColumn";
            this.headerTextDataGridViewTextBoxColumn.Width = 350;
            // 
            // detailTextDataGridViewTextBoxColumn
            // 
            this.detailTextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detailTextDataGridViewTextBoxColumn.DataPropertyName = "DetailText";
            this.detailTextDataGridViewTextBoxColumn.HeaderText = "DetailText";
            this.detailTextDataGridViewTextBoxColumn.Name = "detailTextDataGridViewTextBoxColumn";
            // 
            // bsBluRaySummaryInfo
            // 
            this.bsBluRaySummaryInfo.DataSource = typeof(BatchGuy.App.Parser.Models.BluRaySummaryInfo);
            // 
            // CreateEAC3ToBatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 768);
            this.Controls.Add(this.dgvBluRaySummary);
            this.Controls.Add(this.btnLoadBluRay);
            this.Controls.Add(this.lblAudioLanguage);
            this.Controls.Add(this.cbAudioLanguage);
            this.Controls.Add(this.txtAudioSettings);
            this.Controls.Add(this.lblAudioType);
            this.Controls.Add(this.cbAudioType);
            this.Controls.Add(this.btnWriteToBatFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBatFilePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBluRayPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEAC3ToPath);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "CreateEAC3ToBatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create EAC3To Batch File";
            this.Load += new System.EventHandler(this.CreateEAC3ToBatchForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CreateEAC3ToBatchForm_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBluRaySummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRaySummaryInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEAC3ToPath;
        private System.Windows.Forms.TextBox txtBluRayPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBatFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBluRayEpisodeFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMainSubtitleStreamNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMainAudioStreamNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMovieStreamNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBluRayStreamNumber;
        private System.Windows.Forms.Button btnWriteToBatFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtChapterStreamNumber;
        private System.Windows.Forms.Label lblAudioType;
        private System.Windows.Forms.ComboBox cbAudioType;
        private System.Windows.Forms.TextBox txtAudioSettings;
        private System.Windows.Forms.Label lblAudioLanguage;
        private System.Windows.Forms.ComboBox cbAudioLanguage;
        private System.Windows.Forms.Button btnLoadBluRay;
        private System.Windows.Forms.BindingSource bsBluRaySummaryInfo;
        private System.Windows.Forms.DataGridView dgvBluRaySummary;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ignoreDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headerTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailTextDataGridViewTextBoxColumn;
    }
}
namespace BatchGuy.App
{
    partial class BluRayTitleInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BluRayTitleInfoForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbVideo = new System.Windows.Forms.GroupBox();
            this.chkVideo = new System.Windows.Forms.CheckBox();
            this.bsBluRayTitleVideo = new System.Windows.Forms.BindingSource(this.components);
            this.gbAudio = new System.Windows.Forms.GroupBox();
            this.panelAudioType = new System.Windows.Forms.Panel();
            this.lblAudioTypeArguments = new System.Windows.Forms.Label();
            this.txtAudioTypeArguments = new System.Windows.Forms.TextBox();
            this.cbAudioType = new System.Windows.Forms.ComboBox();
            this.lblAudioType = new System.Windows.Forms.Label();
            this.dgvAudio = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbSubtitles = new System.Windows.Forms.GroupBox();
            this.dgvSubtitles = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBluRayTitleSubtitles = new System.Windows.Forms.BindingSource(this.components);
            this.gbChapters = new System.Windows.Forms.GroupBox();
            this.chkChapters = new System.Windows.Forms.CheckBox();
            this.lblEpisodeNumber = new System.Windows.Forms.Label();
            this.txtEpisodeNumber = new System.Windows.Forms.TextBox();
            this.gbScreen = new System.Windows.Forms.GroupBox();
            this.txtEpisodeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bsBluRayTitleInfo = new System.Windows.Forms.BindingSource(this.components);
            this.bgwEac3toLoadTitle = new System.ComponentModel.BackgroundWorker();
            this.bsBluRayTitleAudio = new System.Windows.Forms.BindingSource(this.components);
            this.isSelectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCommentaryDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.audioTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.argumentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleVideo)).BeginInit();
            this.gbAudio.SuspendLayout();
            this.panelAudioType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudio)).BeginInit();
            this.gbSubtitles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubtitles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleSubtitles)).BeginInit();
            this.gbChapters.SuspendLayout();
            this.gbScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleAudio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(26, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // gbVideo
            // 
            this.gbVideo.Controls.Add(this.chkVideo);
            this.gbVideo.Location = new System.Drawing.Point(26, 54);
            this.gbVideo.Name = "gbVideo";
            this.gbVideo.Size = new System.Drawing.Size(904, 65);
            this.gbVideo.TabIndex = 1;
            this.gbVideo.TabStop = false;
            this.gbVideo.Text = "Video";
            // 
            // chkVideo
            // 
            this.chkVideo.AutoSize = true;
            this.chkVideo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsBluRayTitleVideo, "IsSelected", true));
            this.chkVideo.Location = new System.Drawing.Point(6, 28);
            this.chkVideo.Name = "chkVideo";
            this.chkVideo.Size = new System.Drawing.Size(53, 17);
            this.chkVideo.TabIndex = 4;
            this.chkVideo.Text = "Video";
            this.chkVideo.UseVisualStyleBackColor = true;
            this.chkVideo.CheckedChanged += new System.EventHandler(this.chkVideo_CheckedChanged);
            // 
            // bsBluRayTitleVideo
            // 
            this.bsBluRayTitleVideo.DataSource = typeof(BatchGuy.App.Parser.Models.BluRayTitleVideo);
            // 
            // gbAudio
            // 
            this.gbAudio.Controls.Add(this.panelAudioType);
            this.gbAudio.Controls.Add(this.dgvAudio);
            this.gbAudio.Location = new System.Drawing.Point(26, 136);
            this.gbAudio.Name = "gbAudio";
            this.gbAudio.Size = new System.Drawing.Size(904, 262);
            this.gbAudio.TabIndex = 2;
            this.gbAudio.TabStop = false;
            this.gbAudio.Text = "Audio";
            // 
            // panelAudioType
            // 
            this.panelAudioType.Controls.Add(this.lblAudioTypeArguments);
            this.panelAudioType.Controls.Add(this.txtAudioTypeArguments);
            this.panelAudioType.Controls.Add(this.cbAudioType);
            this.panelAudioType.Controls.Add(this.lblAudioType);
            this.panelAudioType.Enabled = false;
            this.panelAudioType.Location = new System.Drawing.Point(9, 195);
            this.panelAudioType.Name = "panelAudioType";
            this.panelAudioType.Size = new System.Drawing.Size(881, 53);
            this.panelAudioType.TabIndex = 1;
            // 
            // lblAudioTypeArguments
            // 
            this.lblAudioTypeArguments.AutoSize = true;
            this.lblAudioTypeArguments.Location = new System.Drawing.Point(306, 18);
            this.lblAudioTypeArguments.Name = "lblAudioTypeArguments";
            this.lblAudioTypeArguments.Size = new System.Drawing.Size(60, 13);
            this.lblAudioTypeArguments.TabIndex = 3;
            this.lblAudioTypeArguments.Text = "Arguments:";
            // 
            // txtAudioTypeArguments
            // 
            this.txtAudioTypeArguments.Location = new System.Drawing.Point(372, 11);
            this.txtAudioTypeArguments.Name = "txtAudioTypeArguments";
            this.txtAudioTypeArguments.Size = new System.Drawing.Size(288, 20);
            this.txtAudioTypeArguments.TabIndex = 10;
            this.txtAudioTypeArguments.TextChanged += new System.EventHandler(this.txtAudioTypeArguments_TextChanged);
            // 
            // cbAudioType
            // 
            this.cbAudioType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAudioType.FormattingEnabled = true;
            this.cbAudioType.Items.AddRange(new object[] {
            "AC3",
            "DTS",
            "DTSMA",
            "FLAC",
            "MPA",
            "TrueHD",
            "Wave"});
            this.cbAudioType.Location = new System.Drawing.Point(94, 10);
            this.cbAudioType.Name = "cbAudioType";
            this.cbAudioType.Size = new System.Drawing.Size(186, 21);
            this.cbAudioType.TabIndex = 8;
            this.cbAudioType.SelectedIndexChanged += new System.EventHandler(this.cbAudioType_SelectedIndexChanged);
            // 
            // lblAudioType
            // 
            this.lblAudioType.AutoSize = true;
            this.lblAudioType.Location = new System.Drawing.Point(21, 18);
            this.lblAudioType.Name = "lblAudioType";
            this.lblAudioType.Size = new System.Drawing.Size(64, 13);
            this.lblAudioType.TabIndex = 0;
            this.lblAudioType.Text = "Audio Type:";
            // 
            // dgvAudio
            // 
            this.dgvAudio.AllowUserToAddRows = false;
            this.dgvAudio.AllowUserToDeleteRows = false;
            this.dgvAudio.AllowUserToOrderColumns = true;
            this.dgvAudio.AutoGenerateColumns = false;
            this.dgvAudio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAudio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isSelectedDataGridViewCheckBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.languageDataGridViewTextBoxColumn,
            this.isCommentaryDataGridViewCheckBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.audioTypeDataGridViewTextBoxColumn,
            this.argumentsDataGridViewTextBoxColumn});
            this.dgvAudio.DataSource = this.bsBluRayTitleAudio;
            this.dgvAudio.Location = new System.Drawing.Point(9, 30);
            this.dgvAudio.Name = "dgvAudio";
            this.dgvAudio.Size = new System.Drawing.Size(881, 146);
            this.dgvAudio.TabIndex = 6;
            this.dgvAudio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAudio_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(848, 656);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 25);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbSubtitles
            // 
            this.gbSubtitles.Controls.Add(this.dgvSubtitles);
            this.gbSubtitles.Location = new System.Drawing.Point(26, 404);
            this.gbSubtitles.Name = "gbSubtitles";
            this.gbSubtitles.Size = new System.Drawing.Size(904, 192);
            this.gbSubtitles.TabIndex = 4;
            this.gbSubtitles.TabStop = false;
            this.gbSubtitles.Text = "Subtitles";
            // 
            // dgvSubtitles
            // 
            this.dgvSubtitles.AllowUserToAddRows = false;
            this.dgvSubtitles.AllowUserToDeleteRows = false;
            this.dgvSubtitles.AllowUserToOrderColumns = true;
            this.dgvSubtitles.AutoGenerateColumns = false;
            this.dgvSubtitles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubtitles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvSubtitles.DataSource = this.bsBluRayTitleSubtitles;
            this.dgvSubtitles.Location = new System.Drawing.Point(9, 30);
            this.dgvSubtitles.Name = "dgvSubtitles";
            this.dgvSubtitles.Size = new System.Drawing.Size(881, 146);
            this.dgvSubtitles.TabIndex = 12;
            this.dgvSubtitles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubtitles_CellClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsSelected";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Is Selected";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 100;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "eac3to Track Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 120;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Language";
            this.dataGridViewTextBoxColumn2.HeaderText = "Language";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Text";
            this.dataGridViewTextBoxColumn3.HeaderText = "Text";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 250;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // bsBluRayTitleSubtitles
            // 
            this.bsBluRayTitleSubtitles.DataSource = typeof(BatchGuy.App.Parser.Models.BluRayTitleSubtitle);
            // 
            // gbChapters
            // 
            this.gbChapters.Controls.Add(this.chkChapters);
            this.gbChapters.Location = new System.Drawing.Point(29, 602);
            this.gbChapters.Name = "gbChapters";
            this.gbChapters.Size = new System.Drawing.Size(901, 48);
            this.gbChapters.TabIndex = 5;
            this.gbChapters.TabStop = false;
            this.gbChapters.Text = "Chapters";
            // 
            // chkChapters
            // 
            this.chkChapters.AutoSize = true;
            this.chkChapters.Location = new System.Drawing.Point(11, 19);
            this.chkChapters.Name = "chkChapters";
            this.chkChapters.Size = new System.Drawing.Size(68, 17);
            this.chkChapters.TabIndex = 14;
            this.chkChapters.Text = "Chapters";
            this.chkChapters.UseVisualStyleBackColor = true;
            this.chkChapters.CheckedChanged += new System.EventHandler(this.chkChapters_CheckedChanged);
            // 
            // lblEpisodeNumber
            // 
            this.lblEpisodeNumber.AutoSize = true;
            this.lblEpisodeNumber.Location = new System.Drawing.Point(418, 19);
            this.lblEpisodeNumber.Name = "lblEpisodeNumber";
            this.lblEpisodeNumber.Size = new System.Drawing.Size(58, 13);
            this.lblEpisodeNumber.TabIndex = 6;
            this.lblEpisodeNumber.Text = "Episode #:";
            // 
            // txtEpisodeNumber
            // 
            this.txtEpisodeNumber.Location = new System.Drawing.Point(482, 16);
            this.txtEpisodeNumber.Name = "txtEpisodeNumber";
            this.txtEpisodeNumber.Size = new System.Drawing.Size(65, 20);
            this.txtEpisodeNumber.TabIndex = 0;
            this.txtEpisodeNumber.TextChanged += new System.EventHandler(this.txtEpisodeNumber_TextChanged);
            // 
            // gbScreen
            // 
            this.gbScreen.Controls.Add(this.txtEpisodeName);
            this.gbScreen.Controls.Add(this.label1);
            this.gbScreen.Controls.Add(this.txtEpisodeNumber);
            this.gbScreen.Controls.Add(this.gbChapters);
            this.gbScreen.Controls.Add(this.lblEpisodeNumber);
            this.gbScreen.Controls.Add(this.gbSubtitles);
            this.gbScreen.Controls.Add(this.btnUpdate);
            this.gbScreen.Controls.Add(this.gbAudio);
            this.gbScreen.Controls.Add(this.lblTitle);
            this.gbScreen.Controls.Add(this.gbVideo);
            this.gbScreen.Location = new System.Drawing.Point(12, 12);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Size = new System.Drawing.Size(951, 689);
            this.gbScreen.TabIndex = 7;
            this.gbScreen.TabStop = false;
            // 
            // txtEpisodeName
            // 
            this.txtEpisodeName.Location = new System.Drawing.Point(642, 16);
            this.txtEpisodeName.Name = "txtEpisodeName";
            this.txtEpisodeName.Size = new System.Drawing.Size(288, 20);
            this.txtEpisodeName.TabIndex = 2;
            this.txtEpisodeName.TextChanged += new System.EventHandler(this.txtEpisodeName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Episode Name:";
            // 
            // bsBluRayTitleInfo
            // 
            this.bsBluRayTitleInfo.DataSource = typeof(BatchGuy.App.Parser.Models.BluRayTitleInfo);
            // 
            // bgwEac3toLoadTitle
            // 
            this.bgwEac3toLoadTitle.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwEac3toLoadTitle_DoWork);
            this.bgwEac3toLoadTitle.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwEac3toLoadTitle_RunWorkerCompleted);
            // 
            // bsBluRayTitleAudio
            // 
            this.bsBluRayTitleAudio.AllowNew = true;
            this.bsBluRayTitleAudio.DataSource = typeof(BatchGuy.App.Parser.Models.BluRayTitleAudio);
            // 
            // isSelectedDataGridViewCheckBoxColumn
            // 
            this.isSelectedDataGridViewCheckBoxColumn.DataPropertyName = "IsSelected";
            this.isSelectedDataGridViewCheckBoxColumn.HeaderText = "Is Selected";
            this.isSelectedDataGridViewCheckBoxColumn.MinimumWidth = 100;
            this.isSelectedDataGridViewCheckBoxColumn.Name = "isSelectedDataGridViewCheckBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "eac3to Track Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 120;
            // 
            // languageDataGridViewTextBoxColumn
            // 
            this.languageDataGridViewTextBoxColumn.DataPropertyName = "Language";
            this.languageDataGridViewTextBoxColumn.HeaderText = "Language";
            this.languageDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.languageDataGridViewTextBoxColumn.Name = "languageDataGridViewTextBoxColumn";
            this.languageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isCommentaryDataGridViewCheckBoxColumn
            // 
            this.isCommentaryDataGridViewCheckBoxColumn.DataPropertyName = "IsCommentary";
            this.isCommentaryDataGridViewCheckBoxColumn.HeaderText = "Is Commentary";
            this.isCommentaryDataGridViewCheckBoxColumn.MinimumWidth = 120;
            this.isCommentaryDataGridViewCheckBoxColumn.Name = "isCommentaryDataGridViewCheckBoxColumn";
            this.isCommentaryDataGridViewCheckBoxColumn.Width = 120;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.MinimumWidth = 300;
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // audioTypeDataGridViewTextBoxColumn
            // 
            this.audioTypeDataGridViewTextBoxColumn.DataPropertyName = "AudioType";
            this.audioTypeDataGridViewTextBoxColumn.HeaderText = "AudioType";
            this.audioTypeDataGridViewTextBoxColumn.Name = "audioTypeDataGridViewTextBoxColumn";
            this.audioTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // argumentsDataGridViewTextBoxColumn
            // 
            this.argumentsDataGridViewTextBoxColumn.DataPropertyName = "Arguments";
            this.argumentsDataGridViewTextBoxColumn.HeaderText = "Arguments";
            this.argumentsDataGridViewTextBoxColumn.Name = "argumentsDataGridViewTextBoxColumn";
            this.argumentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // BluRayTitleInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 713);
            this.Controls.Add(this.gbScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BluRayTitleInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Blu-ray Title Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BluRayTitleInfoForm_FormClosing);
            this.Load += new System.EventHandler(this.BluRayTitleForm_Load);
            this.gbVideo.ResumeLayout(false);
            this.gbVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleVideo)).EndInit();
            this.gbAudio.ResumeLayout(false);
            this.panelAudioType.ResumeLayout(false);
            this.panelAudioType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudio)).EndInit();
            this.gbSubtitles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubtitles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleSubtitles)).EndInit();
            this.gbChapters.ResumeLayout(false);
            this.gbChapters.PerformLayout();
            this.gbScreen.ResumeLayout(false);
            this.gbScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleAudio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbVideo;
        private System.Windows.Forms.CheckBox chkVideo;
        private System.Windows.Forms.BindingSource bsBluRayTitleInfo;
        private System.Windows.Forms.BindingSource bsBluRayTitleVideo;
        private System.Windows.Forms.GroupBox gbAudio;
        private System.Windows.Forms.DataGridView dgvAudio;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panelAudioType;
        private System.Windows.Forms.TextBox txtAudioTypeArguments;
        private System.Windows.Forms.ComboBox cbAudioType;
        private System.Windows.Forms.Label lblAudioType;
        private System.Windows.Forms.Label lblAudioTypeArguments;
        private System.Windows.Forms.GroupBox gbSubtitles;
        private System.Windows.Forms.DataGridView dgvSubtitles;
        private System.Windows.Forms.BindingSource bsBluRayTitleSubtitles;
        private System.Windows.Forms.GroupBox gbChapters;
        private System.Windows.Forms.CheckBox chkChapters;
        private System.Windows.Forms.Label lblEpisodeNumber;
        private System.Windows.Forms.TextBox txtEpisodeNumber;
        private System.Windows.Forms.GroupBox gbScreen;
        private System.ComponentModel.BackgroundWorker bgwEac3toLoadTitle;
        private System.Windows.Forms.TextBox txtEpisodeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSelectedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCommentaryDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn audioTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn argumentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsBluRayTitleAudio;
    }
}
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAudioTypeArguments = new System.Windows.Forms.Label();
            this.txtAudioTypeArguments = new System.Windows.Forms.TextBox();
            this.cbAudioType = new System.Windows.Forms.ComboBox();
            this.lblAudioType = new System.Windows.Forms.Label();
            this.dgvAudio = new System.Windows.Forms.DataGridView();
            this.isSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.audioType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arguments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBluRayTitleAudio = new System.Windows.Forms.BindingSource(this.components);
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
            this.bsBluRayTitleInfo = new System.Windows.Forms.BindingSource(this.components);
            this.bgwEac3toLoadTitle = new System.ComponentModel.BackgroundWorker();
            this.gbVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleVideo)).BeginInit();
            this.gbAudio.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleAudio)).BeginInit();
            this.gbSubtitles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubtitles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleSubtitles)).BeginInit();
            this.gbChapters.SuspendLayout();
            this.gbScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleInfo)).BeginInit();
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
            this.chkVideo.TabIndex = 1;
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
            this.gbAudio.Controls.Add(this.panel1);
            this.gbAudio.Controls.Add(this.dgvAudio);
            this.gbAudio.Location = new System.Drawing.Point(26, 136);
            this.gbAudio.Name = "gbAudio";
            this.gbAudio.Size = new System.Drawing.Size(904, 262);
            this.gbAudio.TabIndex = 2;
            this.gbAudio.TabStop = false;
            this.gbAudio.Text = "Audio";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAudioTypeArguments);
            this.panel1.Controls.Add(this.txtAudioTypeArguments);
            this.panel1.Controls.Add(this.cbAudioType);
            this.panel1.Controls.Add(this.lblAudioType);
            this.panel1.Location = new System.Drawing.Point(9, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 53);
            this.panel1.TabIndex = 1;
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
            this.txtAudioTypeArguments.TabIndex = 4;
            this.txtAudioTypeArguments.TextChanged += new System.EventHandler(this.txtAudioTypeArguments_TextChanged);
            // 
            // cbAudioType
            // 
            this.cbAudioType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAudioType.FormattingEnabled = true;
            this.cbAudioType.Items.AddRange(new object[] {
            "AC3",
            "DTS",
            "FLAC",
            "TrueHD",
            "MPA"});
            this.cbAudioType.Location = new System.Drawing.Point(94, 10);
            this.cbAudioType.Name = "cbAudioType";
            this.cbAudioType.Size = new System.Drawing.Size(186, 21);
            this.cbAudioType.TabIndex = 3;
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
            this.isSelected,
            this.id,
            this.language,
            this.text,
            this.audioType,
            this.arguments});
            this.dgvAudio.DataSource = this.bsBluRayTitleAudio;
            this.dgvAudio.Location = new System.Drawing.Point(9, 30);
            this.dgvAudio.Name = "dgvAudio";
            this.dgvAudio.Size = new System.Drawing.Size(881, 146);
            this.dgvAudio.TabIndex = 2;
            this.dgvAudio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAudio_CellClick);
            // 
            // isSelected
            // 
            this.isSelected.DataPropertyName = "IsSelected";
            this.isSelected.HeaderText = "Is Selected";
            this.isSelected.Name = "isSelected";
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // language
            // 
            this.language.DataPropertyName = "Language";
            this.language.HeaderText = "Language";
            this.language.Name = "language";
            this.language.ReadOnly = true;
            // 
            // text
            // 
            this.text.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.text.DataPropertyName = "Text";
            this.text.HeaderText = "Text";
            this.text.Name = "text";
            this.text.ReadOnly = true;
            // 
            // audioType
            // 
            this.audioType.DataPropertyName = "AudioType";
            this.audioType.HeaderText = "Audio Type";
            this.audioType.Name = "audioType";
            this.audioType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.audioType.Visible = false;
            // 
            // arguments
            // 
            this.arguments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arguments.DataPropertyName = "Arguments";
            this.arguments.HeaderText = "Arguments";
            this.arguments.Name = "arguments";
            this.arguments.Visible = false;
            // 
            // bsBluRayTitleAudio
            // 
            this.bsBluRayTitleAudio.DataSource = typeof(BatchGuy.App.Parser.Models.BluRayTitleAudio);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(848, 656);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 25);
            this.btnUpdate.TabIndex = 3;
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
            this.dgvSubtitles.TabIndex = 5;
            this.dgvSubtitles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubtitles_CellClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsSelected";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Is Selected";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Language";
            this.dataGridViewTextBoxColumn2.HeaderText = "Language";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Text";
            this.dataGridViewTextBoxColumn3.HeaderText = "Text";
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
            this.chkChapters.TabIndex = 6;
            this.chkChapters.Text = "Chapters";
            this.chkChapters.UseVisualStyleBackColor = true;
            this.chkChapters.CheckedChanged += new System.EventHandler(this.chkChapters_CheckedChanged);
            // 
            // lblEpisodeNumber
            // 
            this.lblEpisodeNumber.AutoSize = true;
            this.lblEpisodeNumber.Location = new System.Drawing.Point(777, 19);
            this.lblEpisodeNumber.Name = "lblEpisodeNumber";
            this.lblEpisodeNumber.Size = new System.Drawing.Size(58, 13);
            this.lblEpisodeNumber.TabIndex = 6;
            this.lblEpisodeNumber.Text = "Episode #:";
            // 
            // txtEpisodeNumber
            // 
            this.txtEpisodeNumber.Location = new System.Drawing.Point(840, 16);
            this.txtEpisodeNumber.Name = "txtEpisodeNumber";
            this.txtEpisodeNumber.Size = new System.Drawing.Size(90, 20);
            this.txtEpisodeNumber.TabIndex = 0;
            this.txtEpisodeNumber.TextChanged += new System.EventHandler(this.txtEpisodeNumber_TextChanged);
            // 
            // gbScreen
            // 
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
            // bsBluRayTitleInfo
            // 
            this.bsBluRayTitleInfo.DataSource = typeof(BatchGuy.App.Parser.Models.BluRayTitleInfo);
            // 
            // bgwEac3toLoadTitle
            // 
            this.bgwEac3toLoadTitle.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwEac3toLoadTitle_DoWork);
            this.bgwEac3toLoadTitle.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwEac3toLoadTitle_RunWorkerCompleted);
            // 
            // BluRayTitleInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 713);
            this.Controls.Add(this.gbScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BluRayTitleInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Blu-ray Title Info Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BluRayTitleInfoForm_FormClosing);
            this.Load += new System.EventHandler(this.BluRayTitleForm_Load);
            this.gbVideo.ResumeLayout(false);
            this.gbVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleVideo)).EndInit();
            this.gbAudio.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleAudio)).EndInit();
            this.gbSubtitles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubtitles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleSubtitles)).EndInit();
            this.gbChapters.ResumeLayout(false);
            this.gbChapters.PerformLayout();
            this.gbScreen.ResumeLayout(false);
            this.gbScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleInfo)).EndInit();
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
        private System.Windows.Forms.BindingSource bsBluRayTitleAudio;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn language;
        private System.Windows.Forms.DataGridViewTextBoxColumn text;
        private System.Windows.Forms.DataGridViewTextBoxColumn audioType;
        private System.Windows.Forms.DataGridViewTextBoxColumn arguments;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox gbScreen;
        private System.ComponentModel.BackgroundWorker bgwEac3toLoadTitle;
    }
}
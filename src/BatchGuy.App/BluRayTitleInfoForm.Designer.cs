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
            this.isSelectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCommentaryDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.audioTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.argumentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBluRayTitleAudio = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbSubtitles = new System.Windows.Forms.GroupBox();
            this.dgvSubtitles = new System.Windows.Forms.DataGridView();
            this.isSelectedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCommentaryDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExternalSubtitlePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddSubtitle = new System.Windows.Forms.DataGridViewImageColumn();
            this.RemoveSubtitle = new System.Windows.Forms.DataGridViewImageColumn();
            this.bsBluRayTitleSubtitles = new System.Windows.Forms.BindingSource(this.components);
            this.gbChapters = new System.Windows.Forms.GroupBox();
            this.chkChapters = new System.Windows.Forms.CheckBox();
            this.lblEpisodeNumber = new System.Windows.Forms.Label();
            this.txtEpisodeNumber = new System.Windows.Forms.TextBox();
            this.gbScreen = new System.Windows.Forms.GroupBox();
            this.gbMKVToolNixGUI = new System.Windows.Forms.GroupBox();
            this.gbMKVToolNixGUIGeneralOptions = new System.Windows.Forms.GroupBox();
            this.cbMKVToolNixGUICompression = new System.Windows.Forms.ComboBox();
            this.lblMKVToolNixGUICompression = new System.Windows.Forms.Label();
            this.cbMKVToolNixGUIForcedTrackFlag = new System.Windows.Forms.ComboBox();
            this.lblMKVToolNixGUIForcedTrackFlag = new System.Windows.Forms.Label();
            this.cbMKVToolNixGUIDefaultTrackFlag = new System.Windows.Forms.ComboBox();
            this.lblMKVToolNixGUIDefaultTrackFlag = new System.Windows.Forms.Label();
            this.txtMKVToolNixGUITrackName = new System.Windows.Forms.TextBox();
            this.lblMKVToolNixGUITrackName = new System.Windows.Forms.Label();
            this.cbMKVToolNixGUILanguage = new System.Windows.Forms.ComboBox();
            this.bsMKVMergeLanguageItem = new System.Windows.Forms.BindingSource(this.components);
            this.lblMKVToolNixGUILanguage = new System.Windows.Forms.Label();
            this.txtEpisodeName = new System.Windows.Forms.TextBox();
            this.lblEpisodeName = new System.Windows.Forms.Label();
            this.bgwEac3toLoadTitle = new System.ComponentModel.BackgroundWorker();
            this.bsBluRayTitleInfo = new System.Windows.Forms.BindingSource(this.components);
            this.ofdFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleVideo)).BeginInit();
            this.gbAudio.SuspendLayout();
            this.panelAudioType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleAudio)).BeginInit();
            this.gbSubtitles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubtitles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleSubtitles)).BeginInit();
            this.gbChapters.SuspendLayout();
            this.gbScreen.SuspendLayout();
            this.gbMKVToolNixGUI.SuspendLayout();
            this.gbMKVToolNixGUIGeneralOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMKVMergeLanguageItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(26, 25);
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
            "LPCM",
            "MPA",
            "TrueHD"});
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
            // bsBluRayTitleAudio
            // 
            this.bsBluRayTitleAudio.AllowNew = true;
            this.bsBluRayTitleAudio.DataSource = typeof(BatchGuy.App.Parser.Models.BluRayTitleAudio);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1246, 697);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 25);
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
            this.gbSubtitles.Size = new System.Drawing.Size(904, 234);
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
            this.isSelectedDataGridViewCheckBoxColumn1,
            this.idDataGridViewTextBoxColumn1,
            this.languageDataGridViewTextBoxColumn1,
            this.isCommentaryDataGridViewCheckBoxColumn1,
            this.textDataGridViewTextBoxColumn1,
            this.ExternalSubtitlePath,
            this.AddSubtitle,
            this.RemoveSubtitle});
            this.dgvSubtitles.DataSource = this.bsBluRayTitleSubtitles;
            this.dgvSubtitles.Location = new System.Drawing.Point(9, 30);
            this.dgvSubtitles.Name = "dgvSubtitles";
            this.dgvSubtitles.Size = new System.Drawing.Size(881, 198);
            this.dgvSubtitles.TabIndex = 12;
            this.dgvSubtitles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubtitles_CellClick);
            this.dgvSubtitles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubtitles_CellDoubleClick);
            // 
            // isSelectedDataGridViewCheckBoxColumn1
            // 
            this.isSelectedDataGridViewCheckBoxColumn1.DataPropertyName = "IsSelected";
            this.isSelectedDataGridViewCheckBoxColumn1.HeaderText = "Is Selected";
            this.isSelectedDataGridViewCheckBoxColumn1.MinimumWidth = 100;
            this.isSelectedDataGridViewCheckBoxColumn1.Name = "isSelectedDataGridViewCheckBoxColumn1";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "eac3to Track Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 120;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 120;
            // 
            // languageDataGridViewTextBoxColumn1
            // 
            this.languageDataGridViewTextBoxColumn1.DataPropertyName = "Language";
            this.languageDataGridViewTextBoxColumn1.HeaderText = "Language";
            this.languageDataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.languageDataGridViewTextBoxColumn1.Name = "languageDataGridViewTextBoxColumn1";
            this.languageDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // isCommentaryDataGridViewCheckBoxColumn1
            // 
            this.isCommentaryDataGridViewCheckBoxColumn1.DataPropertyName = "IsCommentary";
            this.isCommentaryDataGridViewCheckBoxColumn1.HeaderText = "Is Commentary";
            this.isCommentaryDataGridViewCheckBoxColumn1.MinimumWidth = 120;
            this.isCommentaryDataGridViewCheckBoxColumn1.Name = "isCommentaryDataGridViewCheckBoxColumn1";
            this.isCommentaryDataGridViewCheckBoxColumn1.Width = 120;
            // 
            // textDataGridViewTextBoxColumn1
            // 
            this.textDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.textDataGridViewTextBoxColumn1.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn1.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn1.MinimumWidth = 200;
            this.textDataGridViewTextBoxColumn1.Name = "textDataGridViewTextBoxColumn1";
            this.textDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ExternalSubtitlePath
            // 
            this.ExternalSubtitlePath.DataPropertyName = "ExternalSubtitlePath";
            this.ExternalSubtitlePath.HeaderText = "External Subtitle";
            this.ExternalSubtitlePath.MinimumWidth = 100;
            this.ExternalSubtitlePath.Name = "ExternalSubtitlePath";
            this.ExternalSubtitlePath.ReadOnly = true;
            this.ExternalSubtitlePath.Width = 148;
            // 
            // AddSubtitle
            // 
            this.AddSubtitle.HeaderText = "Add Subtitle";
            this.AddSubtitle.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.AddSubtitle.MinimumWidth = 50;
            this.AddSubtitle.Name = "AddSubtitle";
            this.AddSubtitle.ReadOnly = true;
            this.AddSubtitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AddSubtitle.ToolTipText = "Add Subtitle";
            this.AddSubtitle.Width = 50;
            // 
            // RemoveSubtitle
            // 
            this.RemoveSubtitle.HeaderText = "Remove Subtitle";
            this.RemoveSubtitle.Image = global::BatchGuy.App.Properties.Resources.Iconfinder_1472897142_DeleteRed;
            this.RemoveSubtitle.MinimumWidth = 60;
            this.RemoveSubtitle.Name = "RemoveSubtitle";
            this.RemoveSubtitle.ReadOnly = true;
            this.RemoveSubtitle.ToolTipText = "Remove Subtitle";
            this.RemoveSubtitle.Width = 60;
            // 
            // bsBluRayTitleSubtitles
            // 
            this.bsBluRayTitleSubtitles.DataSource = typeof(BatchGuy.App.Parser.Models.BluRayTitleSubtitle);
            // 
            // gbChapters
            // 
            this.gbChapters.Controls.Add(this.chkChapters);
            this.gbChapters.Location = new System.Drawing.Point(29, 644);
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
            this.lblEpisodeNumber.Location = new System.Drawing.Point(418, 25);
            this.lblEpisodeNumber.Name = "lblEpisodeNumber";
            this.lblEpisodeNumber.Size = new System.Drawing.Size(58, 13);
            this.lblEpisodeNumber.TabIndex = 6;
            this.lblEpisodeNumber.Text = "Episode #:";
            // 
            // txtEpisodeNumber
            // 
            this.txtEpisodeNumber.Location = new System.Drawing.Point(482, 22);
            this.txtEpisodeNumber.Name = "txtEpisodeNumber";
            this.txtEpisodeNumber.Size = new System.Drawing.Size(65, 20);
            this.txtEpisodeNumber.TabIndex = 0;
            this.txtEpisodeNumber.TextChanged += new System.EventHandler(this.txtEpisodeNumber_TextChanged);
            // 
            // gbScreen
            // 
            this.gbScreen.Controls.Add(this.gbMKVToolNixGUI);
            this.gbScreen.Controls.Add(this.txtEpisodeName);
            this.gbScreen.Controls.Add(this.lblEpisodeName);
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
            this.gbScreen.Size = new System.Drawing.Size(1395, 732);
            this.gbScreen.TabIndex = 7;
            this.gbScreen.TabStop = false;
            // 
            // gbMKVToolNixGUI
            // 
            this.gbMKVToolNixGUI.Controls.Add(this.gbMKVToolNixGUIGeneralOptions);
            this.gbMKVToolNixGUI.Location = new System.Drawing.Point(938, 12);
            this.gbMKVToolNixGUI.Name = "gbMKVToolNixGUI";
            this.gbMKVToolNixGUI.Size = new System.Drawing.Size(451, 679);
            this.gbMKVToolNixGUI.TabIndex = 17;
            this.gbMKVToolNixGUI.TabStop = false;
            this.gbMKVToolNixGUI.Text = "MKVToolNix GUI";
            // 
            // gbMKVToolNixGUIGeneralOptions
            // 
            this.gbMKVToolNixGUIGeneralOptions.Controls.Add(this.cbMKVToolNixGUICompression);
            this.gbMKVToolNixGUIGeneralOptions.Controls.Add(this.lblMKVToolNixGUICompression);
            this.gbMKVToolNixGUIGeneralOptions.Controls.Add(this.cbMKVToolNixGUIForcedTrackFlag);
            this.gbMKVToolNixGUIGeneralOptions.Controls.Add(this.lblMKVToolNixGUIForcedTrackFlag);
            this.gbMKVToolNixGUIGeneralOptions.Controls.Add(this.cbMKVToolNixGUIDefaultTrackFlag);
            this.gbMKVToolNixGUIGeneralOptions.Controls.Add(this.lblMKVToolNixGUIDefaultTrackFlag);
            this.gbMKVToolNixGUIGeneralOptions.Controls.Add(this.txtMKVToolNixGUITrackName);
            this.gbMKVToolNixGUIGeneralOptions.Controls.Add(this.lblMKVToolNixGUITrackName);
            this.gbMKVToolNixGUIGeneralOptions.Controls.Add(this.cbMKVToolNixGUILanguage);
            this.gbMKVToolNixGUIGeneralOptions.Controls.Add(this.lblMKVToolNixGUILanguage);
            this.gbMKVToolNixGUIGeneralOptions.Location = new System.Drawing.Point(6, 31);
            this.gbMKVToolNixGUIGeneralOptions.Name = "gbMKVToolNixGUIGeneralOptions";
            this.gbMKVToolNixGUIGeneralOptions.Size = new System.Drawing.Size(439, 213);
            this.gbMKVToolNixGUIGeneralOptions.TabIndex = 16;
            this.gbMKVToolNixGUIGeneralOptions.TabStop = false;
            this.gbMKVToolNixGUIGeneralOptions.Text = "General Options";
            // 
            // cbMKVToolNixGUICompression
            // 
            this.cbMKVToolNixGUICompression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMKVToolNixGUICompression.FormattingEnabled = true;
            this.cbMKVToolNixGUICompression.Items.AddRange(new object[] {
            "determine automatically",
            "no extra compression",
            "zlib"});
            this.cbMKVToolNixGUICompression.Location = new System.Drawing.Point(117, 179);
            this.cbMKVToolNixGUICompression.Name = "cbMKVToolNixGUICompression";
            this.cbMKVToolNixGUICompression.Size = new System.Drawing.Size(249, 21);
            this.cbMKVToolNixGUICompression.TabIndex = 25;
            this.cbMKVToolNixGUICompression.SelectedIndexChanged += new System.EventHandler(this.cbMKVToolNixGUICompression_SelectedIndexChanged);
            // 
            // lblMKVToolNixGUICompression
            // 
            this.lblMKVToolNixGUICompression.AutoSize = true;
            this.lblMKVToolNixGUICompression.Location = new System.Drawing.Point(13, 187);
            this.lblMKVToolNixGUICompression.Name = "lblMKVToolNixGUICompression";
            this.lblMKVToolNixGUICompression.Size = new System.Drawing.Size(70, 13);
            this.lblMKVToolNixGUICompression.TabIndex = 24;
            this.lblMKVToolNixGUICompression.Text = "Compression:";
            // 
            // cbMKVToolNixGUIForcedTrackFlag
            // 
            this.cbMKVToolNixGUIForcedTrackFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMKVToolNixGUIForcedTrackFlag.FormattingEnabled = true;
            this.cbMKVToolNixGUIForcedTrackFlag.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.cbMKVToolNixGUIForcedTrackFlag.Location = new System.Drawing.Point(116, 144);
            this.cbMKVToolNixGUIForcedTrackFlag.Name = "cbMKVToolNixGUIForcedTrackFlag";
            this.cbMKVToolNixGUIForcedTrackFlag.Size = new System.Drawing.Size(249, 21);
            this.cbMKVToolNixGUIForcedTrackFlag.TabIndex = 23;
            this.cbMKVToolNixGUIForcedTrackFlag.SelectedIndexChanged += new System.EventHandler(this.cbMKVToolNixGUIForcedTrackFlag_SelectedIndexChanged);
            // 
            // lblMKVToolNixGUIForcedTrackFlag
            // 
            this.lblMKVToolNixGUIForcedTrackFlag.AutoSize = true;
            this.lblMKVToolNixGUIForcedTrackFlag.Location = new System.Drawing.Point(12, 152);
            this.lblMKVToolNixGUIForcedTrackFlag.Name = "lblMKVToolNixGUIForcedTrackFlag";
            this.lblMKVToolNixGUIForcedTrackFlag.Size = new System.Drawing.Size(97, 13);
            this.lblMKVToolNixGUIForcedTrackFlag.TabIndex = 22;
            this.lblMKVToolNixGUIForcedTrackFlag.Text = "Forced Track Flag:";
            // 
            // cbMKVToolNixGUIDefaultTrackFlag
            // 
            this.cbMKVToolNixGUIDefaultTrackFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMKVToolNixGUIDefaultTrackFlag.FormattingEnabled = true;
            this.cbMKVToolNixGUIDefaultTrackFlag.Items.AddRange(new object[] {
            "determine automatically",
            "yes",
            "no"});
            this.cbMKVToolNixGUIDefaultTrackFlag.Location = new System.Drawing.Point(116, 107);
            this.cbMKVToolNixGUIDefaultTrackFlag.Name = "cbMKVToolNixGUIDefaultTrackFlag";
            this.cbMKVToolNixGUIDefaultTrackFlag.Size = new System.Drawing.Size(249, 21);
            this.cbMKVToolNixGUIDefaultTrackFlag.TabIndex = 21;
            this.cbMKVToolNixGUIDefaultTrackFlag.SelectedIndexChanged += new System.EventHandler(this.cbMKVToolNixGUIDefaultTrackFlag_SelectedIndexChanged);
            // 
            // lblMKVToolNixGUIDefaultTrackFlag
            // 
            this.lblMKVToolNixGUIDefaultTrackFlag.AutoSize = true;
            this.lblMKVToolNixGUIDefaultTrackFlag.Location = new System.Drawing.Point(12, 115);
            this.lblMKVToolNixGUIDefaultTrackFlag.Name = "lblMKVToolNixGUIDefaultTrackFlag";
            this.lblMKVToolNixGUIDefaultTrackFlag.Size = new System.Drawing.Size(98, 13);
            this.lblMKVToolNixGUIDefaultTrackFlag.TabIndex = 20;
            this.lblMKVToolNixGUIDefaultTrackFlag.Text = "Default Track Flag:";
            // 
            // txtMKVToolNixGUITrackName
            // 
            this.txtMKVToolNixGUITrackName.Location = new System.Drawing.Point(116, 30);
            this.txtMKVToolNixGUITrackName.Name = "txtMKVToolNixGUITrackName";
            this.txtMKVToolNixGUITrackName.Size = new System.Drawing.Size(298, 20);
            this.txtMKVToolNixGUITrackName.TabIndex = 18;
            this.txtMKVToolNixGUITrackName.TextChanged += new System.EventHandler(this.txtMKVToolNixGUITrackName_TextChanged);
            // 
            // lblMKVToolNixGUITrackName
            // 
            this.lblMKVToolNixGUITrackName.AutoSize = true;
            this.lblMKVToolNixGUITrackName.Location = new System.Drawing.Point(9, 37);
            this.lblMKVToolNixGUITrackName.Name = "lblMKVToolNixGUITrackName";
            this.lblMKVToolNixGUITrackName.Size = new System.Drawing.Size(69, 13);
            this.lblMKVToolNixGUITrackName.TabIndex = 19;
            this.lblMKVToolNixGUITrackName.Text = "Track Name:";
            // 
            // cbMKVToolNixGUILanguage
            // 
            this.cbMKVToolNixGUILanguage.DataSource = this.bsMKVMergeLanguageItem;
            this.cbMKVToolNixGUILanguage.DisplayMember = "Name";
            this.cbMKVToolNixGUILanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMKVToolNixGUILanguage.FormattingEnabled = true;
            this.cbMKVToolNixGUILanguage.Location = new System.Drawing.Point(116, 68);
            this.cbMKVToolNixGUILanguage.Name = "cbMKVToolNixGUILanguage";
            this.cbMKVToolNixGUILanguage.Size = new System.Drawing.Size(298, 21);
            this.cbMKVToolNixGUILanguage.TabIndex = 17;
            this.cbMKVToolNixGUILanguage.ValueMember = "Value";
            this.cbMKVToolNixGUILanguage.SelectedIndexChanged += new System.EventHandler(this.cbMKVToolNixGUILanguage_SelectedIndexChanged);
            // 
            // bsMKVMergeLanguageItem
            // 
            this.bsMKVMergeLanguageItem.AllowNew = false;
            this.bsMKVMergeLanguageItem.DataSource = typeof(BatchGuy.App.MKVMerge.Models.MKVMergeLanguageItem);
            // 
            // lblMKVToolNixGUILanguage
            // 
            this.lblMKVToolNixGUILanguage.AutoSize = true;
            this.lblMKVToolNixGUILanguage.Location = new System.Drawing.Point(12, 76);
            this.lblMKVToolNixGUILanguage.Name = "lblMKVToolNixGUILanguage";
            this.lblMKVToolNixGUILanguage.Size = new System.Drawing.Size(58, 13);
            this.lblMKVToolNixGUILanguage.TabIndex = 16;
            this.lblMKVToolNixGUILanguage.Text = "Language:";
            // 
            // txtEpisodeName
            // 
            this.txtEpisodeName.Location = new System.Drawing.Point(642, 22);
            this.txtEpisodeName.Name = "txtEpisodeName";
            this.txtEpisodeName.Size = new System.Drawing.Size(288, 20);
            this.txtEpisodeName.TabIndex = 2;
            this.txtEpisodeName.TextChanged += new System.EventHandler(this.txtEpisodeName_TextChanged);
            // 
            // lblEpisodeName
            // 
            this.lblEpisodeName.AutoSize = true;
            this.lblEpisodeName.Location = new System.Drawing.Point(557, 25);
            this.lblEpisodeName.Name = "lblEpisodeName";
            this.lblEpisodeName.Size = new System.Drawing.Size(79, 13);
            this.lblEpisodeName.TabIndex = 8;
            this.lblEpisodeName.Text = "Episode Name:";
            // 
            // bgwEac3toLoadTitle
            // 
            this.bgwEac3toLoadTitle.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwEac3toLoadTitle_DoWork);
            this.bgwEac3toLoadTitle.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwEac3toLoadTitle_RunWorkerCompleted);
            // 
            // bsBluRayTitleInfo
            // 
            this.bsBluRayTitleInfo.DataSource = typeof(BatchGuy.App.Parser.Models.BluRayTitleInfo);
            // 
            // ofdFileDialog
            // 
            this.ofdFileDialog.FileName = "openFileDialog1";
            // 
            // BluRayTitleInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 756);
            this.Controls.Add(this.gbScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BluRayTitleInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Blu-ray Title Info";
            this.Load += new System.EventHandler(this.BluRayTitleForm_Load);
            this.gbVideo.ResumeLayout(false);
            this.gbVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleVideo)).EndInit();
            this.gbAudio.ResumeLayout(false);
            this.panelAudioType.ResumeLayout(false);
            this.panelAudioType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleAudio)).EndInit();
            this.gbSubtitles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubtitles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleSubtitles)).EndInit();
            this.gbChapters.ResumeLayout(false);
            this.gbChapters.PerformLayout();
            this.gbScreen.ResumeLayout(false);
            this.gbScreen.PerformLayout();
            this.gbMKVToolNixGUI.ResumeLayout(false);
            this.gbMKVToolNixGUIGeneralOptions.ResumeLayout(false);
            this.gbMKVToolNixGUIGeneralOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMKVMergeLanguageItem)).EndInit();
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
        private System.Windows.Forms.Panel panelAudioType;
        private System.Windows.Forms.TextBox txtAudioTypeArguments;
        private System.Windows.Forms.ComboBox cbAudioType;
        private System.Windows.Forms.Label lblAudioType;
        private System.Windows.Forms.Label lblAudioTypeArguments;
        private System.Windows.Forms.GroupBox gbSubtitles;
        private System.Windows.Forms.DataGridView dgvSubtitles;
        private System.Windows.Forms.GroupBox gbChapters;
        private System.Windows.Forms.CheckBox chkChapters;
        private System.Windows.Forms.Label lblEpisodeNumber;
        private System.Windows.Forms.TextBox txtEpisodeNumber;
        private System.Windows.Forms.GroupBox gbScreen;
        private System.ComponentModel.BackgroundWorker bgwEac3toLoadTitle;
        private System.Windows.Forms.TextBox txtEpisodeName;
        private System.Windows.Forms.Label lblEpisodeName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSelectedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCommentaryDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn audioTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn argumentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsBluRayTitleAudio;
        private System.Windows.Forms.BindingSource bsBluRayTitleSubtitles;
        private System.Windows.Forms.GroupBox gbMKVToolNixGUI;
        private System.Windows.Forms.GroupBox gbMKVToolNixGUIGeneralOptions;
        private System.Windows.Forms.ComboBox cbMKVToolNixGUIForcedTrackFlag;
        private System.Windows.Forms.Label lblMKVToolNixGUIForcedTrackFlag;
        private System.Windows.Forms.ComboBox cbMKVToolNixGUIDefaultTrackFlag;
        private System.Windows.Forms.Label lblMKVToolNixGUIDefaultTrackFlag;
        private System.Windows.Forms.TextBox txtMKVToolNixGUITrackName;
        private System.Windows.Forms.Label lblMKVToolNixGUITrackName;
        private System.Windows.Forms.ComboBox cbMKVToolNixGUILanguage;
        private System.Windows.Forms.Label lblMKVToolNixGUILanguage;
        private System.Windows.Forms.BindingSource bsMKVMergeLanguageItem;
        private System.Windows.Forms.ComboBox cbMKVToolNixGUICompression;
        private System.Windows.Forms.Label lblMKVToolNixGUICompression;
        private System.Windows.Forms.OpenFileDialog ofdFileDialog;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSelectedDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCommentaryDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExternalSubtitlePath;
        private System.Windows.Forms.DataGridViewImageColumn AddSubtitle;
        private System.Windows.Forms.DataGridViewImageColumn RemoveSubtitle;
    }
}
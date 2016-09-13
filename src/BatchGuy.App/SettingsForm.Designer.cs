namespace BatchGuy.App
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.gbScreen = new System.Windows.Forms.GroupBox();
            this.gbRemuxNamingConventionDefaults = new System.Windows.Forms.GroupBox();
            this.lblRemuxNamingConventionExample = new System.Windows.Forms.Label();
            this.lblRemuxNamingConventionExampleCaption = new System.Windows.Forms.Label();
            this.lblRemuxNamingConventionTemplate = new System.Windows.Forms.Label();
            this.cbRemuxNamingConventionDefaults = new System.Windows.Forms.ComboBox();
            this.chkAudioLanguageAlwaysSelectedEnabled = new System.Windows.Forms.CheckBox();
            this.gbAudioMKVMergeDefaultSettings = new System.Windows.Forms.GroupBox();
            this.lblAudioMKVMergeDefaultSettingsAudioType = new System.Windows.Forms.Label();
            this.cbAudioMKVMergeDefaultSettingsAudioType = new System.Windows.Forms.ComboBox();
            this.cbAudioMKVMergeDefaultSettingsDefaultTrackFlag = new System.Windows.Forms.ComboBox();
            this.lblAudioMKVMergeDefaultSettingsDefaultTrackFlag = new System.Windows.Forms.Label();
            this.cbAudioMKVMergeDefaultSettingsLanguage = new System.Windows.Forms.ComboBox();
            this.bsAudioMKVMergeDefaultSettingsLanguage = new System.Windows.Forms.BindingSource(this.components);
            this.lblAudioMKVMergeDefaultSettingsLanguage = new System.Windows.Forms.Label();
            this.chkSubtitleLanguageAlwaysSelectedEnabled = new System.Windows.Forms.CheckBox();
            this.gbSubtitlesMKVMergeDefaultSettings = new System.Windows.Forms.GroupBox();
            this.cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag = new System.Windows.Forms.ComboBox();
            this.lblSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag = new System.Windows.Forms.Label();
            this.cbSubtitlesMKVMergeDefaultSettingsLanguage = new System.Windows.Forms.ComboBox();
            this.bsSubtitlesMKVMergeDefaultSettingsLanguage = new System.Windows.Forms.BindingSource(this.components);
            this.lblSubtitlesMKVMergeDefaultSettingsLanguage = new System.Windows.Forms.Label();
            this.gbEAC3ToDefaultSettings = new System.Windows.Forms.GroupBox();
            this.chkShowProgressNumbers = new System.Windows.Forms.CheckBox();
            this.gbBluRayTitleInfoDefaultSettings = new System.Windows.Forms.GroupBox();
            this.chkBluRayTitleInfoDefaultSettingsSelectChapters = new System.Windows.Forms.CheckBox();
            this.chkBluRayTitleInfoDefaultSettingsSelectSubtitles = new System.Windows.Forms.CheckBox();
            this.dgvBluRayTitleInfoDefaultSettingsAudio = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defaultTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.argumentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBluRayTitleInfoDefaultSettingsAudio = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenMKVMergeFileDialog = new System.Windows.Forms.Button();
            this.txtMKVMerge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenVfw4x264FileDialog = new System.Windows.Forms.Button();
            this.txtVfw4x264 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenEac3toFileDialog = new System.Windows.Forms.Button();
            this.txtEac3toPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.ofdFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbScreen.SuspendLayout();
            this.gbRemuxNamingConventionDefaults.SuspendLayout();
            this.gbAudioMKVMergeDefaultSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAudioMKVMergeDefaultSettingsLanguage)).BeginInit();
            this.gbSubtitlesMKVMergeDefaultSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSubtitlesMKVMergeDefaultSettingsLanguage)).BeginInit();
            this.gbEAC3ToDefaultSettings.SuspendLayout();
            this.gbBluRayTitleInfoDefaultSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBluRayTitleInfoDefaultSettingsAudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleInfoDefaultSettingsAudio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbScreen
            // 
            this.gbScreen.Controls.Add(this.gbRemuxNamingConventionDefaults);
            this.gbScreen.Controls.Add(this.chkAudioLanguageAlwaysSelectedEnabled);
            this.gbScreen.Controls.Add(this.gbAudioMKVMergeDefaultSettings);
            this.gbScreen.Controls.Add(this.chkSubtitleLanguageAlwaysSelectedEnabled);
            this.gbScreen.Controls.Add(this.gbSubtitlesMKVMergeDefaultSettings);
            this.gbScreen.Controls.Add(this.gbEAC3ToDefaultSettings);
            this.gbScreen.Controls.Add(this.gbBluRayTitleInfoDefaultSettings);
            this.gbScreen.Controls.Add(this.groupBox1);
            this.gbScreen.Location = new System.Drawing.Point(12, 12);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Size = new System.Drawing.Size(800, 728);
            this.gbScreen.TabIndex = 0;
            this.gbScreen.TabStop = false;
            this.gbScreen.Text = "Settings";
            // 
            // gbRemuxNamingConventionDefaults
            // 
            this.gbRemuxNamingConventionDefaults.Controls.Add(this.lblRemuxNamingConventionExample);
            this.gbRemuxNamingConventionDefaults.Controls.Add(this.lblRemuxNamingConventionExampleCaption);
            this.gbRemuxNamingConventionDefaults.Controls.Add(this.lblRemuxNamingConventionTemplate);
            this.gbRemuxNamingConventionDefaults.Controls.Add(this.cbRemuxNamingConventionDefaults);
            this.gbRemuxNamingConventionDefaults.Location = new System.Drawing.Point(344, 203);
            this.gbRemuxNamingConventionDefaults.Name = "gbRemuxNamingConventionDefaults";
            this.gbRemuxNamingConventionDefaults.Size = new System.Drawing.Size(438, 85);
            this.gbRemuxNamingConventionDefaults.TabIndex = 12;
            this.gbRemuxNamingConventionDefaults.TabStop = false;
            this.gbRemuxNamingConventionDefaults.Text = "Remux Naming Convention Defaults";
            // 
            // lblRemuxNamingConventionExample
            // 
            this.lblRemuxNamingConventionExample.AutoSize = true;
            this.lblRemuxNamingConventionExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemuxNamingConventionExample.Location = new System.Drawing.Point(75, 59);
            this.lblRemuxNamingConventionExample.Name = "lblRemuxNamingConventionExample";
            this.lblRemuxNamingConventionExample.Size = new System.Drawing.Size(80, 13);
            this.lblRemuxNamingConventionExample.TabIndex = 30;
            this.lblRemuxNamingConventionExample.Text = "Show Example:";
            // 
            // lblRemuxNamingConventionExampleCaption
            // 
            this.lblRemuxNamingConventionExampleCaption.AutoSize = true;
            this.lblRemuxNamingConventionExampleCaption.Location = new System.Drawing.Point(14, 59);
            this.lblRemuxNamingConventionExampleCaption.Name = "lblRemuxNamingConventionExampleCaption";
            this.lblRemuxNamingConventionExampleCaption.Size = new System.Drawing.Size(50, 13);
            this.lblRemuxNamingConventionExampleCaption.TabIndex = 29;
            this.lblRemuxNamingConventionExampleCaption.Text = "Example:";
            // 
            // lblRemuxNamingConventionTemplate
            // 
            this.lblRemuxNamingConventionTemplate.AutoSize = true;
            this.lblRemuxNamingConventionTemplate.Location = new System.Drawing.Point(12, 25);
            this.lblRemuxNamingConventionTemplate.Name = "lblRemuxNamingConventionTemplate";
            this.lblRemuxNamingConventionTemplate.Size = new System.Drawing.Size(54, 13);
            this.lblRemuxNamingConventionTemplate.TabIndex = 28;
            this.lblRemuxNamingConventionTemplate.Text = "Template:";
            // 
            // cbRemuxNamingConventionDefaults
            // 
            this.cbRemuxNamingConventionDefaults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRemuxNamingConventionDefaults.FormattingEnabled = true;
            this.cbRemuxNamingConventionDefaults.Items.AddRange(new object[] {
            "Template 1",
            "Template 2",
            "Template 3"});
            this.cbRemuxNamingConventionDefaults.Location = new System.Drawing.Point(78, 19);
            this.cbRemuxNamingConventionDefaults.Name = "cbRemuxNamingConventionDefaults";
            this.cbRemuxNamingConventionDefaults.Size = new System.Drawing.Size(186, 21);
            this.cbRemuxNamingConventionDefaults.TabIndex = 4;
            this.cbRemuxNamingConventionDefaults.SelectedIndexChanged += new System.EventHandler(this.cbRemuxNamingConventionDefaults_SelectedIndexChanged);
            // 
            // chkAudioLanguageAlwaysSelectedEnabled
            // 
            this.chkAudioLanguageAlwaysSelectedEnabled.AutoSize = true;
            this.chkAudioLanguageAlwaysSelectedEnabled.Location = new System.Drawing.Point(20, 496);
            this.chkAudioLanguageAlwaysSelectedEnabled.Name = "chkAudioLanguageAlwaysSelectedEnabled";
            this.chkAudioLanguageAlwaysSelectedEnabled.Size = new System.Drawing.Size(15, 14);
            this.chkAudioLanguageAlwaysSelectedEnabled.TabIndex = 8;
            this.chkAudioLanguageAlwaysSelectedEnabled.UseVisualStyleBackColor = true;
            this.chkAudioLanguageAlwaysSelectedEnabled.CheckedChanged += new System.EventHandler(this.chkAudioLanguageAlwaysSelectedEnabled_CheckedChanged);
            // 
            // gbAudioMKVMergeDefaultSettings
            // 
            this.gbAudioMKVMergeDefaultSettings.Controls.Add(this.lblAudioMKVMergeDefaultSettingsAudioType);
            this.gbAudioMKVMergeDefaultSettings.Controls.Add(this.cbAudioMKVMergeDefaultSettingsAudioType);
            this.gbAudioMKVMergeDefaultSettings.Controls.Add(this.cbAudioMKVMergeDefaultSettingsDefaultTrackFlag);
            this.gbAudioMKVMergeDefaultSettings.Controls.Add(this.lblAudioMKVMergeDefaultSettingsDefaultTrackFlag);
            this.gbAudioMKVMergeDefaultSettings.Controls.Add(this.cbAudioMKVMergeDefaultSettingsLanguage);
            this.gbAudioMKVMergeDefaultSettings.Controls.Add(this.lblAudioMKVMergeDefaultSettingsLanguage);
            this.gbAudioMKVMergeDefaultSettings.Location = new System.Drawing.Point(20, 512);
            this.gbAudioMKVMergeDefaultSettings.Name = "gbAudioMKVMergeDefaultSettings";
            this.gbAudioMKVMergeDefaultSettings.Size = new System.Drawing.Size(760, 82);
            this.gbAudioMKVMergeDefaultSettings.TabIndex = 10;
            this.gbAudioMKVMergeDefaultSettings.TabStop = false;
            this.gbAudioMKVMergeDefaultSettings.Text = "Audio Language Always Selected:";
            // 
            // lblAudioMKVMergeDefaultSettingsAudioType
            // 
            this.lblAudioMKVMergeDefaultSettingsAudioType.AutoSize = true;
            this.lblAudioMKVMergeDefaultSettingsAudioType.Location = new System.Drawing.Point(327, 29);
            this.lblAudioMKVMergeDefaultSettingsAudioType.Name = "lblAudioMKVMergeDefaultSettingsAudioType";
            this.lblAudioMKVMergeDefaultSettingsAudioType.Size = new System.Drawing.Size(97, 13);
            this.lblAudioMKVMergeDefaultSettingsAudioType.TabIndex = 26;
            this.lblAudioMKVMergeDefaultSettingsAudioType.Text = "And Audio Type Is:";
            // 
            // cbAudioMKVMergeDefaultSettingsAudioType
            // 
            this.cbAudioMKVMergeDefaultSettingsAudioType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAudioMKVMergeDefaultSettingsAudioType.FormattingEnabled = true;
            this.cbAudioMKVMergeDefaultSettingsAudioType.ItemHeight = 13;
            this.cbAudioMKVMergeDefaultSettingsAudioType.Items.AddRange(new object[] {
            "Any Type",
            "AC3",
            "DTS",
            "DTSMA",
            "FLAC",
            "LPCM",
            "MPA",
            "TrueHD"});
            this.cbAudioMKVMergeDefaultSettingsAudioType.Location = new System.Drawing.Point(330, 45);
            this.cbAudioMKVMergeDefaultSettingsAudioType.Name = "cbAudioMKVMergeDefaultSettingsAudioType";
            this.cbAudioMKVMergeDefaultSettingsAudioType.Size = new System.Drawing.Size(186, 21);
            this.cbAudioMKVMergeDefaultSettingsAudioType.TabIndex = 9;
            this.cbAudioMKVMergeDefaultSettingsAudioType.SelectedIndexChanged += new System.EventHandler(this.cbAudioMKVMergeDefaultSettingsAudioType_SelectedIndexChanged);
            // 
            // cbAudioMKVMergeDefaultSettingsDefaultTrackFlag
            // 
            this.cbAudioMKVMergeDefaultSettingsDefaultTrackFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAudioMKVMergeDefaultSettingsDefaultTrackFlag.FormattingEnabled = true;
            this.cbAudioMKVMergeDefaultSettingsDefaultTrackFlag.ItemHeight = 13;
            this.cbAudioMKVMergeDefaultSettingsDefaultTrackFlag.Items.AddRange(new object[] {
            "determine automatically",
            "yes",
            "no"});
            this.cbAudioMKVMergeDefaultSettingsDefaultTrackFlag.Location = new System.Drawing.Point(541, 45);
            this.cbAudioMKVMergeDefaultSettingsDefaultTrackFlag.Name = "cbAudioMKVMergeDefaultSettingsDefaultTrackFlag";
            this.cbAudioMKVMergeDefaultSettingsDefaultTrackFlag.Size = new System.Drawing.Size(169, 21);
            this.cbAudioMKVMergeDefaultSettingsDefaultTrackFlag.TabIndex = 10;
            this.cbAudioMKVMergeDefaultSettingsDefaultTrackFlag.SelectedIndexChanged += new System.EventHandler(this.cbAudioMKVMergeDefaultSettingsDefaultTrackFlag_SelectedIndexChanged);
            // 
            // lblAudioMKVMergeDefaultSettingsDefaultTrackFlag
            // 
            this.lblAudioMKVMergeDefaultSettingsDefaultTrackFlag.AutoSize = true;
            this.lblAudioMKVMergeDefaultSettingsDefaultTrackFlag.Location = new System.Drawing.Point(538, 29);
            this.lblAudioMKVMergeDefaultSettingsDefaultTrackFlag.Name = "lblAudioMKVMergeDefaultSettingsDefaultTrackFlag";
            this.lblAudioMKVMergeDefaultSettingsDefaultTrackFlag.Size = new System.Drawing.Size(98, 13);
            this.lblAudioMKVMergeDefaultSettingsDefaultTrackFlag.TabIndex = 22;
            this.lblAudioMKVMergeDefaultSettingsDefaultTrackFlag.Text = "Default Track Flag:";
            // 
            // cbAudioMKVMergeDefaultSettingsLanguage
            // 
            this.cbAudioMKVMergeDefaultSettingsLanguage.DataSource = this.bsAudioMKVMergeDefaultSettingsLanguage;
            this.cbAudioMKVMergeDefaultSettingsLanguage.DisplayMember = "Name";
            this.cbAudioMKVMergeDefaultSettingsLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAudioMKVMergeDefaultSettingsLanguage.FormattingEnabled = true;
            this.cbAudioMKVMergeDefaultSettingsLanguage.Location = new System.Drawing.Point(8, 45);
            this.cbAudioMKVMergeDefaultSettingsLanguage.Name = "cbAudioMKVMergeDefaultSettingsLanguage";
            this.cbAudioMKVMergeDefaultSettingsLanguage.Size = new System.Drawing.Size(298, 21);
            this.cbAudioMKVMergeDefaultSettingsLanguage.TabIndex = 9;
            this.cbAudioMKVMergeDefaultSettingsLanguage.ValueMember = "Value";
            this.cbAudioMKVMergeDefaultSettingsLanguage.SelectedIndexChanged += new System.EventHandler(this.cbAudioMKVMergeDefaultSettingsLanguage_SelectedIndexChanged);
            // 
            // bsAudioMKVMergeDefaultSettingsLanguage
            // 
            this.bsAudioMKVMergeDefaultSettingsLanguage.AllowNew = false;
            this.bsAudioMKVMergeDefaultSettingsLanguage.DataSource = typeof(BatchGuy.App.MKVMerge.Models.MKVMergeLanguageItem);
            // 
            // lblAudioMKVMergeDefaultSettingsLanguage
            // 
            this.lblAudioMKVMergeDefaultSettingsLanguage.AutoSize = true;
            this.lblAudioMKVMergeDefaultSettingsLanguage.Location = new System.Drawing.Point(6, 29);
            this.lblAudioMKVMergeDefaultSettingsLanguage.Name = "lblAudioMKVMergeDefaultSettingsLanguage";
            this.lblAudioMKVMergeDefaultSettingsLanguage.Size = new System.Drawing.Size(101, 13);
            this.lblAudioMKVMergeDefaultSettingsLanguage.TabIndex = 18;
            this.lblAudioMKVMergeDefaultSettingsLanguage.Text = "When Language Is:";
            // 
            // chkSubtitleLanguageAlwaysSelectedEnabled
            // 
            this.chkSubtitleLanguageAlwaysSelectedEnabled.AutoSize = true;
            this.chkSubtitleLanguageAlwaysSelectedEnabled.Location = new System.Drawing.Point(20, 600);
            this.chkSubtitleLanguageAlwaysSelectedEnabled.Name = "chkSubtitleLanguageAlwaysSelectedEnabled";
            this.chkSubtitleLanguageAlwaysSelectedEnabled.Size = new System.Drawing.Size(15, 14);
            this.chkSubtitleLanguageAlwaysSelectedEnabled.TabIndex = 12;
            this.chkSubtitleLanguageAlwaysSelectedEnabled.UseVisualStyleBackColor = true;
            this.chkSubtitleLanguageAlwaysSelectedEnabled.CheckedChanged += new System.EventHandler(this.chkSubtitleLanguageAlwaysSelectedEnabled_CheckedChanged);
            // 
            // gbSubtitlesMKVMergeDefaultSettings
            // 
            this.gbSubtitlesMKVMergeDefaultSettings.Controls.Add(this.cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag);
            this.gbSubtitlesMKVMergeDefaultSettings.Controls.Add(this.lblSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag);
            this.gbSubtitlesMKVMergeDefaultSettings.Controls.Add(this.cbSubtitlesMKVMergeDefaultSettingsLanguage);
            this.gbSubtitlesMKVMergeDefaultSettings.Controls.Add(this.lblSubtitlesMKVMergeDefaultSettingsLanguage);
            this.gbSubtitlesMKVMergeDefaultSettings.Location = new System.Drawing.Point(20, 616);
            this.gbSubtitlesMKVMergeDefaultSettings.Name = "gbSubtitlesMKVMergeDefaultSettings";
            this.gbSubtitlesMKVMergeDefaultSettings.Size = new System.Drawing.Size(760, 90);
            this.gbSubtitlesMKVMergeDefaultSettings.TabIndex = 3;
            this.gbSubtitlesMKVMergeDefaultSettings.TabStop = false;
            this.gbSubtitlesMKVMergeDefaultSettings.Text = "Subtitle Language Always Selected:";
            // 
            // cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag
            // 
            this.cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag.FormattingEnabled = true;
            this.cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag.Items.AddRange(new object[] {
            "determine automatically",
            "yes",
            "no"});
            this.cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag.Location = new System.Drawing.Point(330, 45);
            this.cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag.Name = "cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag";
            this.cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag.Size = new System.Drawing.Size(169, 21);
            this.cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag.TabIndex = 14;
            this.cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag.SelectedIndexChanged += new System.EventHandler(this.cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag_SelectedIndexChanged);
            // 
            // lblSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag
            // 
            this.lblSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag.AutoSize = true;
            this.lblSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag.Location = new System.Drawing.Point(327, 29);
            this.lblSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag.Name = "lblSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag";
            this.lblSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag.Size = new System.Drawing.Size(98, 13);
            this.lblSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag.TabIndex = 22;
            this.lblSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag.Text = "Default Track Flag:";
            // 
            // cbSubtitlesMKVMergeDefaultSettingsLanguage
            // 
            this.cbSubtitlesMKVMergeDefaultSettingsLanguage.DataSource = this.bsSubtitlesMKVMergeDefaultSettingsLanguage;
            this.cbSubtitlesMKVMergeDefaultSettingsLanguage.DisplayMember = "Name";
            this.cbSubtitlesMKVMergeDefaultSettingsLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubtitlesMKVMergeDefaultSettingsLanguage.FormattingEnabled = true;
            this.cbSubtitlesMKVMergeDefaultSettingsLanguage.Location = new System.Drawing.Point(8, 45);
            this.cbSubtitlesMKVMergeDefaultSettingsLanguage.Name = "cbSubtitlesMKVMergeDefaultSettingsLanguage";
            this.cbSubtitlesMKVMergeDefaultSettingsLanguage.Size = new System.Drawing.Size(298, 21);
            this.cbSubtitlesMKVMergeDefaultSettingsLanguage.TabIndex = 13;
            this.cbSubtitlesMKVMergeDefaultSettingsLanguage.ValueMember = "Value";
            this.cbSubtitlesMKVMergeDefaultSettingsLanguage.SelectedIndexChanged += new System.EventHandler(this.cbSubtitlesMKVMergeDefaultSettingsLanguage_SelectedIndexChanged);
            // 
            // bsSubtitlesMKVMergeDefaultSettingsLanguage
            // 
            this.bsSubtitlesMKVMergeDefaultSettingsLanguage.AllowNew = false;
            this.bsSubtitlesMKVMergeDefaultSettingsLanguage.DataSource = typeof(BatchGuy.App.MKVMerge.Models.MKVMergeLanguageItem);
            // 
            // lblSubtitlesMKVMergeDefaultSettingsLanguage
            // 
            this.lblSubtitlesMKVMergeDefaultSettingsLanguage.AutoSize = true;
            this.lblSubtitlesMKVMergeDefaultSettingsLanguage.Location = new System.Drawing.Point(8, 29);
            this.lblSubtitlesMKVMergeDefaultSettingsLanguage.Name = "lblSubtitlesMKVMergeDefaultSettingsLanguage";
            this.lblSubtitlesMKVMergeDefaultSettingsLanguage.Size = new System.Drawing.Size(101, 13);
            this.lblSubtitlesMKVMergeDefaultSettingsLanguage.TabIndex = 18;
            this.lblSubtitlesMKVMergeDefaultSettingsLanguage.Text = "When Language Is:";
            // 
            // gbEAC3ToDefaultSettings
            // 
            this.gbEAC3ToDefaultSettings.Controls.Add(this.chkShowProgressNumbers);
            this.gbEAC3ToDefaultSettings.Location = new System.Drawing.Point(20, 203);
            this.gbEAC3ToDefaultSettings.Name = "gbEAC3ToDefaultSettings";
            this.gbEAC3ToDefaultSettings.Size = new System.Drawing.Size(318, 85);
            this.gbEAC3ToDefaultSettings.TabIndex = 2;
            this.gbEAC3ToDefaultSettings.TabStop = false;
            this.gbEAC3ToDefaultSettings.Text = "eac3to.exe Defaults";
            // 
            // chkShowProgressNumbers
            // 
            this.chkShowProgressNumbers.AutoSize = true;
            this.chkShowProgressNumbers.Location = new System.Drawing.Point(8, 28);
            this.chkShowProgressNumbers.Name = "chkShowProgressNumbers";
            this.chkShowProgressNumbers.Size = new System.Drawing.Size(142, 17);
            this.chkShowProgressNumbers.TabIndex = 3;
            this.chkShowProgressNumbers.Text = "Show Progress Numbers";
            this.chkShowProgressNumbers.UseVisualStyleBackColor = true;
            this.chkShowProgressNumbers.CheckedChanged += new System.EventHandler(this.chkShowProgressNumbers_CheckedChanged);
            // 
            // gbBluRayTitleInfoDefaultSettings
            // 
            this.gbBluRayTitleInfoDefaultSettings.Controls.Add(this.chkBluRayTitleInfoDefaultSettingsSelectChapters);
            this.gbBluRayTitleInfoDefaultSettings.Controls.Add(this.chkBluRayTitleInfoDefaultSettingsSelectSubtitles);
            this.gbBluRayTitleInfoDefaultSettings.Controls.Add(this.dgvBluRayTitleInfoDefaultSettingsAudio);
            this.gbBluRayTitleInfoDefaultSettings.Location = new System.Drawing.Point(20, 294);
            this.gbBluRayTitleInfoDefaultSettings.Name = "gbBluRayTitleInfoDefaultSettings";
            this.gbBluRayTitleInfoDefaultSettings.Size = new System.Drawing.Size(762, 196);
            this.gbBluRayTitleInfoDefaultSettings.TabIndex = 1;
            this.gbBluRayTitleInfoDefaultSettings.TabStop = false;
            this.gbBluRayTitleInfoDefaultSettings.Text = "BluRay Title Info Defaults";
            // 
            // chkBluRayTitleInfoDefaultSettingsSelectChapters
            // 
            this.chkBluRayTitleInfoDefaultSettingsSelectChapters.AutoSize = true;
            this.chkBluRayTitleInfoDefaultSettingsSelectChapters.Location = new System.Drawing.Point(171, 32);
            this.chkBluRayTitleInfoDefaultSettingsSelectChapters.Name = "chkBluRayTitleInfoDefaultSettingsSelectChapters";
            this.chkBluRayTitleInfoDefaultSettingsSelectChapters.Size = new System.Drawing.Size(101, 17);
            this.chkBluRayTitleInfoDefaultSettingsSelectChapters.TabIndex = 6;
            this.chkBluRayTitleInfoDefaultSettingsSelectChapters.Text = "Select Chapters";
            this.chkBluRayTitleInfoDefaultSettingsSelectChapters.UseVisualStyleBackColor = true;
            this.chkBluRayTitleInfoDefaultSettingsSelectChapters.CheckedChanged += new System.EventHandler(this.chkBluRayTitleInfoDefaultSettingsSelectChapters_CheckedChanged);
            // 
            // chkBluRayTitleInfoDefaultSettingsSelectSubtitles
            // 
            this.chkBluRayTitleInfoDefaultSettingsSelectSubtitles.AutoSize = true;
            this.chkBluRayTitleInfoDefaultSettingsSelectSubtitles.Location = new System.Drawing.Point(11, 32);
            this.chkBluRayTitleInfoDefaultSettingsSelectSubtitles.Name = "chkBluRayTitleInfoDefaultSettingsSelectSubtitles";
            this.chkBluRayTitleInfoDefaultSettingsSelectSubtitles.Size = new System.Drawing.Size(113, 17);
            this.chkBluRayTitleInfoDefaultSettingsSelectSubtitles.TabIndex = 5;
            this.chkBluRayTitleInfoDefaultSettingsSelectSubtitles.Text = "Select All Subtitles";
            this.chkBluRayTitleInfoDefaultSettingsSelectSubtitles.UseVisualStyleBackColor = true;
            this.chkBluRayTitleInfoDefaultSettingsSelectSubtitles.CheckedChanged += new System.EventHandler(this.chkBluRayTitleInfoDefaultSettingsSelectSubtitles_CheckedChanged);
            // 
            // dgvBluRayTitleInfoDefaultSettingsAudio
            // 
            this.dgvBluRayTitleInfoDefaultSettingsAudio.AutoGenerateColumns = false;
            this.dgvBluRayTitleInfoDefaultSettingsAudio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBluRayTitleInfoDefaultSettingsAudio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.defaultTypeDataGridViewTextBoxColumn,
            this.argumentsDataGridViewTextBoxColumn});
            this.dgvBluRayTitleInfoDefaultSettingsAudio.DataSource = this.bsBluRayTitleInfoDefaultSettingsAudio;
            this.dgvBluRayTitleInfoDefaultSettingsAudio.Location = new System.Drawing.Point(6, 58);
            this.dgvBluRayTitleInfoDefaultSettingsAudio.Name = "dgvBluRayTitleInfoDefaultSettingsAudio";
            this.dgvBluRayTitleInfoDefaultSettingsAudio.Size = new System.Drawing.Size(750, 131);
            this.dgvBluRayTitleInfoDefaultSettingsAudio.TabIndex = 7;
            this.dgvBluRayTitleInfoDefaultSettingsAudio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBluRayTitleInfoDefaultSettingsAudio_CellClick);
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Audio Input";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // defaultTypeDataGridViewTextBoxColumn
            // 
            this.defaultTypeDataGridViewTextBoxColumn.DataPropertyName = "DefaultType";
            this.defaultTypeDataGridViewTextBoxColumn.HeaderText = "Audio Output";
            this.defaultTypeDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "AC3",
            "DTS",
            "DTSMA",
            "FLAC",
            "MPA",
            "TrueHD",
            "LPCM"});
            this.defaultTypeDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.defaultTypeDataGridViewTextBoxColumn.Name = "defaultTypeDataGridViewTextBoxColumn";
            this.defaultTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.defaultTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.defaultTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // argumentsDataGridViewTextBoxColumn
            // 
            this.argumentsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.argumentsDataGridViewTextBoxColumn.DataPropertyName = "Arguments";
            this.argumentsDataGridViewTextBoxColumn.HeaderText = "Arguments";
            this.argumentsDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.argumentsDataGridViewTextBoxColumn.Name = "argumentsDataGridViewTextBoxColumn";
            // 
            // bsBluRayTitleInfoDefaultSettingsAudio
            // 
            this.bsBluRayTitleInfoDefaultSettingsAudio.AllowNew = false;
            this.bsBluRayTitleInfoDefaultSettingsAudio.DataSource = typeof(BatchGuy.App.Settings.Models.BluRayTitleInfoDefaultSettingsAudio);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenMKVMergeFileDialog);
            this.groupBox1.Controls.Add(this.txtMKVMerge);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnOpenVfw4x264FileDialog);
            this.groupBox1.Controls.Add(this.txtVfw4x264);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnOpenEac3toFileDialog);
            this.groupBox1.Controls.Add(this.txtEac3toPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Executables";
            // 
            // btnOpenMKVMergeFileDialog
            // 
            this.btnOpenMKVMergeFileDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenMKVMergeFileDialog.Location = new System.Drawing.Point(683, 94);
            this.btnOpenMKVMergeFileDialog.Name = "btnOpenMKVMergeFileDialog";
            this.btnOpenMKVMergeFileDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenMKVMergeFileDialog.TabIndex = 2;
            this.btnOpenMKVMergeFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenMKVMergeFileDialog.Click += new System.EventHandler(this.btnOpenMKVMergeFileDialog_Click);
            // 
            // txtMKVMerge
            // 
            this.txtMKVMerge.Location = new System.Drawing.Point(98, 107);
            this.txtMKVMerge.Name = "txtMKVMerge";
            this.txtMKVMerge.ReadOnly = true;
            this.txtMKVMerge.Size = new System.Drawing.Size(564, 20);
            this.txtMKVMerge.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "mkvmerge.exe";
            // 
            // btnOpenVfw4x264FileDialog
            // 
            this.btnOpenVfw4x264FileDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenVfw4x264FileDialog.Location = new System.Drawing.Point(683, 50);
            this.btnOpenVfw4x264FileDialog.Name = "btnOpenVfw4x264FileDialog";
            this.btnOpenVfw4x264FileDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenVfw4x264FileDialog.TabIndex = 1;
            this.btnOpenVfw4x264FileDialog.UseVisualStyleBackColor = true;
            this.btnOpenVfw4x264FileDialog.Click += new System.EventHandler(this.btnOpenVfw4x264FileDialog_Click);
            // 
            // txtVfw4x264
            // 
            this.txtVfw4x264.Location = new System.Drawing.Point(98, 63);
            this.txtVfw4x264.Name = "txtVfw4x264";
            this.txtVfw4x264.ReadOnly = true;
            this.txtVfw4x264.Size = new System.Drawing.Size(564, 20);
            this.txtVfw4x264.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "vfw4x264.exe";
            // 
            // btnOpenEac3toFileDialog
            // 
            this.btnOpenEac3toFileDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenEac3toFileDialog.Location = new System.Drawing.Point(683, 10);
            this.btnOpenEac3toFileDialog.Name = "btnOpenEac3toFileDialog";
            this.btnOpenEac3toFileDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenEac3toFileDialog.TabIndex = 0;
            this.btnOpenEac3toFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenEac3toFileDialog.Click += new System.EventHandler(this.btnOpenEac3toFileDialog_Click);
            // 
            // txtEac3toPath
            // 
            this.txtEac3toPath.Location = new System.Drawing.Point(98, 23);
            this.txtEac3toPath.Name = "txtEac3toPath";
            this.txtEac3toPath.ReadOnly = true;
            this.txtEac3toPath.Size = new System.Drawing.Size(564, 20);
            this.txtEac3toPath.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "eac3to.exe";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(705, 746);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 25);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ofdFileDialog
            // 
            this.ofdFileDialog.FileName = "openFileDialog1";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 781);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BatchGuy Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.gbScreen.ResumeLayout(false);
            this.gbScreen.PerformLayout();
            this.gbRemuxNamingConventionDefaults.ResumeLayout(false);
            this.gbRemuxNamingConventionDefaults.PerformLayout();
            this.gbAudioMKVMergeDefaultSettings.ResumeLayout(false);
            this.gbAudioMKVMergeDefaultSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAudioMKVMergeDefaultSettingsLanguage)).EndInit();
            this.gbSubtitlesMKVMergeDefaultSettings.ResumeLayout(false);
            this.gbSubtitlesMKVMergeDefaultSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSubtitlesMKVMergeDefaultSettingsLanguage)).EndInit();
            this.gbEAC3ToDefaultSettings.ResumeLayout(false);
            this.gbEAC3ToDefaultSettings.PerformLayout();
            this.gbBluRayTitleInfoDefaultSettings.ResumeLayout(false);
            this.gbBluRayTitleInfoDefaultSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBluRayTitleInfoDefaultSettingsAudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleInfoDefaultSettingsAudio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbScreen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEac3toPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenEac3toFileDialog;
        private System.Windows.Forms.OpenFileDialog ofdFileDialog;
        private System.Windows.Forms.Button btnOpenVfw4x264FileDialog;
        private System.Windows.Forms.TextBox txtVfw4x264;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenMKVMergeFileDialog;
        private System.Windows.Forms.TextBox txtMKVMerge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbBluRayTitleInfoDefaultSettings;
        private System.Windows.Forms.DataGridView dgvBluRayTitleInfoDefaultSettingsAudio;
        private System.Windows.Forms.BindingSource bsBluRayTitleInfoDefaultSettingsAudio;
        private System.Windows.Forms.CheckBox chkBluRayTitleInfoDefaultSettingsSelectChapters;
        private System.Windows.Forms.CheckBox chkBluRayTitleInfoDefaultSettingsSelectSubtitles;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn defaultTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn argumentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbEAC3ToDefaultSettings;
        private System.Windows.Forms.CheckBox chkShowProgressNumbers;
        private System.Windows.Forms.GroupBox gbSubtitlesMKVMergeDefaultSettings;
        private System.Windows.Forms.CheckBox chkSubtitleLanguageAlwaysSelectedEnabled;
        private System.Windows.Forms.ComboBox cbSubtitlesMKVMergeDefaultSettingsLanguage;
        private System.Windows.Forms.Label lblSubtitlesMKVMergeDefaultSettingsLanguage;
        private System.Windows.Forms.ComboBox cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag;
        private System.Windows.Forms.Label lblSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag;
        private System.Windows.Forms.BindingSource bsSubtitlesMKVMergeDefaultSettingsLanguage;
        private System.Windows.Forms.CheckBox chkAudioLanguageAlwaysSelectedEnabled;
        private System.Windows.Forms.GroupBox gbAudioMKVMergeDefaultSettings;
        private System.Windows.Forms.ComboBox cbAudioMKVMergeDefaultSettingsDefaultTrackFlag;
        private System.Windows.Forms.Label lblAudioMKVMergeDefaultSettingsDefaultTrackFlag;
        private System.Windows.Forms.ComboBox cbAudioMKVMergeDefaultSettingsLanguage;
        private System.Windows.Forms.Label lblAudioMKVMergeDefaultSettingsLanguage;
        private System.Windows.Forms.BindingSource bsAudioMKVMergeDefaultSettingsLanguage;
        private System.Windows.Forms.Label lblAudioMKVMergeDefaultSettingsAudioType;
        private System.Windows.Forms.ComboBox cbAudioMKVMergeDefaultSettingsAudioType;
        private System.Windows.Forms.GroupBox gbRemuxNamingConventionDefaults;
        private System.Windows.Forms.Label lblRemuxNamingConventionExampleCaption;
        private System.Windows.Forms.Label lblRemuxNamingConventionTemplate;
        private System.Windows.Forms.ComboBox cbRemuxNamingConventionDefaults;
        private System.Windows.Forms.Label lblRemuxNamingConventionExample;
    }
}
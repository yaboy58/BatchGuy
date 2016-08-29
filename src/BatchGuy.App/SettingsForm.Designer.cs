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
            this.gbBluRayTitleInfoDefaultSettings = new System.Windows.Forms.GroupBox();
            this.chkBluRayTitleInfoDefaultSettingsSelectChapters = new System.Windows.Forms.CheckBox();
            this.chkBluRayTitleInfoDefaultSettingsSelectSubtitles = new System.Windows.Forms.CheckBox();
            this.dgvBluRayTitleInfoDefaultSettingsAudio = new System.Windows.Forms.DataGridView();
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
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defaultTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.argumentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbScreen.SuspendLayout();
            this.gbBluRayTitleInfoDefaultSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBluRayTitleInfoDefaultSettingsAudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleInfoDefaultSettingsAudio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbScreen
            // 
            this.gbScreen.Controls.Add(this.gbBluRayTitleInfoDefaultSettings);
            this.gbScreen.Controls.Add(this.groupBox1);
            this.gbScreen.Location = new System.Drawing.Point(12, 12);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Size = new System.Drawing.Size(800, 503);
            this.gbScreen.TabIndex = 0;
            this.gbScreen.TabStop = false;
            this.gbScreen.Text = "Settings";
            // 
            // gbBluRayTitleInfoDefaultSettings
            // 
            this.gbBluRayTitleInfoDefaultSettings.Controls.Add(this.chkBluRayTitleInfoDefaultSettingsSelectChapters);
            this.gbBluRayTitleInfoDefaultSettings.Controls.Add(this.chkBluRayTitleInfoDefaultSettingsSelectSubtitles);
            this.gbBluRayTitleInfoDefaultSettings.Controls.Add(this.dgvBluRayTitleInfoDefaultSettingsAudio);
            this.gbBluRayTitleInfoDefaultSettings.Location = new System.Drawing.Point(20, 203);
            this.gbBluRayTitleInfoDefaultSettings.Name = "gbBluRayTitleInfoDefaultSettings";
            this.gbBluRayTitleInfoDefaultSettings.Size = new System.Drawing.Size(762, 294);
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
            this.chkBluRayTitleInfoDefaultSettingsSelectChapters.TabIndex = 4;
            this.chkBluRayTitleInfoDefaultSettingsSelectChapters.Text = "Select Chapters";
            this.chkBluRayTitleInfoDefaultSettingsSelectChapters.UseVisualStyleBackColor = true;
            this.chkBluRayTitleInfoDefaultSettingsSelectChapters.CheckedChanged += new System.EventHandler(this.chkBluRayTitleInfoDefaultSettingsSelectChapters_CheckedChanged);
            // 
            // chkBluRayTitleInfoDefaultSettingsSelectSubtitles
            // 
            this.chkBluRayTitleInfoDefaultSettingsSelectSubtitles.AutoSize = true;
            this.chkBluRayTitleInfoDefaultSettingsSelectSubtitles.Location = new System.Drawing.Point(11, 32);
            this.chkBluRayTitleInfoDefaultSettingsSelectSubtitles.Name = "chkBluRayTitleInfoDefaultSettingsSelectSubtitles";
            this.chkBluRayTitleInfoDefaultSettingsSelectSubtitles.Size = new System.Drawing.Size(99, 17);
            this.chkBluRayTitleInfoDefaultSettingsSelectSubtitles.TabIndex = 3;
            this.chkBluRayTitleInfoDefaultSettingsSelectSubtitles.Text = "Select Subtitles";
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
            this.dgvBluRayTitleInfoDefaultSettingsAudio.Size = new System.Drawing.Size(750, 230);
            this.dgvBluRayTitleInfoDefaultSettingsAudio.TabIndex = 0;
            this.dgvBluRayTitleInfoDefaultSettingsAudio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBluRayTitleInfoDefaultSettingsAudio_CellClick);
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
            this.btnSave.Location = new System.Drawing.Point(705, 521);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 25);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ofdFileDialog
            // 
            this.ofdFileDialog.FileName = "openFileDialog1";
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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 549);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BatchGuy Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.gbScreen.ResumeLayout(false);
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
    }
}
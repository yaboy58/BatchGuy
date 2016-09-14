namespace BatchGuy.App
{
    partial class BluRayTitleInfoExternalSubtitleForm
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
            this.gbExternalSubtitles = new System.Windows.Forms.GroupBox();
            this.btnOpenExternalSubtitleFilePathDialog = new System.Windows.Forms.Button();
            this.txtExternalSubtitlePath = new System.Windows.Forms.TextBox();
            this.lblBatchFilePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.cbExternalSubtitleLanguage = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.bsMKVMergeLanguageItem = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblExternalSubtitleEAC3ToTrackId = new System.Windows.Forms.Label();
            this.gbExternalSubtitles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMKVMergeLanguageItem)).BeginInit();
            this.SuspendLayout();
            // 
            // gbExternalSubtitles
            // 
            this.gbExternalSubtitles.Controls.Add(this.lblExternalSubtitleEAC3ToTrackId);
            this.gbExternalSubtitles.Controls.Add(this.label2);
            this.gbExternalSubtitles.Controls.Add(this.cbExternalSubtitleLanguage);
            this.gbExternalSubtitles.Controls.Add(this.btnOpenExternalSubtitleFilePathDialog);
            this.gbExternalSubtitles.Controls.Add(this.txtExternalSubtitlePath);
            this.gbExternalSubtitles.Controls.Add(this.lblBatchFilePath);
            this.gbExternalSubtitles.Controls.Add(this.label1);
            this.gbExternalSubtitles.Location = new System.Drawing.Point(5, 12);
            this.gbExternalSubtitles.Name = "gbExternalSubtitles";
            this.gbExternalSubtitles.Size = new System.Drawing.Size(654, 134);
            this.gbExternalSubtitles.TabIndex = 0;
            this.gbExternalSubtitles.TabStop = false;
            this.gbExternalSubtitles.Text = "External Subtitles";
            // 
            // btnOpenExternalSubtitleFilePathDialog
            // 
            this.btnOpenExternalSubtitleFilePathDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenExternalSubtitleFilePathDialog.Location = new System.Drawing.Point(572, 84);
            this.btnOpenExternalSubtitleFilePathDialog.Name = "btnOpenExternalSubtitleFilePathDialog";
            this.btnOpenExternalSubtitleFilePathDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenExternalSubtitleFilePathDialog.TabIndex = 1;
            this.btnOpenExternalSubtitleFilePathDialog.UseVisualStyleBackColor = true;
            // 
            // txtExternalSubtitlePath
            // 
            this.txtExternalSubtitlePath.Location = new System.Drawing.Point(118, 93);
            this.txtExternalSubtitlePath.Name = "txtExternalSubtitlePath";
            this.txtExternalSubtitlePath.ReadOnly = true;
            this.txtExternalSubtitlePath.Size = new System.Drawing.Size(441, 20);
            this.txtExternalSubtitlePath.TabIndex = 42;
            // 
            // lblBatchFilePath
            // 
            this.lblBatchFilePath.AutoSize = true;
            this.lblBatchFilePath.Location = new System.Drawing.Point(15, 100);
            this.lblBatchFilePath.Name = "lblBatchFilePath";
            this.lblBatchFilePath.Size = new System.Drawing.Size(68, 13);
            this.lblBatchFilePath.TabIndex = 43;
            this.lblBatchFilePath.Text = "Subtitle File*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Language";
            // 
            // ofdFileDialog
            // 
            this.ofdFileDialog.FileName = "openFileDialog";
            // 
            // cbExternalSubtitleLanguage
            // 
            this.cbExternalSubtitleLanguage.DisplayMember = "Name";
            this.cbExternalSubtitleLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExternalSubtitleLanguage.FormattingEnabled = true;
            this.cbExternalSubtitleLanguage.Location = new System.Drawing.Point(118, 51);
            this.cbExternalSubtitleLanguage.Name = "cbExternalSubtitleLanguage";
            this.cbExternalSubtitleLanguage.Size = new System.Drawing.Size(298, 21);
            this.cbExternalSubtitleLanguage.TabIndex = 0;
            this.cbExternalSubtitleLanguage.ValueMember = "Value";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(427, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 33);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(548, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 33);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // bsMKVMergeLanguageItem
            // 
            this.bsMKVMergeLanguageItem.AllowNew = false;
            this.bsMKVMergeLanguageItem.DataSource = typeof(BatchGuy.App.MKVMerge.Models.MKVMergeLanguageItem);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "eac3to Track Id";
            // 
            // lblExternalSubtitleEAC3ToTrackId
            // 
            this.lblExternalSubtitleEAC3ToTrackId.AutoSize = true;
            this.lblExternalSubtitleEAC3ToTrackId.Location = new System.Drawing.Point(115, 27);
            this.lblExternalSubtitleEAC3ToTrackId.Name = "lblExternalSubtitleEAC3ToTrackId";
            this.lblExternalSubtitleEAC3ToTrackId.Size = new System.Drawing.Size(16, 13);
            this.lblExternalSubtitleEAC3ToTrackId.TabIndex = 45;
            this.lblExternalSubtitleEAC3ToTrackId.Text = "Id";
            // 
            // BluRayTitleInfoExternalSubtitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 203);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbExternalSubtitles);
            this.Name = "BluRayTitleInfoExternalSubtitleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Save External Subtitles";
            this.Load += new System.EventHandler(this.BluRayTitleInfoExternalSubtitleForm_Load);
            this.gbExternalSubtitles.ResumeLayout(false);
            this.gbExternalSubtitles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMKVMergeLanguageItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbExternalSubtitles;
        private System.Windows.Forms.Button btnOpenExternalSubtitleFilePathDialog;
        private System.Windows.Forms.TextBox txtExternalSubtitlePath;
        private System.Windows.Forms.Label lblBatchFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofdFileDialog;
        private System.Windows.Forms.ComboBox cbExternalSubtitleLanguage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bsMKVMergeLanguageItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExternalSubtitleEAC3ToTrackId;
    }
}
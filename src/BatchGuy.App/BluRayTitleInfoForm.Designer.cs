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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbVideo = new System.Windows.Forms.GroupBox();
            this.lblVideoText = new System.Windows.Forms.Label();
            this.chkVideoIsSelected = new System.Windows.Forms.CheckBox();
            this.gbAudio = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAudioTypeArguments = new System.Windows.Forms.TextBox();
            this.cbAudioType = new System.Windows.Forms.ComboBox();
            this.lblAudioType = new System.Windows.Forms.Label();
            this.dgvAudio = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.bsBluRayTitleAudio = new System.Windows.Forms.BindingSource(this.components);
            this.bsBluRayTitleVideo = new System.Windows.Forms.BindingSource(this.components);
            this.bsBluRayTitleInfo = new System.Windows.Forms.BindingSource(this.components);
            this.lblAudioTypeArguments = new System.Windows.Forms.Label();
            this.isSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.audioType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arguments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbVideo.SuspendLayout();
            this.gbAudio.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleAudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // gbVideo
            // 
            this.gbVideo.Controls.Add(this.lblVideoText);
            this.gbVideo.Controls.Add(this.chkVideoIsSelected);
            this.gbVideo.Location = new System.Drawing.Point(15, 62);
            this.gbVideo.Name = "gbVideo";
            this.gbVideo.Size = new System.Drawing.Size(896, 65);
            this.gbVideo.TabIndex = 1;
            this.gbVideo.TabStop = false;
            this.gbVideo.Text = "Video";
            // 
            // lblVideoText
            // 
            this.lblVideoText.AutoSize = true;
            this.lblVideoText.Location = new System.Drawing.Point(77, 28);
            this.lblVideoText.Name = "lblVideoText";
            this.lblVideoText.Size = new System.Drawing.Size(37, 13);
            this.lblVideoText.TabIndex = 1;
            this.lblVideoText.Text = "Video:";
            // 
            // chkVideoIsSelected
            // 
            this.chkVideoIsSelected.AutoSize = true;
            this.chkVideoIsSelected.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsBluRayTitleVideo, "IsSelected", true));
            this.chkVideoIsSelected.Location = new System.Drawing.Point(6, 28);
            this.chkVideoIsSelected.Name = "chkVideoIsSelected";
            this.chkVideoIsSelected.Size = new System.Drawing.Size(56, 17);
            this.chkVideoIsSelected.TabIndex = 0;
            this.chkVideoIsSelected.Text = "Select";
            this.chkVideoIsSelected.UseVisualStyleBackColor = true;
            // 
            // gbAudio
            // 
            this.gbAudio.Controls.Add(this.panel1);
            this.gbAudio.Controls.Add(this.dgvAudio);
            this.gbAudio.Location = new System.Drawing.Point(12, 155);
            this.gbAudio.Name = "gbAudio";
            this.gbAudio.Size = new System.Drawing.Size(896, 262);
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
            // txtAudioTypeArguments
            // 
            this.txtAudioTypeArguments.Location = new System.Drawing.Point(372, 11);
            this.txtAudioTypeArguments.Name = "txtAudioTypeArguments";
            this.txtAudioTypeArguments.Size = new System.Drawing.Size(288, 20);
            this.txtAudioTypeArguments.TabIndex = 2;
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
            "TrueHD"});
            this.cbAudioType.Location = new System.Drawing.Point(94, 10);
            this.cbAudioType.Name = "cbAudioType";
            this.cbAudioType.Size = new System.Drawing.Size(186, 21);
            this.cbAudioType.TabIndex = 1;
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
            this.dgvAudio.TabIndex = 0;
            this.dgvAudio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAudio_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(708, 623);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(203, 25);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // bsBluRayTitleAudio
            // 
            this.bsBluRayTitleAudio.DataSource = typeof(BatchGuy.App.Parser.Models.BluRayTitleAudio);
            // 
            // bsBluRayTitleVideo
            // 
            this.bsBluRayTitleVideo.DataSource = typeof(BatchGuy.App.Parser.Models.BluRayTitleVideo);
            // 
            // bsBluRayTitleInfo
            // 
            this.bsBluRayTitleInfo.DataSource = typeof(BatchGuy.App.Parser.Models.BluRayTitleInfo);
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
            // isSelected
            // 
            this.isSelected.DataPropertyName = "IsSelected";
            this.isSelected.HeaderText = "IsSelected";
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
            this.audioType.HeaderText = "AudioType";
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
            // BluRayTitleInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 660);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gbAudio);
            this.Controls.Add(this.gbVideo);
            this.Controls.Add(this.lblTitle);
            this.Name = "BluRayTitleInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BluRayTitleForm";
            this.Load += new System.EventHandler(this.BluRayTitleForm_Load);
            this.gbVideo.ResumeLayout(false);
            this.gbVideo.PerformLayout();
            this.gbAudio.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleAudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbVideo;
        private System.Windows.Forms.Label lblVideoText;
        private System.Windows.Forms.CheckBox chkVideoIsSelected;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn language;
        private System.Windows.Forms.DataGridViewTextBoxColumn text;
        private System.Windows.Forms.DataGridViewTextBoxColumn audioType;
        private System.Windows.Forms.DataGridViewTextBoxColumn arguments;
    }
}
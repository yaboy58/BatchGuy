namespace BatchGuy.App
{
    partial class CreateX264BatchFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateX264BatchFileForm));
            this.label4 = new System.Windows.Forms.Label();
            this.cbEncodeType = new System.Windows.Forms.ComboBox();
            this.btnCreateX264BatchFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtX264Template = new System.Windows.Forms.TextBox();
            this.lblAviSynthScriptsLocation = new System.Windows.Forms.Label();
            this.txtAviSynthFileDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.btnLoadAVSFiles = new System.Windows.Forms.Button();
            this.lblNumberOfFiles = new System.Windows.Forms.Label();
            this.ofdFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenAviSynthScriptLocationDialog = new System.Windows.Forms.Button();
            this.gbScreen = new System.Windows.Forms.GroupBox();
            this.bgwCreateX264BatchFile = new System.ComponentModel.BackgroundWorker();
            this.bgwLoadAviSynthFiles = new System.ComponentModel.BackgroundWorker();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVSFileNameOnlyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encodeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFiles = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.gbScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Encode Type:";
            // 
            // cbEncodeType
            // 
            this.cbEncodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncodeType.FormattingEnabled = true;
            this.cbEncodeType.Items.AddRange(new object[] {
            "CRF",
            "2Pass"});
            this.cbEncodeType.Location = new System.Drawing.Point(654, 347);
            this.cbEncodeType.Name = "cbEncodeType";
            this.cbEncodeType.Size = new System.Drawing.Size(148, 21);
            this.cbEncodeType.TabIndex = 15;
            this.cbEncodeType.SelectedIndexChanged += new System.EventHandler(this.cbEncodeType_SelectedIndexChanged);
            // 
            // btnCreateX264BatchFile
            // 
            this.btnCreateX264BatchFile.Enabled = false;
            this.btnCreateX264BatchFile.Location = new System.Drawing.Point(634, 556);
            this.btnCreateX264BatchFile.Name = "btnCreateX264BatchFile";
            this.btnCreateX264BatchFile.Size = new System.Drawing.Size(168, 33);
            this.btnCreateX264BatchFile.TabIndex = 14;
            this.btnCreateX264BatchFile.Text = "Create x264 Batch File";
            this.btnCreateX264BatchFile.UseVisualStyleBackColor = true;
            this.btnCreateX264BatchFile.Click += new System.EventHandler(this.btnCreateX264BatFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "x264 Template:";
            // 
            // txtX264Template
            // 
            this.txtX264Template.Location = new System.Drawing.Point(27, 373);
            this.txtX264Template.Multiline = true;
            this.txtX264Template.Name = "txtX264Template";
            this.txtX264Template.Size = new System.Drawing.Size(775, 168);
            this.txtX264Template.TabIndex = 12;
            // 
            // lblAviSynthScriptsLocation
            // 
            this.lblAviSynthScriptsLocation.AutoSize = true;
            this.lblAviSynthScriptsLocation.Location = new System.Drawing.Point(24, 34);
            this.lblAviSynthScriptsLocation.Name = "lblAviSynthScriptsLocation";
            this.lblAviSynthScriptsLocation.Size = new System.Drawing.Size(129, 13);
            this.lblAviSynthScriptsLocation.TabIndex = 11;
            this.lblAviSynthScriptsLocation.Text = "AviSynth Scripts Directory";
            // 
            // txtAviSynthFileDirectory
            // 
            this.txtAviSynthFileDirectory.Location = new System.Drawing.Point(162, 27);
            this.txtAviSynthFileDirectory.Name = "txtAviSynthFileDirectory";
            this.txtAviSynthFileDirectory.ReadOnly = true;
            this.txtAviSynthFileDirectory.Size = new System.Drawing.Size(434, 20);
            this.txtAviSynthFileDirectory.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "File Names:";
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToOrderColumns = true;
            this.dgvFiles.AutoGenerateColumns = false;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.aVSFileNameOnlyDataGridViewTextBoxColumn,
            this.encodeNameDataGridViewTextBoxColumn});
            this.dgvFiles.DataSource = this.bsFiles;
            this.dgvFiles.Location = new System.Drawing.Point(26, 106);
            this.dgvFiles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.RowTemplate.Height = 24;
            this.dgvFiles.Size = new System.Drawing.Size(776, 222);
            this.dgvFiles.TabIndex = 19;
            this.dgvFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellClick);
            this.dgvFiles.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvFiles_RowsRemoved);
            // 
            // btnLoadAVSFiles
            // 
            this.btnLoadAVSFiles.Location = new System.Drawing.Point(666, 67);
            this.btnLoadAVSFiles.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadAVSFiles.Name = "btnLoadAVSFiles";
            this.btnLoadAVSFiles.Size = new System.Drawing.Size(136, 29);
            this.btnLoadAVSFiles.TabIndex = 20;
            this.btnLoadAVSFiles.Text = "Load AviSynth Files";
            this.btnLoadAVSFiles.UseVisualStyleBackColor = true;
            this.btnLoadAVSFiles.Click += new System.EventHandler(this.btnLoadAVSFiles_Click);
            // 
            // lblNumberOfFiles
            // 
            this.lblNumberOfFiles.AutoSize = true;
            this.lblNumberOfFiles.Location = new System.Drawing.Point(23, 330);
            this.lblNumberOfFiles.Name = "lblNumberOfFiles";
            this.lblNumberOfFiles.Size = new System.Drawing.Size(83, 13);
            this.lblNumberOfFiles.TabIndex = 23;
            this.lblNumberOfFiles.Text = "Number of Files:";
            // 
            // ofdFileDialog
            // 
            this.ofdFileDialog.FileName = "openFileDialog1";
            // 
            // btnOpenAviSynthScriptLocationDialog
            // 
            this.btnOpenAviSynthScriptLocationDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenAviSynthScriptLocationDialog.Location = new System.Drawing.Point(602, 14);
            this.btnOpenAviSynthScriptLocationDialog.Name = "btnOpenAviSynthScriptLocationDialog";
            this.btnOpenAviSynthScriptLocationDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenAviSynthScriptLocationDialog.TabIndex = 0;
            this.btnOpenAviSynthScriptLocationDialog.UseVisualStyleBackColor = true;
            this.btnOpenAviSynthScriptLocationDialog.Click += new System.EventHandler(this.btnOpenAviSynthScriptOutputDialog_Click);
            // 
            // gbScreen
            // 
            this.gbScreen.Controls.Add(this.lblAviSynthScriptsLocation);
            this.gbScreen.Controls.Add(this.txtAviSynthFileDirectory);
            this.gbScreen.Controls.Add(this.btnOpenAviSynthScriptLocationDialog);
            this.gbScreen.Controls.Add(this.txtX264Template);
            this.gbScreen.Controls.Add(this.lblNumberOfFiles);
            this.gbScreen.Controls.Add(this.label3);
            this.gbScreen.Controls.Add(this.btnCreateX264BatchFile);
            this.gbScreen.Controls.Add(this.cbEncodeType);
            this.gbScreen.Controls.Add(this.btnLoadAVSFiles);
            this.gbScreen.Controls.Add(this.label4);
            this.gbScreen.Controls.Add(this.dgvFiles);
            this.gbScreen.Controls.Add(this.label1);
            this.gbScreen.Location = new System.Drawing.Point(12, 12);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Size = new System.Drawing.Size(824, 599);
            this.gbScreen.TabIndex = 31;
            this.gbScreen.TabStop = false;
            // 
            // bgwCreateX264BatchFile
            // 
            this.bgwCreateX264BatchFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCreateX264BatchFile_DoWork);
            this.bgwCreateX264BatchFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCreateX264BatchFile_RunWorkerCompleted);
            // 
            // bgwLoadAviSynthFiles
            // 
            this.bgwLoadAviSynthFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLoadAviSynthFiles_DoWork);
            this.bgwLoadAviSynthFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLoadAviSynthFiles_RunWorkerCompleted);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // aVSFileNameOnlyDataGridViewTextBoxColumn
            // 
            this.aVSFileNameOnlyDataGridViewTextBoxColumn.DataPropertyName = "AVSFileNameOnly";
            this.aVSFileNameOnlyDataGridViewTextBoxColumn.HeaderText = "AviSynth File";
            this.aVSFileNameOnlyDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.aVSFileNameOnlyDataGridViewTextBoxColumn.Name = "aVSFileNameOnlyDataGridViewTextBoxColumn";
            this.aVSFileNameOnlyDataGridViewTextBoxColumn.Width = 200;
            // 
            // encodeNameDataGridViewTextBoxColumn
            // 
            this.encodeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.encodeNameDataGridViewTextBoxColumn.DataPropertyName = "EncodeName";
            this.encodeNameDataGridViewTextBoxColumn.HeaderText = "Encode Name (EX: Episode01.mkv)";
            this.encodeNameDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.encodeNameDataGridViewTextBoxColumn.Name = "encodeNameDataGridViewTextBoxColumn";
            // 
            // bsFiles
            // 
            this.bsFiles.DataSource = typeof(BatchGuy.App.X264.Models.X264File);
            // 
            // CreateX264BatchFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 621);
            this.Controls.Add(this.gbScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateX264BatchFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create x264 Batch File";
            this.Load += new System.EventHandler(this.CreateX264BatFileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.gbScreen.ResumeLayout(false);
            this.gbScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEncodeType;
        private System.Windows.Forms.Button btnCreateX264BatchFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtX264Template;
        private System.Windows.Forms.Label lblAviSynthScriptsLocation;
        private System.Windows.Forms.TextBox txtAviSynthFileDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.BindingSource bsFiles;
        private System.Windows.Forms.Button btnLoadAVSFiles;
        private System.Windows.Forms.Label lblNumberOfFiles;
        private System.Windows.Forms.OpenFileDialog ofdFileDialog;
        private System.Windows.Forms.Button btnOpenAviSynthScriptLocationDialog;
        private System.Windows.Forms.GroupBox gbScreen;
        private System.ComponentModel.BackgroundWorker bgwCreateX264BatchFile;
        private System.ComponentModel.BackgroundWorker bgwLoadAviSynthFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVSFileNameOnlyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encodeNameDataGridViewTextBoxColumn;
    }
}
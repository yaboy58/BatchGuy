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
            this.btnCreateX264BatFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtX264Template = new System.Windows.Forms.TextBox();
            this.lblAviSynthScriptsLocation = new System.Windows.Forms.Label();
            this.txtAVSFileLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVSFileNameOnlyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encodeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFiles = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoadAVSFiles = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVfw4x264exe = new System.Windows.Forms.TextBox();
            this.lblNumberOfFiles = new System.Windows.Forms.Label();
            this.ofdFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fbdDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnOpenVfw4x264FileDialog = new System.Windows.Forms.Button();
            this.btnOpenAviSynthScriptLocationDialog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 376);
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
            this.cbEncodeType.Location = new System.Drawing.Point(641, 369);
            this.cbEncodeType.Name = "cbEncodeType";
            this.cbEncodeType.Size = new System.Drawing.Size(148, 21);
            this.cbEncodeType.TabIndex = 15;
            this.cbEncodeType.SelectedIndexChanged += new System.EventHandler(this.cbEncodeType_SelectedIndexChanged);
            // 
            // btnCreateX264BatFile
            // 
            this.btnCreateX264BatFile.Location = new System.Drawing.Point(621, 621);
            this.btnCreateX264BatFile.Name = "btnCreateX264BatFile";
            this.btnCreateX264BatFile.Size = new System.Drawing.Size(168, 44);
            this.btnCreateX264BatFile.TabIndex = 14;
            this.btnCreateX264BatFile.Text = "Create x264 Batch File";
            this.btnCreateX264BatFile.UseVisualStyleBackColor = true;
            this.btnCreateX264BatFile.Click += new System.EventHandler(this.btnCreateX264BatFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "x264 Template:";
            // 
            // txtX264Template
            // 
            this.txtX264Template.Location = new System.Drawing.Point(14, 396);
            this.txtX264Template.Multiline = true;
            this.txtX264Template.Name = "txtX264Template";
            this.txtX264Template.Size = new System.Drawing.Size(775, 219);
            this.txtX264Template.TabIndex = 12;
            // 
            // lblAviSynthScriptsLocation
            // 
            this.lblAviSynthScriptsLocation.AutoSize = true;
            this.lblAviSynthScriptsLocation.Location = new System.Drawing.Point(12, 17);
            this.lblAviSynthScriptsLocation.Name = "lblAviSynthScriptsLocation";
            this.lblAviSynthScriptsLocation.Size = new System.Drawing.Size(128, 13);
            this.lblAviSynthScriptsLocation.TabIndex = 11;
            this.lblAviSynthScriptsLocation.Text = "AviSynth Scripts Location";
            // 
            // txtAVSFileLocation
            // 
            this.txtAVSFileLocation.Location = new System.Drawing.Point(150, 10);
            this.txtAVSFileLocation.Name = "txtAVSFileLocation";
            this.txtAVSFileLocation.ReadOnly = true;
            this.txtAVSFileLocation.Size = new System.Drawing.Size(434, 20);
            this.txtAVSFileLocation.TabIndex = 10;
            this.txtAVSFileLocation.Text = "C:\\temp\\My Encodes\\Blu-ray";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
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
            this.dgvFiles.Location = new System.Drawing.Point(14, 107);
            this.dgvFiles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.RowTemplate.Height = 24;
            this.dgvFiles.Size = new System.Drawing.Size(776, 222);
            this.dgvFiles.TabIndex = 19;
            this.dgvFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellClick);
            this.dgvFiles.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvFiles_RowsRemoved);
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
            this.aVSFileNameOnlyDataGridViewTextBoxColumn.MinimumWidth = 100;
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
            // btnLoadAVSFiles
            // 
            this.btnLoadAVSFiles.Location = new System.Drawing.Point(653, 78);
            this.btnLoadAVSFiles.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadAVSFiles.Name = "btnLoadAVSFiles";
            this.btnLoadAVSFiles.Size = new System.Drawing.Size(136, 24);
            this.btnLoadAVSFiles.TabIndex = 20;
            this.btnLoadAVSFiles.Text = "Load AviSynth Files";
            this.btnLoadAVSFiles.UseVisualStyleBackColor = true;
            this.btnLoadAVSFiles.Click += new System.EventHandler(this.btnLoadAVSFiles_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "vfw4x264.exe";
            // 
            // txtVfw4x264exe
            // 
            this.txtVfw4x264exe.Location = new System.Drawing.Point(150, 52);
            this.txtVfw4x264exe.Name = "txtVfw4x264exe";
            this.txtVfw4x264exe.ReadOnly = true;
            this.txtVfw4x264exe.Size = new System.Drawing.Size(434, 20);
            this.txtVfw4x264exe.TabIndex = 21;
            this.txtVfw4x264exe.Text = "C:\\exe\\vfw4x264\\vfw4x264.exe";
            // 
            // lblNumberOfFiles
            // 
            this.lblNumberOfFiles.AutoSize = true;
            this.lblNumberOfFiles.Location = new System.Drawing.Point(11, 331);
            this.lblNumberOfFiles.Name = "lblNumberOfFiles";
            this.lblNumberOfFiles.Size = new System.Drawing.Size(83, 13);
            this.lblNumberOfFiles.TabIndex = 23;
            this.lblNumberOfFiles.Text = "Number of Files:";
            // 
            // ofdFileDialog
            // 
            this.ofdFileDialog.FileName = "openFileDialog1";
            // 
            // btnOpenVfw4x264FileDialog
            // 
            this.btnOpenVfw4x264FileDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenVfw4x264FileDialog.Location = new System.Drawing.Point(590, 41);
            this.btnOpenVfw4x264FileDialog.Name = "btnOpenVfw4x264FileDialog";
            this.btnOpenVfw4x264FileDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenVfw4x264FileDialog.TabIndex = 30;
            this.btnOpenVfw4x264FileDialog.UseVisualStyleBackColor = true;
            this.btnOpenVfw4x264FileDialog.Click += new System.EventHandler(this.btnOpenVfw4x264FileDialog_Click);
            // 
            // btnOpenAviSynthScriptLocationDialog
            // 
            this.btnOpenAviSynthScriptLocationDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenAviSynthScriptLocationDialog.Location = new System.Drawing.Point(590, 3);
            this.btnOpenAviSynthScriptLocationDialog.Name = "btnOpenAviSynthScriptLocationDialog";
            this.btnOpenAviSynthScriptLocationDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenAviSynthScriptLocationDialog.TabIndex = 29;
            this.btnOpenAviSynthScriptLocationDialog.UseVisualStyleBackColor = true;
            this.btnOpenAviSynthScriptLocationDialog.Click += new System.EventHandler(this.btnOpenAviSynthScriptOutputDialog_Click);
            // 
            // CreateX264BatFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 682);
            this.Controls.Add(this.btnOpenVfw4x264FileDialog);
            this.Controls.Add(this.btnOpenAviSynthScriptLocationDialog);
            this.Controls.Add(this.lblNumberOfFiles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVfw4x264exe);
            this.Controls.Add(this.btnLoadAVSFiles);
            this.Controls.Add(this.dgvFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEncodeType);
            this.Controls.Add(this.btnCreateX264BatFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtX264Template);
            this.Controls.Add(this.lblAviSynthScriptsLocation);
            this.Controls.Add(this.txtAVSFileLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateX264BatFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create x264 Batch File";
            this.Load += new System.EventHandler(this.CreateX264BatFileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEncodeType;
        private System.Windows.Forms.Button btnCreateX264BatFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtX264Template;
        private System.Windows.Forms.Label lblAviSynthScriptsLocation;
        private System.Windows.Forms.TextBox txtAVSFileLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.BindingSource bsFiles;
        private System.Windows.Forms.Button btnLoadAVSFiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVfw4x264exe;
        private System.Windows.Forms.Label lblNumberOfFiles;
        private System.Windows.Forms.OpenFileDialog ofdFileDialog;
        private System.Windows.Forms.FolderBrowserDialog fbdDialog;
        private System.Windows.Forms.Button btnOpenVfw4x264FileDialog;
        private System.Windows.Forms.Button btnOpenAviSynthScriptLocationDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVSFileNameOnlyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encodeNameDataGridViewTextBoxColumn;
    }
}
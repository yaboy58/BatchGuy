namespace BatchGuy.App
{
    partial class CreateAviSynthFilesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAviSynthFilesForm));
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutputDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAVSTemplate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumberOfFiles = new System.Windows.Forms.TextBox();
            this.btnOpenDialog = new System.Windows.Forms.Button();
            this.gbScreen = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFFMSIndexOutputDirectory = new System.Windows.Forms.TextBox();
            this.btnFFMSIndexOpenDialog = new System.Windows.Forms.Button();
            this.lblMKVFilesDirectoryCaption = new System.Windows.Forms.Label();
            this.txtMKVFilesDirectory = new System.Windows.Forms.TextBox();
            this.lblDirectoryType = new System.Windows.Forms.Label();
            this.lblDirectoryTypeCaption = new System.Windows.Forms.Label();
            this.cbVideoFilter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bgwCreateAviSynthFiles = new System.ComponentModel.BackgroundWorker();
            this.ttNumberOfFiles = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.saveSettingsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.createAviSynthavsFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFfindexBatchFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblVersion = new System.Windows.Forms.Label();
            this.bgwCreateFFMSIndexBatchFile = new System.ComponentModel.BackgroundWorker();
            this.gbScreen.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "(.avs) Files Output Directory*:";
            // 
            // txtOutputDirectory
            // 
            this.txtOutputDirectory.Location = new System.Drawing.Point(162, 84);
            this.txtOutputDirectory.Name = "txtOutputDirectory";
            this.txtOutputDirectory.ReadOnly = true;
            this.txtOutputDirectory.Size = new System.Drawing.Size(768, 20);
            this.txtOutputDirectory.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "AviSynth Template*:";
            // 
            // txtAVSTemplate
            // 
            this.txtAVSTemplate.Location = new System.Drawing.Point(16, 215);
            this.txtAVSTemplate.Multiline = true;
            this.txtAVSTemplate.Name = "txtAVSTemplate";
            this.txtAVSTemplate.Size = new System.Drawing.Size(981, 161);
            this.txtAVSTemplate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number of Files (Episodes)*:";
            // 
            // txtNumberOfFiles
            // 
            this.txtNumberOfFiles.Location = new System.Drawing.Point(157, 161);
            this.txtNumberOfFiles.Name = "txtNumberOfFiles";
            this.txtNumberOfFiles.ReadOnly = true;
            this.txtNumberOfFiles.Size = new System.Drawing.Size(54, 20);
            this.txtNumberOfFiles.TabIndex = 1;
            // 
            // btnOpenDialog
            // 
            this.btnOpenDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenDialog.Location = new System.Drawing.Point(936, 71);
            this.btnOpenDialog.Name = "btnOpenDialog";
            this.btnOpenDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenDialog.TabIndex = 0;
            this.btnOpenDialog.UseVisualStyleBackColor = true;
            this.btnOpenDialog.Click += new System.EventHandler(this.btnOpenDialog_Click);
            // 
            // gbScreen
            // 
            this.gbScreen.Controls.Add(this.label7);
            this.gbScreen.Controls.Add(this.txtFFMSIndexOutputDirectory);
            this.gbScreen.Controls.Add(this.btnFFMSIndexOpenDialog);
            this.gbScreen.Controls.Add(this.lblMKVFilesDirectoryCaption);
            this.gbScreen.Controls.Add(this.txtMKVFilesDirectory);
            this.gbScreen.Controls.Add(this.lblDirectoryType);
            this.gbScreen.Controls.Add(this.lblDirectoryTypeCaption);
            this.gbScreen.Controls.Add(this.cbVideoFilter);
            this.gbScreen.Controls.Add(this.label6);
            this.gbScreen.Controls.Add(this.label5);
            this.gbScreen.Controls.Add(this.label4);
            this.gbScreen.Controls.Add(this.txtOutputDirectory);
            this.gbScreen.Controls.Add(this.label3);
            this.gbScreen.Controls.Add(this.btnOpenDialog);
            this.gbScreen.Controls.Add(this.txtNumberOfFiles);
            this.gbScreen.Controls.Add(this.label2);
            this.gbScreen.Controls.Add(this.txtAVSTemplate);
            this.gbScreen.Controls.Add(this.label1);
            this.gbScreen.Location = new System.Drawing.Point(12, 39);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Size = new System.Drawing.Size(1013, 437);
            this.gbScreen.TabIndex = 12;
            this.gbScreen.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "ffmsindex Batch File Output Directory:";
            // 
            // txtFFMSIndexOutputDirectory
            // 
            this.txtFFMSIndexOutputDirectory.Location = new System.Drawing.Point(209, 124);
            this.txtFFMSIndexOutputDirectory.Name = "txtFFMSIndexOutputDirectory";
            this.txtFFMSIndexOutputDirectory.ReadOnly = true;
            this.txtFFMSIndexOutputDirectory.Size = new System.Drawing.Size(721, 20);
            this.txtFFMSIndexOutputDirectory.TabIndex = 46;
            // 
            // btnFFMSIndexOpenDialog
            // 
            this.btnFFMSIndexOpenDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnFFMSIndexOpenDialog.Location = new System.Drawing.Point(936, 112);
            this.btnFFMSIndexOpenDialog.Name = "btnFFMSIndexOpenDialog";
            this.btnFFMSIndexOpenDialog.Size = new System.Drawing.Size(61, 33);
            this.btnFFMSIndexOpenDialog.TabIndex = 1;
            this.btnFFMSIndexOpenDialog.UseVisualStyleBackColor = true;
            this.btnFFMSIndexOpenDialog.Click += new System.EventHandler(this.btnFFMSIndexOpenDialog_Click);
            // 
            // lblMKVFilesDirectoryCaption
            // 
            this.lblMKVFilesDirectoryCaption.AutoSize = true;
            this.lblMKVFilesDirectoryCaption.Location = new System.Drawing.Point(20, 49);
            this.lblMKVFilesDirectoryCaption.Name = "lblMKVFilesDirectoryCaption";
            this.lblMKVFilesDirectoryCaption.Size = new System.Drawing.Size(108, 13);
            this.lblMKVFilesDirectoryCaption.TabIndex = 44;
            this.lblMKVFilesDirectoryCaption.Text = "(.mkv) Files Directory:";
            // 
            // txtMKVFilesDirectory
            // 
            this.txtMKVFilesDirectory.Location = new System.Drawing.Point(162, 46);
            this.txtMKVFilesDirectory.Name = "txtMKVFilesDirectory";
            this.txtMKVFilesDirectory.ReadOnly = true;
            this.txtMKVFilesDirectory.Size = new System.Drawing.Size(835, 20);
            this.txtMKVFilesDirectory.TabIndex = 43;
            // 
            // lblDirectoryType
            // 
            this.lblDirectoryType.AutoSize = true;
            this.lblDirectoryType.Location = new System.Drawing.Point(159, 16);
            this.lblDirectoryType.Name = "lblDirectoryType";
            this.lblDirectoryType.Size = new System.Drawing.Size(79, 13);
            this.lblDirectoryType.TabIndex = 42;
            this.lblDirectoryType.Text = "Directory Type:";
            // 
            // lblDirectoryTypeCaption
            // 
            this.lblDirectoryTypeCaption.AutoSize = true;
            this.lblDirectoryTypeCaption.Location = new System.Drawing.Point(20, 16);
            this.lblDirectoryTypeCaption.Name = "lblDirectoryTypeCaption";
            this.lblDirectoryTypeCaption.Size = new System.Drawing.Size(118, 13);
            this.lblDirectoryTypeCaption.TabIndex = 41;
            this.lblDirectoryTypeCaption.Text = "Directory Type Chosen:";
            // 
            // cbVideoFilter
            // 
            this.cbVideoFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVideoFilter.FormattingEnabled = true;
            this.cbVideoFilter.Items.AddRange(new object[] {
            "dss2",
            "FFVideoSource"});
            this.cbVideoFilter.Location = new System.Drawing.Point(876, 191);
            this.cbVideoFilter.Name = "cbVideoFilter";
            this.cbVideoFilter.Size = new System.Drawing.Size(121, 21);
            this.cbVideoFilter.TabIndex = 2;
            this.cbVideoFilter.SelectedIndexChanged += new System.EventHandler(this.cbVideoFilter_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(802, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Video Filter*:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(599, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "*Single Directory = video files in a single directory && Per Episode = videos in " +
    "episode01\\video01.mkv, episode02\\video02.mkv";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "*BatchGuy will add video filter automatically";
            // 
            // bgwCreateAviSynthFiles
            // 
            this.bgwCreateAviSynthFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCreateAviSynthFiles_DoWork);
            this.bgwCreateAviSynthFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCreateAviSynthFiles_RunWorkerCompleted);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSettingsFileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1037, 24);
            this.menuStrip.TabIndex = 33;
            this.menuStrip.Text = "menuStrip1";
            // 
            // saveSettingsFileToolStripMenuItem
            // 
            this.saveSettingsFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.createAviSynthavsFilesToolStripMenuItem,
            this.createFfindexBatchFilesToolStripMenuItem,
            this.toolStripSeparator3,
            this.closeToolStripMenuItem});
            this.saveSettingsFileToolStripMenuItem.Name = "saveSettingsFileToolStripMenuItem";
            this.saveSettingsFileToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.saveSettingsFileToolStripMenuItem.Text = "Menu";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Image = global::BatchGuy.App.Properties.Resources.Custom_Icon_Design_Flatastic_10_Open_file;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.loadToolStripMenuItem.Text = "Restore";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(254, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Image = global::BatchGuy.App.Properties.Resources.Custom_Icon_Design_Flatastic_10_New_file;
            this.saveToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(254, 6);
            // 
            // createAviSynthavsFilesToolStripMenuItem
            // 
            this.createAviSynthavsFilesToolStripMenuItem.Enabled = false;
            this.createAviSynthavsFilesToolStripMenuItem.Image = global::BatchGuy.App.Properties.Resources.Fasticon_Green_Ville_2_File;
            this.createAviSynthavsFilesToolStripMenuItem.Name = "createAviSynthavsFilesToolStripMenuItem";
            this.createAviSynthavsFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.createAviSynthavsFilesToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.createAviSynthavsFilesToolStripMenuItem.Text = "Create AviSynth (.avs) Files";
            this.createAviSynthavsFilesToolStripMenuItem.Click += new System.EventHandler(this.createAviSynthavsFilesToolStripMenuItem_Click);
            // 
            // createFfindexBatchFilesToolStripMenuItem
            // 
            this.createFfindexBatchFilesToolStripMenuItem.Enabled = false;
            this.createFfindexBatchFilesToolStripMenuItem.Image = global::BatchGuy.App.Properties.Resources.Fasticon_Green_Ville_2_File;
            this.createFfindexBatchFilesToolStripMenuItem.Name = "createFfindexBatchFilesToolStripMenuItem";
            this.createFfindexBatchFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.createFfindexBatchFilesToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.createFfindexBatchFilesToolStripMenuItem.Text = "Create ffindex Batch File";
            this.createFfindexBatchFilesToolStripMenuItem.Click += new System.EventHandler(this.createFfindexBatchFilesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(254, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::BatchGuy.App.Properties.Resources.close_red;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(9, 479);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 45;
            this.lblVersion.Text = "Version";
            // 
            // bgwCreateFFMSIndexBatchFile
            // 
            this.bgwCreateFFMSIndexBatchFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCreateFFMSIndexBatchFile_DoWork);
            this.bgwCreateFFMSIndexBatchFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCreateFFMSIndexBatchFile_RunWorkerCompleted);
            // 
            // CreateAviSynthFilesForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 503);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.gbScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateAviSynthFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create AviSynth Files";
            this.Load += new System.EventHandler(this.CreateAVSFilesForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.CreateAviSynthFilesForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.CreateAviSynthFilesForm_DragEnter);
            this.gbScreen.ResumeLayout(false);
            this.gbScreen.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutputDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAVSTemplate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumberOfFiles;
        private System.Windows.Forms.Button btnOpenDialog;
        private System.Windows.Forms.GroupBox gbScreen;
        private System.ComponentModel.BackgroundWorker bgwCreateAviSynthFiles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip ttNumberOfFiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbVideoFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblMKVFilesDirectoryCaption;
        private System.Windows.Forms.TextBox txtMKVFilesDirectory;
        private System.Windows.Forms.Label lblDirectoryType;
        private System.Windows.Forms.Label lblDirectoryTypeCaption;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtFFMSIndexOutputDirectory;
        private System.Windows.Forms.Button btnFFMSIndexOpenDialog;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker bgwCreateFFMSIndexBatchFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem createAviSynthavsFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFfindexBatchFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}
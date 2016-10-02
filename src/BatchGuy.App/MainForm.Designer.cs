namespace BatchGuy
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guidesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avisynthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eac3toToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vfw4x264ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x264ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.bgwCheckForNewVersion = new System.ComponentModel.BackgroundWorker();
            this.pbNewVersion = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.createEac3ToBatFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAVSFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createX264BatFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewX264LogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEac3ToBatFileToolStripMenuItem,
            this.createAVSFilesToolStripMenuItem,
            this.createX264BatFileToolStripMenuItem,
            this.viewX264LogsToolStripMenuItem,
            this.toolStripSeparator1,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.projectToolStripMenuItem.Text = "Menu";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(219, 6);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.websiteToolStripMenuItem,
            this.guidesToolStripMenuItem,
            this.changelogToolStripMenuItem,
            this.appsToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.websiteToolStripMenuItem.Text = "Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // guidesToolStripMenuItem
            // 
            this.guidesToolStripMenuItem.Name = "guidesToolStripMenuItem";
            this.guidesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.guidesToolStripMenuItem.Text = "Guides";
            this.guidesToolStripMenuItem.Click += new System.EventHandler(this.guidesToolStripMenuItem_Click);
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            this.changelogToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.changelogToolStripMenuItem.Text = "Changelog";
            this.changelogToolStripMenuItem.Click += new System.EventHandler(this.changelogToolStripMenuItem_Click);
            // 
            // appsToolStripMenuItem
            // 
            this.appsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avisynthToolStripMenuItem,
            this.eac3toToolStripMenuItem,
            this.vfw4x264ToolStripMenuItem,
            this.x264ToolStripMenuItem});
            this.appsToolStripMenuItem.Name = "appsToolStripMenuItem";
            this.appsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.appsToolStripMenuItem.Text = "Apps";
            // 
            // avisynthToolStripMenuItem
            // 
            this.avisynthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pluginsToolStripMenuItem});
            this.avisynthToolStripMenuItem.Name = "avisynthToolStripMenuItem";
            this.avisynthToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.avisynthToolStripMenuItem.Text = "Avisynth";
            this.avisynthToolStripMenuItem.Click += new System.EventHandler(this.avisynthToolStripMenuItem_Click);
            // 
            // pluginsToolStripMenuItem
            // 
            this.pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            this.pluginsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.pluginsToolStripMenuItem.Text = "Plugins";
            this.pluginsToolStripMenuItem.Click += new System.EventHandler(this.pluginsToolStripMenuItem_Click);
            // 
            // eac3toToolStripMenuItem
            // 
            this.eac3toToolStripMenuItem.Name = "eac3toToolStripMenuItem";
            this.eac3toToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.eac3toToolStripMenuItem.Text = "eac3to";
            this.eac3toToolStripMenuItem.Click += new System.EventHandler(this.eac3toToolStripMenuItem_Click);
            // 
            // vfw4x264ToolStripMenuItem
            // 
            this.vfw4x264ToolStripMenuItem.Name = "vfw4x264ToolStripMenuItem";
            this.vfw4x264ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.vfw4x264ToolStripMenuItem.Text = "vfw4x264";
            this.vfw4x264ToolStripMenuItem.Click += new System.EventHandler(this.vfw4x264ToolStripMenuItem_Click);
            // 
            // x264ToolStripMenuItem
            // 
            this.x264ToolStripMenuItem.Name = "x264ToolStripMenuItem";
            this.x264ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.x264ToolStripMenuItem.Text = "x264";
            this.x264ToolStripMenuItem.Click += new System.EventHandler(this.x264ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(129, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 275);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(284, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // bgwCheckForNewVersion
            // 
            this.bgwCheckForNewVersion.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCheckForNewVersion_DoWork);
            this.bgwCheckForNewVersion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCheckForNewVersion_RunWorkerCompleted);
            // 
            // pbNewVersion
            // 
            this.pbNewVersion.Image = global::BatchGuy.App.Properties.Resources.label_new_green;
            this.pbNewVersion.Location = new System.Drawing.Point(234, 27);
            this.pbNewVersion.Name = "pbNewVersion";
            this.pbNewVersion.Size = new System.Drawing.Size(50, 50);
            this.pbNewVersion.TabIndex = 3;
            this.pbNewVersion.TabStop = false;
            this.pbNewVersion.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BatchGuy.App.Properties.Resources.webdev_config_icon;
            this.pictureBox1.Location = new System.Drawing.Point(65, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 132);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // createEac3ToBatFileToolStripMenuItem
            // 
            this.createEac3ToBatFileToolStripMenuItem.Image = global::BatchGuy.App.Properties.Resources.Custom_Icon_Design_Pretty_Office_7_Extract_object;
            this.createEac3ToBatFileToolStripMenuItem.Name = "createEac3ToBatFileToolStripMenuItem";
            this.createEac3ToBatFileToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.createEac3ToBatFileToolStripMenuItem.Text = "Create eac3To Batch File";
            this.createEac3ToBatFileToolStripMenuItem.Click += new System.EventHandler(this.createEac3ToBatFileToolStripMenuItem_Click);
            // 
            // createAVSFilesToolStripMenuItem
            // 
            this.createAVSFilesToolStripMenuItem.Image = global::BatchGuy.App.Properties.Resources.Fatcow_Farm_Fresh_Script_add;
            this.createAVSFilesToolStripMenuItem.Name = "createAVSFilesToolStripMenuItem";
            this.createAVSFilesToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.createAVSFilesToolStripMenuItem.Text = "Create AviSynth Files";
            this.createAVSFilesToolStripMenuItem.Click += new System.EventHandler(this.createAVSFilesToolStripMenuItem_Click);
            // 
            // createX264BatFileToolStripMenuItem
            // 
            this.createX264BatFileToolStripMenuItem.Image = global::BatchGuy.App.Properties.Resources.Custom_Icon_Design_Flatastic_2_Process_accept;
            this.createX264BatFileToolStripMenuItem.Name = "createX264BatFileToolStripMenuItem";
            this.createX264BatFileToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.createX264BatFileToolStripMenuItem.Text = "Create x264 Batch File";
            this.createX264BatFileToolStripMenuItem.Click += new System.EventHandler(this.createX264BatFileToolStripMenuItem_Click);
            // 
            // viewX264LogsToolStripMenuItem
            // 
            this.viewX264LogsToolStripMenuItem.Image = global::BatchGuy.App.Properties.Resources.Everaldo_Crystal_Clear_App_edit;
            this.viewX264LogsToolStripMenuItem.Name = "viewX264LogsToolStripMenuItem";
            this.viewX264LogsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.viewX264LogsToolStripMenuItem.Text = "View Summarized x264 Logs";
            this.viewX264LogsToolStripMenuItem.Click += new System.EventHandler(this.viewX264LogsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::BatchGuy.App.Properties.Resources.Icontexto_Webdev_Webdev_config;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::BatchGuy.App.Properties.Resources.close_red;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 297);
            this.Controls.Add(this.pbNewVersion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BatchGuy";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEac3ToBatFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAVSFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createX264BatFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewX264LogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem guidesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eac3toToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x264ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avisynthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pluginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vfw4x264ToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgwCheckForNewVersion;
        private System.Windows.Forms.PictureBox pbNewVersion;
    }
}


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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEac3ToBatFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAVSFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createX264BatFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEac3ToBatFileToolStripMenuItem,
            this.createAVSFilesToolStripMenuItem,
            this.createX264BatFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.settingsToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.projectToolStripMenuItem.Text = "Menu";
            // 
            // createEac3ToBatFileToolStripMenuItem
            // 
            this.createEac3ToBatFileToolStripMenuItem.Name = "createEac3ToBatFileToolStripMenuItem";
            this.createEac3ToBatFileToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.createEac3ToBatFileToolStripMenuItem.Text = "Create eac3To Batch File";
            this.createEac3ToBatFileToolStripMenuItem.Click += new System.EventHandler(this.createEac3ToBatFileToolStripMenuItem_Click);
            // 
            // createAVSFilesToolStripMenuItem
            // 
            this.createAVSFilesToolStripMenuItem.Name = "createAVSFilesToolStripMenuItem";
            this.createAVSFilesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.createAVSFilesToolStripMenuItem.Text = "Create AviSynth Files";
            this.createAVSFilesToolStripMenuItem.Click += new System.EventHandler(this.createAVSFilesToolStripMenuItem_Click);
            // 
            // createX264BatFileToolStripMenuItem
            // 
            this.createX264BatFileToolStripMenuItem.Name = "createX264BatFileToolStripMenuItem";
            this.createX264BatFileToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.createX264BatFileToolStripMenuItem.Text = "Create x264 Batch File";
            this.createX264BatFileToolStripMenuItem.Click += new System.EventHandler(this.createX264BatFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 86);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BatchGuy";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAVSFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEac3ToBatFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createX264BatFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}


using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatchGuy.App;
using System.Diagnostics;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Shared.Services;
using BatchGuy.App.Settings.Models;
using BatchGuy.App.Extensions;
using BatchGuy.App.Shared.Models;

namespace BatchGuy
{
    public partial class MainForm : Form
    {
        private ILoggingService _loggingService = new LoggingService(Program.GetLogErrorFormat());
        private BatchGuyLatestVersionInfo _batchGuyLatestVersionInfo;
        private IDisplayErrorMessageService _displayErrorMessageService = new DisplayErrorMessageService();

        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!Program.ErrorLoadingApplicationSettings)
            {
                this.LoadLoggingService();
                if (Program.ApplicationSettings.CheckForNewBatchGuyVersions)
                    this.CheckForNewVersion();
            }
            else
            {
                menuStrip1.SetEnabled(false);
            }
            statusStrip.Items[0].Text = string.Format("Version: {0}.{1}.{2}", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major.ToString(), System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString(), System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Build.ToString());
        }

        private void createAVSFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAviSynthFilesForm form = new CreateAviSynthFilesForm();
            form.DialogInitialDirectoryChanged += Program.DialogInitialDirectoryChangedHandler;
            form.ShowDialog();
            form.DialogInitialDirectoryChanged -= Program.DialogInitialDirectoryChangedHandler;
        }

        private void createEac3ToBatFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.ApplicationSettingsService.GetSettingByName("eac3to") != null && !string.IsNullOrEmpty(Program.ApplicationSettingsService.GetSettingByName("eac3to").Value))
            {
                CreateEAC3ToBatchForm form = new CreateEAC3ToBatchForm();
                form.DialogInitialDirectoryChanged += Program.DialogInitialDirectoryChangedHandler;  
                form.ShowDialog();
                form.DialogInitialDirectoryChanged -= Program.DialogInitialDirectoryChangedHandler;
            }
            else
            {
                SettingsForm form = new SettingsForm();
                form.ShowDialog();
            }

        }

        private void createX264BatFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.ApplicationSettingsService.GetSettingByName("vfw4x264") != null && !string.IsNullOrEmpty(Program.ApplicationSettingsService.GetSettingByName("vfw4x264").Value))
            {
                CreateX264BatchFileForm form = new CreateX264BatchFileForm();
                form.DialogInitialDirectoryChanged += Program.DialogInitialDirectoryChangedHandler;
                form.ShowDialog();
                form.DialogInitialDirectoryChanged -= Program.DialogInitialDirectoryChangedHandler;          
            }
            else
            {
                SettingsForm form = new SettingsForm();
                form.ShowDialog();
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.ShowDialog();
        }

        private void viewX264LogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            X264LogFileForm form = new X264LogFileForm();
            form.ShowDialog();
        }

        private void LoadLoggingService()
        {
            _loggingService = new LoggingService(Program.GetLogErrorFormat());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/yaboy58/BatchGuy");
        }

        private void guidesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/yaboy58/BatchGuy/wiki");
        }

        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/yaboy58/BatchGuy/releases");
        }

        private void x264ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.videolan.org/developers/x264.html");
        }

        private void avisynthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://avisynth.nl/index.php/Main_Page");
        }

        private void pluginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://avisynth.nl/index.php/External_filters");
        }

        private void vfw4x264ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://komisar.gin.by/tools/avs4x264/");
        }

        private void eac3toToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://officialsite.pp.ua/?p=2849015");
        }

        private async Task CheckForNewVersion()
        {
            IBatchGuyNotificationService batchGuyNotificationservice = new BatchGuyNotificationService(Program.GetApplicationTag(), _loggingService);

            var task = await batchGuyNotificationservice.GetLatestVersionInfo();

            if (task != null)
                this.CheckForNewVersionCompleted(task);
            else
                _displayErrorMessageService.DisplayError(new ErrorMessage() { DisplayMessage = "An error occurred while trying to check for a new verison", DisplayTitle = "Error Occurred." });
        }

        private void CheckForNewVersionCompleted(BatchGuyLatestVersionInfo result)
        {
            _batchGuyLatestVersionInfo = result;
            if (_batchGuyLatestVersionInfo != null && _batchGuyLatestVersionInfo.IsNewVersion)
            {
                pbNewVersion.Visible = true;
                this.ConfigurepbNewVersion();
            }
        }

        private void ConfigurepbNewVersion()
        {
            if (_batchGuyLatestVersionInfo == null)
                return;
            new ToolTip().SetToolTip(pbNewVersion, string.Format("BatchGuy {0} is now available. Click to navigate to latest release page.", _batchGuyLatestVersionInfo.Name));
        }

        private void pbNewVersion_Click(object sender, EventArgs e)
        {
            if (_batchGuyLatestVersionInfo != null && _batchGuyLatestVersionInfo.LatestGithubUrl != null)
                Process.Start(_batchGuyLatestVersionInfo.LatestGithubUrl);

        }

        private void pbNewVersion_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pbNewVersion_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}

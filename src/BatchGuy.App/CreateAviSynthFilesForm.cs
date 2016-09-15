using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatchGuy.App.AviSynth.Models;
using BatchGuy.App.AviSynth.Services;
using BatchGuy.App.AviSynth.Interfaces;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.Helpers;
using BatchGuy.App.Extensions;
using BatchGuy.App.ThirdParty.FolderSelectDialog;
using BatchGuy.App.Shared.Events;
using BatchGuy.App.Constants;
using BatchGuy.App.Shared.Services;
using BatchGuy.App.Eac3To.Models;
using BatchGuy.App.Shared.Interface;
using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Eac3To.Services;
using log4net;
using System.Reflection;
using BatchGuy.App.Enums;

namespace BatchGuy.App
{
    public partial class CreateAviSynthFilesForm : Form
    {
        public event EventHandler<DialogInitialDirectoryChangedEventArgs> DialogInitialDirectoryChanged;
        public static readonly ILog _log = LogManager.GetLogger(typeof(CreateX264BatchFileForm));

        private IAviSynthFileService _fileService; //ioc
        private IAviSynthValidationService _validationService; //ioc
        private IAviSynthWriteService _avsService; //ioc
        private BatchGuyEAC3ToSettings _batchGuyEAC3ToSettings;
        private string _settingsExtension = "batchGuyEac3toSettings";

        public CreateAviSynthFilesForm()
        {
            InitializeComponent();
            gbScreen.SetEnabled(false);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.SetToolTips();
            txtNumberOfFiles.Focus();
        }

        private void CreateAVSFilesForm_Load(object sender, EventArgs e)
        {
            cbVideoFilter.SelectedIndex = 1;
        }

        private void SetAviSynthTemplateTextBox()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Crop(0,0,0,0)");
            sb.AppendLine(string.Format("{0}Spline36Resize(1280,720)",Environment.NewLine));
            txtAVSTemplate.Text = sb.ToString();
        }

        private void SetToolTips()
        {
           new ToolTip().SetToolTip(txtOutputDirectory, "Directory where AviSynth Files will be saved");
           new ToolTip().SetToolTip(txtNumberOfFiles, "Number of episodes");
        }

        private void btnCreateAVSFiles_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Create AviSynth files?", "Start Process?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (this.IsScreenValid())
                {
                    gbScreen.SetEnabled(false);
                    Process();
                }
            }
        }

        private void Process()
        {
            AviSynthBatchSettings avsBatchSettings = this.GetAVSBatchSettings();
            AviSynthTemplateScript avsTemplateScript = this.GetAVSScript();

            _fileService = new AviSynthFileService(avsBatchSettings, avsTemplateScript);
            _validationService = new AviSynthValidationService(avsBatchSettings);
            _avsService = new AviSynthWriteService(_fileService, _validationService, avsTemplateScript, avsBatchSettings);
            bgwCreateAviSynthFiles.RunWorkerAsync();

        }

        private AviSynthBatchSettings GetAVSBatchSettings()
        {
            return new AviSynthBatchSettings()
            {
                 AviSynthFilesOutputDirectoryPath = txtOutputDirectory.Text,
                  NamingConvention = "video", //hardcoded for now
                   NumberOfFiles = Convert.ToInt32(txtNumberOfFiles.Text),
                    VideoFilter = cbVideoFilter.Text,
                      VideoToEncodeDirectory = _batchGuyEAC3ToSettings.AVSBatchSettings.VideoToEncodeDirectory,
                       VideoToEncodeDirectoryType = _batchGuyEAC3ToSettings.AVSBatchSettings.VideoToEncodeDirectoryType
            };
        }

        private AviSynthTemplateScript GetAVSScript()
        {
            return new AviSynthTemplateScript() { Script = txtAVSTemplate.Text };
        }

        private bool IsScreenValid()
        {
            if (txtOutputDirectory.Text == string.Empty)
            {
                MessageBox.Show("Please enter a file directory", "Directory Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtNumberOfFiles.Text == string.Empty || !txtNumberOfFiles.Text.IsNumeric()  || txtNumberOfFiles.Text.StringToInt() <= 0)
            {
                MessageBox.Show("Invalid number of files", "Number of files Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;                
            }
            if (string.IsNullOrEmpty(txtAVSTemplate.Text))
            {
                MessageBox.Show("Please enter AviSynth Scripts", "Invalid AviSynth Script.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;                                
            }
            return true;
        }

        private void btnOpenDialog_Click(object sender, EventArgs e)
        {
            this.HandleBtnOpenDialogClick();
        }

        private void HandleBtnOpenDialogClick()
        {
            var fsd = new FolderSelectDialog();
            fsd.Title = "AviSynth files output directory";

            Setting setting = Program.ApplicationSettingsService.GetSettingByName(Constant.FeatureCreateAviSynthFilesFormSaveAviSynthFilesDirectory);
            if (setting != null)
                fsd.InitialDirectory = setting.Value;
            else
                fsd.InitialDirectory = @"C:\";

            if (fsd.ShowDialog(IntPtr.Zero))
            {
                OnDialogInitialDirectoryChanged(this, new DialogInitialDirectoryChangedEventArgs() { FeatureName = Constant.FeatureCreateAviSynthFilesFormSaveAviSynthFilesDirectory, DirectoryPath = fsd.FileName });
                txtOutputDirectory.Text = fsd.FileName;
            }
        }

        private void bgwCreateAviSynthFiles_DoWork(object sender, DoWorkEventArgs e)
        {
            ErrorCollection errors = _avsService.CreateAVSFiles();
            e.Result = errors;
        }

        private void bgwCreateAviSynthFiles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ErrorCollection errors = e.Result as ErrorCollection;

            if (errors.Count() > 0)
            {
                MessageBox.Show(errors.GetErrorMessage(), "Errors Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("AVS Scripts have been created!", "Success.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            gbScreen.SetEnabled(true);
        }

        protected virtual void OnDialogInitialDirectoryChanged(object sender, DialogInitialDirectoryChangedEventArgs e)
        {
            EventHandler<DialogInitialDirectoryChangedEventArgs> handler = DialogInitialDirectoryChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
           openFileDialog.Filter = "BatchGuy File|*.batchGuyEac3toSettings";
            openFileDialog.FileName = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string settingsFile = openFileDialog.FileName;
                this.HandlesLoadToolStripMenuItemClick(settingsFile);
            }
        }

        private void HandlesLoadToolStripMenuItemClick(string settingsFile)
        {
            try
            {
                if (!string.IsNullOrEmpty(settingsFile))
                {
                    IJsonSerializationService<BatchGuyEAC3ToSettings> jsonSerializationService = new JsonSerializationService<BatchGuyEAC3ToSettings>();
                    IBatchGuyEAC3ToSettingsService batchGuyEAC3ToSettingsService = new BatchGuyEAC3ToSettingsService(jsonSerializationService);
                    _batchGuyEAC3ToSettings = batchGuyEAC3ToSettingsService.GetBatchGuyEAC3ToSettings(settingsFile);
                    if (batchGuyEAC3ToSettingsService.Errors.Count() > 0)
                    {
                        MessageBox.Show(batchGuyEAC3ToSettingsService.Errors.GetErrorMessage(), "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.LoadScreen();
                        gbScreen.SetEnabled(true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error trying to load the eac3to Settings File", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _log.ErrorFormat(Program.GetLogErrorFormat(), ex.Message, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void LoadScreen()
        {
            this.LoadEAC3ToSettingsControls();
            this.LoadMKVSettingsControls();
        }

        private void LoadEAC3ToSettingsControls()
        {
            if (_batchGuyEAC3ToSettings.EAC3ToSettings.OutputDirectoryType == EnumDirectoryType.DirectoryPerEpisode)
                lblDirectoryType.Text = "Directory Per Episode";
            else
                lblDirectoryType.Text = "Single Directory";
        }

        private void LoadMKVSettingsControls()
        {
            if (_batchGuyEAC3ToSettings.AVSBatchSettings == null)
                _batchGuyEAC3ToSettings.AVSBatchSettings = new AviSynthBatchSettings() { VideoFilter = "FFVideoSource" };

            _batchGuyEAC3ToSettings.AVSBatchSettings.VideoToEncodeDirectory = _batchGuyEAC3ToSettings.EAC3ToSettings.EAC3ToOutputPath;
            _batchGuyEAC3ToSettings.AVSBatchSettings.VideoToEncodeDirectoryType = _batchGuyEAC3ToSettings.EAC3ToSettings.OutputDirectoryType;
            txtMKVFilesDirectory.Text = _batchGuyEAC3ToSettings.AVSBatchSettings.VideoToEncodeDirectory;
            txtOutputDirectory.Text = _batchGuyEAC3ToSettings.AVSBatchSettings.AviSynthFilesOutputDirectoryPath;
            txtNumberOfFiles.Text = _batchGuyEAC3ToSettings.BluRayDiscs.NumberOfEpisodes().ToString();
            cbVideoFilter.SelectedIndex = cbVideoFilter.FindString(_batchGuyEAC3ToSettings.AVSBatchSettings.VideoFilter);

            if (_batchGuyEAC3ToSettings.AVSScript == null)
            {
                this.SetAviSynthTemplateTextBox();
                _batchGuyEAC3ToSettings.AVSScript = new AviSynthTemplateScript() { Script = txtAVSTemplate.Text };
            }
            else
            {
                txtAVSTemplate.Text = _batchGuyEAC3ToSettings.AVSScript.Script;
            }

        }

        private void CreateAviSynthFilesForm_DragEnter(object sender, DragEventArgs e)
        {
            this.HandlesCreateAviSynthFilesFormDragEnter(e);
        }

        private void HandlesCreateAviSynthFilesFormDragEnter(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void CreateAviSynthFilesForm_DragDrop(object sender, DragEventArgs e)
        {
            this.HandlesCreateAviSynthFilesFormDragDrop(e);
        }

        private void HandlesCreateAviSynthFilesFormDragDrop(DragEventArgs e)
        {
            foreach (string file in (Array)e.Data.GetData(DataFormats.FileDrop))
            {
                if (this.IsBatchGuyEac3toSettingsFile(file))
                {
                    this.HandlesLoadToolStripMenuItemClick(file);
                }
            }
        }

        private bool IsBatchGuyEac3toSettingsFile(string file)
        {
            if (file.EndsWith(_settingsExtension))
                return true;
            else
                return false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.HandlessaveToolStripMenuItemClick();
        }

        private void HandlessaveToolStripMenuItemClick()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "BatchGuy File|*.batchGuyEac3toSettings";
            sfd.Title = "Save eac3to Settings File";
            sfd.ShowDialog();

            if (!string.IsNullOrEmpty(sfd.FileName))
            {
                _batchGuyEAC3ToSettings.AVSBatchSettings = this.GetAVSBatchSettings();
                _batchGuyEAC3ToSettings.AVSScript = this.GetAVSScript();
                IJsonSerializationService<BatchGuyEAC3ToSettings> jsonSerializationService = new JsonSerializationService<BatchGuyEAC3ToSettings>();
                IBatchGuyEAC3ToSettingsService batchGuyEAC3ToSettingsService = new BatchGuyEAC3ToSettingsService(jsonSerializationService);
                batchGuyEAC3ToSettingsService.Save(sfd.FileName, _batchGuyEAC3ToSettings);
                if (batchGuyEAC3ToSettingsService.Errors.Count() > 0)
                {
                    MessageBox.Show(batchGuyEAC3ToSettingsService.Errors.GetErrorMessage(), "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

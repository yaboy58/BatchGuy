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

namespace BatchGuy.App
{
    public partial class CreateAviSynthFilesForm : Form
    {
        private IAviSynthFileService _fileService; //ioc
        private IAviSynthValidationService _validationService; //ioc
        private IAviSynthWriteService _avsService; //ioc

        public CreateAviSynthFilesForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.SetAviSynthTemplateTextBox();
            this.SetDirectoryUserControlValues();
            this.SetToolTips();
            txtNumberOfFiles.Focus();
        }

        private void CreateAVSFilesForm_Load(object sender, EventArgs e)
        {
#if DEBUG
            txtOutputDirectory.Text = @"C:\temp\My Encodes\Blu-ray";   
#endif
        }

        private void SetAviSynthTemplateTextBox()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Crop(0,0,0,0)");
            sb.AppendLine(string.Format("{0}Spline36Resize(1280,720)",Environment.NewLine));
            txtAVSTemplate.Text = sb.ToString();
        }

        private void SetDirectoryUserControlValues()
        {
            setDirectoryUserControl.ComboBoxCaptionText = "(.mkv) Files Directory";
            setDirectoryUserControl.LabelDirectoryCaptionText = @"Example: FFVideoSource(""{0}\e01\video01.mkv"")";
        }

        private void SetToolTips()
        {
            ttAviSynthOutputDirectory.SetToolTip(txtOutputDirectory, "Directory where AviSynth Files will be saved");
            ttNumberOfFiles.SetToolTip(txtNumberOfFiles, "Number of episodes");
            ttUserControl.SetToolTip(setDirectoryUserControl, "(.mkv) files directory for FFVideoSource");
        }

        private void btnCreateAVSFiles_Click(object sender, EventArgs e)
        {
            if (this.IsScreenValid())
            {
                gbScreen.SetEnabled(false);
                Process();                
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
                    VideoFilter = "FFVideoSource", //hardcoded for now
                      VideoToEncodeDirectory = setDirectoryUserControl.CLIDirectory,
                       VideoToEncodeDirectoryType = setDirectoryUserControl.OutputDirectoryType
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
            if (string.IsNullOrEmpty(setDirectoryUserControl.CLIDirectory))
            {
                MessageBox.Show("Please enter the directory where the videos to encode are located", "Invalid AviSynth Script.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            fsd.InitialDirectory = @"c:\";
            if (fsd.ShowDialog(IntPtr.Zero))
            {
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
                this.SetAviSynthTemplateTextBox();
                txtNumberOfFiles.Text = "";
                txtNumberOfFiles.Focus();
            }
            this.Close();
        }
    }
}

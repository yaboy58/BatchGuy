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
        private IFileService _fileService; //ioc
        private IValidationService _validationService; //ioc
        private IAVSService _avsService; //ioc

        public CreateAviSynthFilesForm()
        {
            InitializeComponent();
            txtNumberOfFiles.Focus();
        }

        private void CreateAVSFilesForm_Load(object sender, EventArgs e)
        {
            this.SetAVSTemplateTextBox();
#if DEBUG
            txtOutputDirectory.Text = @"C:\temp\My Encodes\Blu-ray";   
#endif

        }

        private void SetAVSTemplateTextBox()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Crop(0,0,0,0)");
            sb.AppendLine(string.Format("{0}Spline36Resize(1280,720)",Environment.NewLine));
            txtAVSTemplate.Text = sb.ToString();
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
            AVSBatchSettings avsBatchSettings = this.GetAVSBatchSettings();
            AVSTemplateScript avsTemplateScript = this.GetAVSScript();

            _fileService = new FileService(avsBatchSettings, avsTemplateScript);
            _validationService = new ValidationService(avsBatchSettings);
            _avsService = new AVSService(_fileService, _validationService, avsTemplateScript, avsBatchSettings);
            bgwCreateAviSynthFiles.RunWorkerAsync();

        }

        private AVSBatchSettings GetAVSBatchSettings()
        {
            return new AVSBatchSettings()
            {
                 BatchDirectoryPath = txtOutputDirectory.Text,
                  NamingConvention = "encode", //hardcoded for now
                   NumberOfFiles = Convert.ToInt32(txtNumberOfFiles.Text),
                    VideoFilter = "FFVideoSource" //hardcoded for now
            };
        }

        private AVSTemplateScript GetAVSScript()
        {
            return new AVSTemplateScript() { Script = txtAVSTemplate.Text };
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
                this.SetAVSTemplateTextBox();
                txtNumberOfFiles.Text = "";
                txtNumberOfFiles.Focus();
            }
            gbScreen.SetEnabled(true);
        }
    }
}

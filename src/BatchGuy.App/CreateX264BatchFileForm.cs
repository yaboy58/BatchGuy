using BatchGuy.App.Enums;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.X264.Interfaces;
using BatchGuy.App.X264.Models;
using BatchGuy.App.X264.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatchGuy.App.Extensions;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Shared.Services;
using BatchGuy.App.ThirdParty.FolderSelectDialog;
using BatchGuy.App.Settings.Models;

namespace BatchGuy.App
{
    public partial class CreateX264BatchFileForm : Form
    {
        private EnumEncodeType EncodeType { get; set; }
        private List<X264File> _x264Files;
        private SortConfiguration _filesGridSortConfiguration = new SortConfiguration();
        private BindingList<X264File> _bindingListFiles = new BindingList<X264File>();
        private string _vfw4x264Path = string.Empty;
        public CreateX264BatchFileForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.SetDirectoryUserControlValues();
            this.SetToolTips();
#if DEBUG
            txtAviSynthFilesDirectory.Text = @"C:\temp\My Encodes\Blu-ray";
#endif
        }

        private void CreateX264BatFileForm_Load(object sender, EventArgs e)
        {
            if (!this.IsVfw4x264PathSetInSettings())
            {
                MessageBox.Show("Please go to the settings screen and set the vfw4x264.exe path", "vfw4x264 path not set", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gbScreen.SetEnabled(false);
            }
            else
            {
                Setting setting = Program.ApplicationSettingsService.GetSettingByName("vfw4x264");
                _vfw4x264Path = setting.Path;
                this.SetComboBoxEncodeType();
            }
        }

        private void SetDirectoryUserControlValues()
        {
            setDirectoryUserControl.ComboBoxCaptionText = "--output && (.log) Directory";
            setDirectoryUserControl.LabelDirectoryCaptionText = @"Example: --output ""{0}\e01\encode_name.mkv"", ""{0}\e01\encode_name.log""";
        }

        private void SetToolTips()
        {
            ttAviSynthScriptsDirectory.SetToolTip(txtAviSynthFilesDirectory, "Directory where (.avs) files are located");
            ttX264BatchFileOutputDirectory.SetToolTip(txtX264BatchFileOutputDirectory, "Directory where the x264 batch file will be saved");
            ttDirectoryUserControl.SetToolTip(setDirectoryUserControl, "Determines where the x264 output and log file will be saved");
        }

        private bool IsVfw4x264PathSetInSettings()
        {
            Setting setting = Program.ApplicationSettingsService.GetSettingByName("vfw4x264");
            if (setting == null)
                return false;
            else
                return true;
        }

        private void SetComboBoxEncodeType()
        {
            this.cbEncodeType.SelectedIndex = 0;
        }

        private void cbEncodeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HandleEncodeType(cbEncodeType.Text);
        }

        private void SetX264TemplateTextBox()
        {
            StringBuilder sb = new StringBuilder();
            switch (this.EncodeType)
            {
                case EnumEncodeType.CRF:
                    sb.Append(string.Format("--crf 17 --level 4.1 --stats "));
                    sb.Append("\".stats\"");
                    sb.Append(" --preset veryslow --deblock -3:-3 --aq-strength 0.8 --psy-rd 1.00:0.00 --me tesa --merange 32 --subme 10 --no-mbtree --threads 12 --no-dct-decimate --no-fast-pskip");
                    break;
                case EnumEncodeType.TwoPass:
                    sb.Append("--bitrate 3000 --level 4.1 --stats ");
                    sb.Append("\".stats\"");
                    sb.Append(" --preset veryslow --deblock -3:-3 --aq-strength 0.8 --psy-rd 1.00:0.00 --me tesa --merange 32 --subme 10 --no-mbtree --threads 12 --no-dct-decimate --no-fast-pskip");
                    break;
                default:
                    throw new Exception("Invalid Encode Type");
            }

            txtX264Template.Text = sb.ToString();
        }

        private void HandleEncodeType(string value)
        {
            switch (value)
            {
                case "CRF":
                    this.EncodeType = EnumEncodeType.CRF;
                    break;
                case "2Pass":
                    this.EncodeType = EnumEncodeType.TwoPass;
                    break;
                default:
                    throw new Exception("Invalid Encode Type");
            }

            this.SetX264TemplateTextBox();
        }

        private void btnLoadAVSFiles_Click(object sender, EventArgs e)
        {
            if (this.IsScreenValidForLoadAviSynthFiles())
            {
                gbScreen.SetEnabled(false);
                this.LoadAVSFiles();                
            }
        }

        private X264FileSettings GetX264FileSettings()
        {
            return new X264FileSettings() { AviSynthFileFilter = "*.avs", AviSynthFilesPath = txtAviSynthFilesDirectory.Text, EncodeType = EncodeType,
             vfw4x264Exe = _vfw4x264Path, X264Template = txtX264Template.Text, X264BatchFileOutputPath = txtX264BatchFileOutputDirectory.Text,
             X264EncodeAndLogFileOutputDirectoryPathType = setDirectoryUserControl.OutputDirectoryType, X264EncodeAndLogFileOutputDirectoryPath = setDirectoryUserControl.CLIDirectory};
        }

        private void LoadAVSFiles()
        {
            X264FileSettings x264FileSettings = this.GetX264FileSettings();
            IX264FileService fileService = new X264FileService(x264FileSettings);
            bgwLoadAviSynthFiles.RunWorkerAsync(fileService);
        }

        private void btnCreateX264BatFile_Click(object sender, EventArgs e)
        {
            if (this.IsScreenValidForWriteX264BatchFile())
            {
                this.CreateX264BatFile();
            }
        }

        private void CreateX264BatFile()
        {
            gbScreen.SetEnabled(false);
            X264FileSettings x264Settings = this.GetX264FileSettings();
            IX264ValidationService validationService = new X264ValidationService(x264Settings, _x264Files);
            IX264EncodeService encodeService = new X264EncodeService(validationService, x264Settings, _x264Files);
            bgwCreateX264BatchFile.RunWorkerAsync(encodeService);
        }

        private void dgvFiles_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.HandleRowsRemoved();
        }

        private void HandleRowsRemoved()
        {
            List<X264File> files = new List<X264File>();
            foreach (X264File file in _bindingListFiles)
            {
                files.Add(file);
            }
            _x264Files = files;

            lblNumberOfFiles.Text = string.Format("Number of Files: {0}", _x264Files.Count());
            if (_x264Files.Count() == 0)
                btnCreateX264BatchFile.SetEnabled(false);
        }

        private void btnOpenAviSynthScriptOutputDialog_Click(object sender, EventArgs e)
        {
            this.HandleBtnOpenAviSynchScriptOutputDialogClick();
        }

        private void HandleBtnOpenAviSynchScriptOutputDialogClick()
        {
            var fsd = new FolderSelectDialog();
            fsd.Title = "Blu-ray folder directory";
            fsd.InitialDirectory = @"c:\";
            if (fsd.ShowDialog(IntPtr.Zero))
            {
                txtAviSynthFilesDirectory.Text = fsd.FileName;
            }
        }


        private void dgvFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                this.SortFilesGrid(e.ColumnIndex);
            }
            else
            {
                dgvFiles.Rows[e.RowIndex].Selected = true;
            }
        }

        private void bgwLoadAviSynthFiles_DoWork(object sender, DoWorkEventArgs e)
        {
            IX264FileService fileService = e.Argument as X264FileService;
            _x264Files = fileService.GetAVSFiles();
        }

        private void bgwLoadAviSynthFiles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_x264Files.Count() == 0)
            {
                btnCreateX264BatchFile.SetEnabled(false);
                MessageBox.Show("No AviSynth scripts found in directory!", "No Scripts Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                btnCreateX264BatchFile.SetEnabled(true);
                _bindingListFiles.Clear();
                foreach (X264File file in _x264Files)
                {
                    _bindingListFiles.Add(file);
                }
                bsFiles.DataSource = _bindingListFiles;
                bsFiles.ResetBindings(false);
                _bindingListFiles.AllowEdit = true;
            }
            gbScreen.SetEnabled(true);
        }

        private void bgwCreateX264BatchFile_DoWork(object sender, DoWorkEventArgs e)
        {
            IX264EncodeService encodeService = e.Argument as X264EncodeService;
            ErrorCollection errors = encodeService.CreateX264File();
            e.Result = errors;
        }

        private void bgwCreateX264BatchFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ErrorCollection errors = e.Result as ErrorCollection;
            if (errors.Count() == 0)
            {
                MessageBox.Show("The x264 batch file has been created!", "Success.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(errors.GetErrorMessage(), "Errors Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            gbScreen.SetEnabled(true);
        }

        private bool IsScreenValidForLoadAviSynthFiles()
        {
            if (string.IsNullOrEmpty(txtAviSynthFilesDirectory.Text))
            {
                MessageBox.Show("Please set the location of the AviSynth files directory", "AviSynth files directory not set", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private bool IsScreenValidForWriteX264BatchFile()
        {
            if (string.IsNullOrEmpty(txtAviSynthFilesDirectory.Text))
            {
                MessageBox.Show("Please set the location of the AviSynth files directory", "AviSynth files directory not set", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(txtX264BatchFileOutputDirectory.Text))
            {
                MessageBox.Show("Please set the x264 batch file output directory", "x264 batch file output directory not set", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (_x264Files == null || _x264Files.Count() == 0)
            {
                MessageBox.Show("Please load AviSynth scripts", "AviSynth Scripts Not Loaded", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(txtX264Template.Text))
            {
                MessageBox.Show("Please enter x264 settings", "Invalid x264 settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(setDirectoryUserControl.CLIDirectory))
            {
                MessageBox.Show("Please choose the x264 output and (.log) file save directory", "Invalid x264 settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;                
            }
            return true;
        }

        private void SortFilesGrid(int sortColumnNumber)
        {
            if (_x264Files.Count() == 0)
                return;

            string sortColumnName = dgvFiles.Columns[sortColumnNumber].DataPropertyName;
            _filesGridSortConfiguration.SortByColumnName = sortColumnName;
            ISortService<X264File> sortService = new SortService<X264File>(_filesGridSortConfiguration, _x264Files);

            IBindingListSortService<X264File> bindingListSortService = new BindingListSortService<X264File>(_x264Files, dgvFiles,
                _filesGridSortConfiguration, sortService);
            _bindingListFiles = bindingListSortService.Sort();

            this.BindFilesGrid();
        }

        private void BindFilesGrid()
        {
            bsFiles.DataSource = _bindingListFiles;
           bsFiles.ResetBindings(false);
          _bindingListFiles.AllowEdit = true;
        }

        private void btnOpenX264BatchFileOutputDialog_Click(object sender, EventArgs e)
        {
            this.HandleBtnOpenX264BatchFileOutputDialogClick();
        }

        private void HandleBtnOpenX264BatchFileOutputDialogClick()
        {
            var fsd = new FolderSelectDialog();
            fsd.Title = "Blu-ray folder directory";
            fsd.InitialDirectory = @"c:\";
            if (fsd.ShowDialog(IntPtr.Zero))
            {
               txtX264BatchFileOutputDirectory.Text = fsd.FileName;
            }
        }
    }
}

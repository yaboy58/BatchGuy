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

namespace BatchGuy.App
{
    public partial class CreateX264BatchFileForm : Form
    {
        private EnumEncodeType EncodeType { get; set; }
        private List<X264File> _x264Files;
        private SortConfiguration _filesGridSortConfiguration = new SortConfiguration();
        private BindingList<X264File> _bindingListFiles = new BindingList<X264File>();

        public CreateX264BatchFileForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
#if DEBUG
            txtAviSynthFileDirectory.Text = @"C:\temp\My Encodes\Blu-ray";
            txtVfw4x264exe.Text = @"C:\exe\vfw4x264\vfw4x264.exe";
#endif
        }

        private void CreateX264BatFileForm_Load(object sender, EventArgs e)
        {
            this.SetComboBoxEncodeType();
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
            gbScreen.SetEnabled(false);
            this.LoadAVSFiles();
        }

        private X264FileSettings GetX264FileSettings()
        {
            return new X264FileSettings() { AviSynthFileFilter = "*.avs", AviSynthFileOutputPath = txtAviSynthFileDirectory.Text, EncodeType = EncodeType,
             vfw4x264Exe = txtVfw4x264exe.Text, X264Template = txtX264Template.Text};
        }

        private void LoadAVSFiles()
        {
            X264FileSettings x264FileSettings = this.GetX264FileSettings();
            IFileService fileService = new FileService(x264FileSettings);
            bgwLoadAviSynthFiles.RunWorkerAsync(fileService);
        }

        private void btnCreateX264BatFile_Click(object sender, EventArgs e)
        {
            if (this.IsScreenValid())
            {
                this.CreateX264BatFile();
            }
        }

        private void CreateX264BatFile()
        {
            gbScreen.SetEnabled(false);
            X264FileSettings x264Settings = this.GetX264FileSettings();
            IValidationService validationService = new ValidationService(x264Settings, _x264Files);
            IEncodeService encodeService = new EncodeService(validationService, x264Settings, _x264Files);
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
                txtAviSynthFileDirectory.Text = fsd.FileName;
            }
        }

        private void btnOpenVfw4x264FileDialog_Click(object sender, EventArgs e)
        {
            this.HandleBtnOpenVfw4x264FileDialogClick();
        }

        private void HandleBtnOpenVfw4x264FileDialogClick()
        {
            ofdFileDialog.FileName = "";
            DialogResult result = ofdFileDialog.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
               txtVfw4x264exe.Text = ofdFileDialog.FileName;
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
            IFileService fileService = e.Argument as FileService;
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
            IEncodeService encodeService = e.Argument as EncodeService;
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

        private bool IsScreenValid()
        {
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
    }
}

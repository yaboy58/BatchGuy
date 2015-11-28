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
using System.IO;

namespace BatchGuy.App
{
    public partial class CreateX264BatchFileForm : Form
    {
        private EnumEncodeType EncodeType { get; set; }
        private SortConfiguration _filesGridSortConfiguration = new SortConfiguration();
        private BindingList<X264File> _bindingListFiles = new BindingList<X264File>();
        private string _vfw4x264Path = string.Empty;
        private string _logExtension = "avs";
        public CreateX264BatchFileForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.SetDirectoryUserControlValues();
            this.SetToolTips();
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
                _vfw4x264Path = setting.Value;
                this.SetComboBoxEncodeType();
                this.ConfigureDgvFilesGridColumns();
            }
        }

        private void ConfigureDgvFilesGridColumns()
        {
            dgvFiles.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void SetDirectoryUserControlValues()
        {
            setDirectoryUserControlX264Output.ComboBoxCaptionText = "--output and (.log) Directory";
            setDirectoryUserControlX264Output.LabelDirectoryCaptionText = @"Example: --output ""{0}\e01\encode_name.mkv"", ""{0}\e01\encode_name.log""";
        }

        private void SetToolTips()
        {
            new ToolTip().SetToolTip(txtX264BatchFileOutputDirectory, "Directory where the x264 batch file will be saved");
            new ToolTip().SetToolTip(setDirectoryUserControlX264Output, "Determines where the x264 output and log file will be saved");
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

        private X264FileSettings GetX264FileSettings()
        {
            X264FileSettings settings = new X264FileSettings() { EncodeType = EncodeType,
             vfw4x264Exe = _vfw4x264Path, X264Template = txtX264Template.Text.Trim(), X264BatchFilePath = txtX264BatchFileOutputDirectory.Text.Trim(),
             X264EncodeAndLogFileOutputDirectoryPathType = setDirectoryUserControlX264Output.OutputDirectoryType, X264EncodeAndLogFileOutputDirectoryPath = setDirectoryUserControlX264Output.CLIDirectory};

            settings.SaveX264LogFileToDifferentDirectory = chkSaveLogFileToDifferentDirectory.Checked;
            if (settings.SaveX264LogFileToDifferentDirectory)
                settings.X264LogFileOutputDirectoryPath = txtX264LogFileSaveDirectory.Text.Trim();

            return settings;
        }

        private void btnCreateX264BatFile_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Create x264 batch file?", "Start Process?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (this.IsScreenValidForWriteX264BatchFile())
                {
                    this.CreateX264BatFile();
                }
            }
        }

        private void CreateX264BatFile()
        {
            gbScreen.SetEnabled(false);
            X264FileSettings x264Settings = this.GetX264FileSettings();

            List<X264File> x264Files = this.GetX264Files();
            IX264ValidationService validationService = new X264ValidationService(x264Settings, x264Files);
            IX264EncodeService encodeService = new X264EncodeService(validationService, x264Settings, x264Files);
            bgwCreateX264BatchFile.RunWorkerAsync(encodeService);
        }

        private void dgvFiles_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.HandleRowsRemoved();
        }

        private void HandleRowsRemoved()
        {

            lblNumberOfFiles.Text = string.Format("Number of Files: {0}", _bindingListFiles.Count());
            if (_bindingListFiles.Count() == 0)
                btnCreateX264BatchFile.SetEnabled(false);
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

        private bool IsScreenValidForWriteX264BatchFile()
        {
            if (string.IsNullOrEmpty(txtX264BatchFileOutputDirectory.Text))
            {
                MessageBox.Show("Please set the x264 batch file output directory", "x264 batch file output directory not set", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (_bindingListFiles == null || _bindingListFiles.Count() == 0)
            {
                MessageBox.Show("Please load AviSynth scripts", "AviSynth Scripts Not Loaded", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(txtX264Template.Text))
            {
                MessageBox.Show("Please enter x264 settings", "Invalid x264 settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(setDirectoryUserControlX264Output.CLIDirectory))
            {
                MessageBox.Show("Please choose the x264 output and (.log) file save directory", "Invalid x264 settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;                
            }
            if (chkSaveLogFileToDifferentDirectory.Checked && string.IsNullOrEmpty(txtX264LogFileSaveDirectory.Text))
            {
                MessageBox.Show("Please choose the x264 (.log) file save directory", "Invalid x264 settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;                     
            }
            return true;
        }

        private void SortFilesGrid(int sortColumnNumber)
        {
            if (_bindingListFiles.Count() == 0)
                return;

            string sortColumnName = dgvFiles.Columns[sortColumnNumber].DataPropertyName;
            _filesGridSortConfiguration.SortByColumnName = sortColumnName;
            List<X264File> x264Files = this.GetX264Files();
            ISortService<X264File> sortService = new SortService<X264File>(_filesGridSortConfiguration, x264Files);

            IBindingListSortService<X264File> bindingListSortService = new BindingListSortService<X264File>(x264Files, dgvFiles,
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
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Batch File|*.bat";
            sfd.Title = "Save x264 Batch File";
            sfd.InitialDirectory = @"C:\temp";
#if DEBUG
            sfd.InitialDirectory = @"C:\temp\My BatchGuy Tests";
#endif
            sfd.ShowDialog();

            if (!string.IsNullOrEmpty(sfd.FileName))
            {
                using (FileStream fs = File.Create(sfd.FileName))
                {
                }
                txtX264BatchFileOutputDirectory.Text = sfd.FileName;
            }
        }

        private void dgvFiles_DragEnter(object sender, DragEventArgs e)
        {
            this.HandleDgvFilesDragEnter(e);
        }

        private void HandleDgvFilesDragEnter(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void dgvFiles_DragDrop(object sender, DragEventArgs e)
        {
            this.HandleDgvFilesDragDrop(e);
        }

        private void HandleDgvFilesDragDrop(DragEventArgs e)
        {
            foreach (string file in (Array)e.Data.GetData(DataFormats.FileDrop))
            {
                if (this.IsAviSynthFile(file) && this.NotADuplicate(file))
                {
                    _bindingListFiles.Add(new X264File() { AviSynthFileNameOnly = Path.GetFileName(file), AviSynthFilePath = file });
                }
            }
            if (_bindingListFiles.Count() > 0)
            {
                this.BindFilesGrid();
            }
        }

        private List<X264File> GetX264Files()
        {
            List<X264File> x264Files = new List<X264File>();
            foreach (X264File file in _bindingListFiles)
            {
                x264Files.Add(new X264File() { AviSynthFileNameOnly = file.AviSynthFileNameOnly, AviSynthFilePath = file.AviSynthFilePath, EncodeName = file.EncodeName, Id = file.Id });
            }
            return x264Files;
        }

        private bool IsAviSynthFile(string file)
        {
            if (file.EndsWith(_logExtension))
                return true;
            else
                return false;
        }

        private bool NotADuplicate(string file)
        {
            var t = Path.GetFileName(file);
            if (_bindingListFiles.Where(l => l.AviSynthFileNameOnly == Path.GetFileName(file)).Count() == 0)
                return true;
            else
                return false;
        }

        private void btnOpenX264LogFileOutputDialog_Click(object sender, EventArgs e)
        {
            this.HandleBtnOpenX264LogFileOutputDialog();
        }

        private void HandleBtnOpenX264LogFileOutputDialog()
        {
            var fsd = new FolderSelectDialog();
            fsd.Title = "x264 (.log) files save directory";
            fsd.InitialDirectory = @"c:\";
            if (fsd.ShowDialog(IntPtr.Zero))
            {
                txtX264LogFileSaveDirectory.Text = fsd.FileName;
            }
        }

        private void chkSaveLogFileToDifferentDirectory_CheckedChanged(object sender, EventArgs e)
        {
            this.HandleChkSaveLogFileToDifferentDirectoryCheckedChanged();
        }

        private void HandleChkSaveLogFileToDifferentDirectoryCheckedChanged()
        {
            txtX264LogFileSaveDirectory.SetEnabled(chkSaveLogFileToDifferentDirectory.Checked);
            btnOpenX264LogFileOutputDialog.SetEnabled(chkSaveLogFileToDifferentDirectory.Checked);
        }
    }
}

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
using System.IO;
using BatchGuy.App.Shared.Events;
using BatchGuy.App.Constants;
using BatchGuy.App.Eac3To.Models;
using BatchGuy.App.Shared.Interface;
using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Eac3To.Services;
using log4net;
using System.Reflection;
using BatchGuy.App.Eac3To.Abstracts;
using BatchGuy.App.MKVMerge.Interfaces;
using BatchGuy.App.MKVMerge.Services;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Helpers;

namespace BatchGuy.App
{
    public partial class CreateX264BatchFileForm : Form
    {
        public event EventHandler<DialogInitialDirectoryChangedEventArgs> DialogInitialDirectoryChanged;
        private EnumEncodeType EncodeType { get; set; }
        private SortConfiguration _filesGridSortConfiguration = new SortConfiguration();
        private BindingList<X264File> _bindingListFiles = new BindingList<X264File>();
        private string _vfw4x264Path = string.Empty;
        private string _avsExtension = "avs";
        private BindingList<DropDownListItem> _bindingListEpisodeNumbers = new BindingList<DropDownListItem>();
        private string _settingsExtension = "batchGuyEac3toSettings";
        private BatchGuyEAC3ToSettings _batchGuyEAC3ToSettings;
        private bool _encodeTypeChangedBecauseOfSettingsLoad;

        private IDisplayErrorMessageService _displayErrorMessageService = new DisplayErrorMessageService();

        public CreateX264BatchFileForm()
        {
            InitializeComponent();
            this.SetToolTips();
        }

        private void CreateX264BatFileForm_Load(object sender, EventArgs e)
        {
            try
            {
                lblVersion.Text = Program.GetApplicationVersion();

                gbScreen.SetEnabled(false);
                if (!this.IsVfw4x264PathSetInSettings())
                {
                    MessageBox.Show("Please go to the settings screen and set the vfw4x264.exe path", "vfw4x264 path not set", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Setting setting = Program.ApplicationSettingsService.GetSettingByName("vfw4x264");
                    _vfw4x264Path = setting.Value;
                    this.ConfigureDgvFilesGridColumns();
                }
            }
            catch (Exception ex)
            {
                _displayErrorMessageService.DisplayError(new ErrorMessage() { DisplayMessage = "There was a problem trying to load the screen!", DisplayTitle = "Error.", Exception = ex, MethodNameWhereExceptionOccurred = MethodBase.GetCurrentMethod().Name });
            }
        }

        private void ConfigureDgvFilesGridColumns()
        {
            dgvFiles.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void SetToolTips()
        {
            new ToolTip().SetToolTip(txtX264BatchFileOutputDirectory, "Directory where the x264 batch file will be saved");
        }

        private bool IsVfw4x264PathSetInSettings()
        {
            Setting setting = Program.ApplicationSettingsService.GetSettingByName("vfw4x264");
            if (setting == null || string.IsNullOrEmpty(setting.Value))
                return false;
            else
                return true;
        }

        private void cbEncodeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.HandleEncodeType(cbEncodeType.Text);
            }
            catch (Exception ex)
            {
                _displayErrorMessageService.DisplayError(new ErrorMessage() { DisplayMessage = "There was a problem trying to select an encode type!", DisplayTitle = "Error.", Exception = ex, MethodNameWhereExceptionOccurred = MethodBase.GetCurrentMethod().Name });
            }
        }

        private void SetX264TemplateTextBox()
        {
            if (this._encodeTypeChangedBecauseOfSettingsLoad)
            {
                this._encodeTypeChangedBecauseOfSettingsLoad = false;
                return;
            }

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

        private string GetDefaultX264CRFSettings()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("--crf 17 --level 4.1 --stats "));
            sb.Append("\".stats\"");
            sb.Append(" --preset veryslow --deblock -3:-3 --aq-strength 0.8 --psy-rd 1.00:0.00 --me tesa --merange 32 --subme 10 --no-mbtree --threads 12 --no-dct-decimate --no-fast-pskip");
            return sb.ToString();
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
            X264FileSettings settings = new X264FileSettings()
            {
                EncodeType = EncodeType,
                vfw4x264Exe = _vfw4x264Path,
                X264Template = txtX264Template.Text.Trim(),
                X264BatchFilePath = txtX264BatchFileOutputDirectory.Text.Trim(),
                X264EncodeAndLogFileOutputDirectoryPathType = _batchGuyEAC3ToSettings.X264FileSettings.X264EncodeAndLogFileOutputDirectoryPathType,
                X264EncodeAndLogFileOutputDirectoryPath = _batchGuyEAC3ToSettings.X264FileSettings.X264EncodeAndLogFileOutputDirectoryPath
            };

            settings.SaveX264LogFileToDifferentDirectory = chkSaveLogFileToDifferentDirectory.Checked;
            if (settings.SaveX264LogFileToDifferentDirectory)
                settings.X264LogFileOutputDirectoryPath = txtX264LogFileSaveDirectory.Text.Trim();

            return settings;
        }

        private void CreateX264BatFile()
        {
            gbScreen.SetEnabled(false);
            _batchGuyEAC3ToSettings.X264Files = this.GetX264Files();
            _batchGuyEAC3ToSettings.X264FileSettings = this.GetX264FileSettings();

            IX264ValidationService validationService = new X264ValidationService(_batchGuyEAC3ToSettings.X264FileSettings, _batchGuyEAC3ToSettings.X264Files);
            IX264EncodeService encodeService = new X264EncodeService(validationService, _batchGuyEAC3ToSettings.X264FileSettings, _batchGuyEAC3ToSettings.X264Files);
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
            {
                createX264BatchFileToolStripMenuItem.Enabled = false;
                createMkvmergeBatchFileToolStripMenuItem.Enabled = false;
            }
        }


        private void dgvFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                _displayErrorMessageService.DisplayError(new ErrorMessage() { DisplayMessage = "There was an error trying to select the item on the grid!", DisplayTitle = "Error.", Exception = ex, MethodNameWhereExceptionOccurred = MethodBase.GetCurrentMethod().Name });
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
            if (chkSaveLogFileToDifferentDirectory.Checked && string.IsNullOrEmpty(txtX264LogFileSaveDirectory.Text))
            {
                MessageBox.Show("Please choose the x264 (.log) file save directory", "Invalid x264 settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (_batchGuyEAC3ToSettings.BluRayDiscs.NumberOfEpisodes() != _batchGuyEAC3ToSettings.X264Files.Count())
            {
                MessageBox.Show("The number of selected episodes on the Create eac3to Batch File does not match the number of AviSynth files.", "Invalid number of AviSynth files", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            try
            {
                this.HandleBtnOpenX264BatchFileOutputDialogClick();
            }
            catch (Exception ex)
            {
                _displayErrorMessageService.DisplayError(new ErrorMessage() { DisplayMessage = "There was a problem opening up the file path!", DisplayTitle = "Error.", Exception = ex, MethodNameWhereExceptionOccurred = MethodBase.GetCurrentMethod().Name });
            }
        }

        private void HandleBtnOpenX264BatchFileOutputDialogClick()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            Setting setting = Program.ApplicationSettingsService.GetSettingByName(Constant.FeatureCreateX264BatchFileFormSaveX264BatchFileDirectory);
            if (setting != null)
                sfd.InitialDirectory = setting.Value;
            else
                sfd.InitialDirectory = @"C:\";

            sfd.Filter = "Batch File|*.bat";
            sfd.Title = "Save x264 Batch File";
            sfd.ShowDialog();

            if (!string.IsNullOrEmpty(sfd.FileName))
            {
                using (FileStream fs = File.Create(sfd.FileName))
                {
                }
                OnDialogInitialDirectoryChanged(this, new DialogInitialDirectoryChangedEventArgs() { FeatureName = Constant.FeatureCreateX264BatchFileFormSaveX264BatchFileDirectory, DirectoryPath = Path.GetDirectoryName(sfd.FileName) });
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
                    _bindingListFiles.Add(new X264File() { AviSynthFileNameOnly = Path.GetFileName(file), AviSynthFilePath = file, EncodeName = string.Empty });
                }
            }
            if (_bindingListFiles.Count() > 0)
            {
                this.BindFilesGrid();
                _filesGridSortConfiguration.SortDirection = 0;
                this.SortFilesGrid(1);
                createMkvmergeBatchFileToolStripMenuItem.Enabled = true;
                createX264BatchFileToolStripMenuItem.Enabled = true;
            }
            lblNumberOfFiles.Text = string.Format("Number of Files: {0}", _bindingListFiles.Count());
        }

        private List<X264File> GetX264Files()
        {
            List<X264File> x264Files = new List<X264File>();
            foreach (X264File file in _bindingListFiles)
            {
                x264Files.Add(new X264File()
                {
                    AviSynthFileNameOnly = file.AviSynthFileNameOnly,
                    AviSynthFilePath = file.AviSynthFilePath,
                    EncodeName = file.EncodeName.Trim(),
                    Id = file.Id,
                    EpisodeNumber = file.EpisodeNumber
                });
            }
            return x264Files;
        }

        private bool IsAviSynthFile(string file)
        {
            if (file.EndsWith(_avsExtension))
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
            try
            {
                this.HandleBtnOpenX264LogFileOutputDialog();
            }
            catch (Exception ex)
            {
                _displayErrorMessageService.DisplayError(new ErrorMessage() { DisplayMessage = "There was a problem opening up the file path!", DisplayTitle = "Error.", Exception = ex, MethodNameWhereExceptionOccurred = MethodBase.GetCurrentMethod().Name });
            }
        }

        private void HandleBtnOpenX264LogFileOutputDialog()
        {
            var fsd = new FolderSelectDialog();
            fsd.Title = "x264 (.log) files save directory";
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

        protected virtual void OnDialogInitialDirectoryChanged(object sender, DialogInitialDirectoryChangedEventArgs e)
        {
            EventHandler<DialogInitialDirectoryChangedEventArgs> handler = DialogInitialDirectoryChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void LoadEpisodeNumbers()
        {
            if (_batchGuyEAC3ToSettings.BluRayDiscs == null || _batchGuyEAC3ToSettings.BluRayDiscs.NumberOfEpisodes() == 0)
                return;

            foreach (BluRayDiscInfo disc in _batchGuyEAC3ToSettings.BluRayDiscs.Where(d => d.IsSelected))
            {
                if (disc.BluRaySummaryInfoList != null)
                {
                    foreach (BluRaySummaryInfo summary in disc.BluRaySummaryInfoList.Where(s => s.IsSelected && s.EpisodeNumber != null).OrderBy(s => s.EpisodeNumber))
                    {
                        _bindingListEpisodeNumbers.Add(new DropDownListItem() { DisplayMember = summary.EpisodeNumber.ToString(), ValueMember = summary.EpisodeNumber.ToString() });
                    }
                }
            }
            bsEpisodeNumbersDropDownListItem.DataSource = _bindingListEpisodeNumbers;
            _bindingListEpisodeNumbers.AllowEdit = false;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ofdFileDialog.Filter = "BatchGuy File|*.batchGuyEac3toSettings";
                ofdFileDialog.FileName = "";
                if (ofdFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string settingsFile = ofdFileDialog.FileName;
                    this.HandlesLoadToolStripMenuItemClick(settingsFile);
                }
            }
            catch (Exception ex)
            {
                _displayErrorMessageService.DisplayError(new ErrorMessage() { DisplayMessage = "There was a problem trying to load the file!", DisplayTitle = "Error.", Exception = ex, MethodNameWhereExceptionOccurred = MethodBase.GetCurrentMethod().Name });
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
                    else if (_batchGuyEAC3ToSettings.EAC3ToSettings.IsExtractForRemux)
                    {
                        MessageBox.Show("You cannot load a (.batchGuyEac3toSettings) file that is for Remuxing!", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this._encodeTypeChangedBecauseOfSettingsLoad = true;
                        this.LoadEpisodeNumbers();
                        this.LoadScreen();
                        gbScreen.SetEnabled(true);
                        saveToolStripMenuItem.Enabled = true;
                        createX264BatchFileToolStripMenuItem.Enabled = true;
                        createMkvmergeBatchFileToolStripMenuItem.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                _displayErrorMessageService.DisplayError(new ErrorMessage() { DisplayMessage = "There was an error trying to load the eac3to Settings File!", DisplayTitle = "Error.", Exception = ex, MethodNameWhereExceptionOccurred = MethodBase.GetCurrentMethod().Name });
            }
        }

        private void LoadScreen()
        {
            this.LoadEAC3ToSettingsControls();
            this.LoadX264SettingsControls();
            this.LoadX264Files();
        }

        private void LoadEAC3ToSettingsControls()
        {
            if (_batchGuyEAC3ToSettings.EAC3ToSettings.OutputDirectoryType == EnumDirectoryType.DirectoryPerEpisode)
                lblDirectoryType.Text = "Directory Per Episode";
            else
                lblDirectoryType.Text = "Single Directory";
        }

        private void LoadX264SettingsControls()
        {
            if (_batchGuyEAC3ToSettings.X264FileSettings == null)
                _batchGuyEAC3ToSettings.X264FileSettings = new X264FileSettings() { EncodeType = EnumEncodeType.CRF, X264Template = this.GetDefaultX264CRFSettings() };

            if (_batchGuyEAC3ToSettings.X264Files == null)
                _batchGuyEAC3ToSettings.X264Files = new List<X264File>();


            _batchGuyEAC3ToSettings.X264FileSettings.X264EncodeAndLogFileOutputDirectoryPath = _batchGuyEAC3ToSettings.EAC3ToSettings.EAC3ToOutputPath;
            _batchGuyEAC3ToSettings.X264FileSettings.X264EncodeAndLogFileOutputDirectoryPathType = _batchGuyEAC3ToSettings.EAC3ToSettings.OutputDirectoryType;
            txtX264EncodeOutputAndLogDirectory.Text = _batchGuyEAC3ToSettings.X264FileSettings.X264EncodeAndLogFileOutputDirectoryPath;
            txtX264BatchFileOutputDirectory.Text = _batchGuyEAC3ToSettings.X264FileSettings.X264BatchFilePath;
            chkSaveLogFileToDifferentDirectory.Checked = _batchGuyEAC3ToSettings.X264FileSettings.SaveX264LogFileToDifferentDirectory;
            txtX264LogFileSaveDirectory.Text = _batchGuyEAC3ToSettings.X264FileSettings.X264LogFileOutputDirectoryPath;
            txtX264Template.Text = _batchGuyEAC3ToSettings.X264FileSettings.X264Template;
            chkIgnoreInternalSubtitles.Checked = _batchGuyEAC3ToSettings.EAC3ToSettings.IgnoreInternalSubtitles;

            if (_batchGuyEAC3ToSettings.X264FileSettings.EncodeType == EnumEncodeType.TwoPass)
                cbEncodeType.SelectedIndex = 1;
            else
                cbEncodeType.SelectedIndex = 0;
        }

        private void LoadX264Files()
        {
            _bindingListFiles.Clear();
            foreach (X264File file in _batchGuyEAC3ToSettings.X264Files)
            {
                _bindingListFiles.Add(new X264File()
                {
                    AviSynthFileNameOnly = file.AviSynthFileNameOnly,
                    AviSynthFilePath = file.AviSynthFilePath,
                    EncodeName = file.EncodeName,
                    EpisodeNumber = file.EpisodeNumber,
                    Id = file.Id
                });
            }
            if (_bindingListFiles.Count() > 0)
            {
                this.BindFilesGrid();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.HandlesSaveToolStripMenuItemClick();
            }
            catch (Exception ex)
            {
                _displayErrorMessageService.DisplayError(new ErrorMessage() { DisplayMessage = "There was a problem trying to save the file!", DisplayTitle = "Error.", Exception = ex, MethodNameWhereExceptionOccurred = MethodBase.GetCurrentMethod().Name });
            }
        }

        private void HandlesSaveToolStripMenuItemClick()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "BatchGuy File|*.batchGuyEac3toSettings";
            sfd.Title = "Save eac3to Settings File";
            sfd.ShowDialog();

            if (!string.IsNullOrEmpty(sfd.FileName))
            {
                dgvFiles.CurrentCell = null; //force the cell change so cell changed event fires
                _batchGuyEAC3ToSettings.X264Files = this.GetX264Files();
                _batchGuyEAC3ToSettings.X264FileSettings = this.GetX264FileSettings();
                IJsonSerializationService<BatchGuyEAC3ToSettings> jsonSerializationService = new JsonSerializationService<BatchGuyEAC3ToSettings>();
                IBatchGuyEAC3ToSettingsService batchGuyEAC3ToSettingsService = new BatchGuyEAC3ToSettingsService(jsonSerializationService);
                batchGuyEAC3ToSettingsService.Save(sfd.FileName, _batchGuyEAC3ToSettings);
                if (batchGuyEAC3ToSettingsService.Errors.Count() > 0)
                {
                    MessageBox.Show(batchGuyEAC3ToSettingsService.Errors.GetErrorMessage(), "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CreateX264BatchFileForm_DragEnter(object sender, DragEventArgs e)
        {
            this.HandlesCreateX264BatchFileFormDragEnter(e);
        }

        private void HandlesCreateX264BatchFileFormDragEnter(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void CreateX264BatchFileForm_DragDrop(object sender, DragEventArgs e)
        {
            this.HandlesCreateX264BatchFileFormDragDrop(e);
        }

        private void HandlesCreateX264BatchFileFormDragDrop(DragEventArgs e)
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

        private void HandlesMenuItemWriteToMKVMergeBatFileClick()
        {
            DialogResult startProcessResult = MessageBox.Show("Create mkvmerge batch file?", "Start Process?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            _batchGuyEAC3ToSettings.X264Files = this.GetX264Files();
            _batchGuyEAC3ToSettings.X264FileSettings = this.GetX264FileSettings();
            this.SetEpisodeNames();

            if (startProcessResult == System.Windows.Forms.DialogResult.Yes)
            {
                if (this.IsScreenValidForWriteX264BatchFile() && this.IsScreenValidForMkvMerge())
                {
                    WarningCollection warnings = new EAC3ToBatchFileWriteWarningService(_batchGuyEAC3ToSettings.BluRayDiscs).GetWarnings();
                    this.MKVMergeWarnings(warnings);
                    if (warnings.Count() > 0)
                    {
                        string warning = string.Format("{0}{1}{2}Would you still like to continue?", warnings.GetWarningMessage(), Environment.NewLine, Environment.NewLine);
                        DialogResult warningResult = MessageBox.Show(warning, "Warnings Found", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (warningResult == System.Windows.Forms.DialogResult.Yes)
                        {
                            this.WriteToMkvMergeBatchFile();
                        }
                    }
                    else
                    {
                        this.WriteToMkvMergeBatchFile();
                    }
                }
            }
        }

        private void SetEpisodeNames()
        {
            if (_bindingListFiles.Count() > 0)
            {
                foreach (X264File file in _batchGuyEAC3ToSettings.X264Files.Where(f => f.EpisodeNumber != null && f.EpisodeNumber != string.Empty).OrderBy(f => f.AviSynthFileNameOnly))
                {
                    if (_batchGuyEAC3ToSettings.BluRayDiscs != null)
                    {
                        foreach (BluRayDiscInfo disc in _batchGuyEAC3ToSettings.BluRayDiscs.Where(d => d.IsSelected))
                        {
                            if (disc.BluRaySummaryInfoList != null)
                            {
                                foreach (BluRaySummaryInfo summary in disc.BluRaySummaryInfoList)
                                {
                                    if (summary.IsSelected && summary.EpisodeNumber != null && summary.BluRayTitleInfo != null)
                                    {
                                        if (file.EpisodeNumber.StringToNullInt() == summary.EpisodeNumber)
                                        {
                                            if (_batchGuyEAC3ToSettings.EAC3ToSettings.OutputDirectoryType == EnumDirectoryType.DirectoryPerEpisode)
                                            {
                                                string episodeFolderName = HelperFunctions.PadNumberWithZeros(_batchGuyEAC3ToSettings.X264Files.Count(), file.EpisodeNumber.StringToInt());
                                                summary.BluRayTitleInfo.EpisodeName = string.Format("{0}\\e{1}\\{2}", _batchGuyEAC3ToSettings.EAC3ToSettings.EAC3ToOutputPath, episodeFolderName, file.EncodeName);
                                            }
                                            else
                                            {
                                                summary.BluRayTitleInfo.EpisodeName = string.Format("{0}\\{1}", _batchGuyEAC3ToSettings.EAC3ToSettings.EAC3ToOutputPath, file.EncodeName);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ClearEpisodeNames()
        {
            if (_bindingListFiles.Count() > 0)
            {
                foreach (X264File file in _batchGuyEAC3ToSettings.X264Files.Where(f => f.EpisodeNumber != null && f.EpisodeNumber != string.Empty).OrderBy(f => f.AviSynthFileNameOnly))
                {
                    if (_batchGuyEAC3ToSettings.BluRayDiscs != null)
                    {
                        foreach (BluRayDiscInfo disc in _batchGuyEAC3ToSettings.BluRayDiscs.Where(d => d.IsSelected))
                        {
                            if (disc.BluRaySummaryInfoList != null)
                            {
                                foreach (BluRaySummaryInfo summary in disc.BluRaySummaryInfoList)
                                {
                                    if (summary.IsSelected && summary.EpisodeNumber != null && summary.BluRayTitleInfo != null)
                                    {
                                        if (file.EpisodeNumber.StringToNullInt() == summary.EpisodeNumber)
                                        {
                                            summary.BluRayTitleInfo.EpisodeName = string.Empty;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void WriteToMkvMergeBatchFile()
        {
            _batchGuyEAC3ToSettings.EAC3ToSettings.IsVideoNameForEncodeMkvMerge = true;
            gbScreen.SetEnabled(false);
            IDirectorySystemService directorySystemService = new DirectorySystemService();
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService eac3ToOutputNamingService = new EncodeTemplate1EAC3ToOutputNamingService(audioService);
            IEAC3ToCommonRulesValidatorService eac3ToCommonRulesValidatorService = new EAC3ToCommonRulesValidatorService(_batchGuyEAC3ToSettings.EAC3ToSettings, directorySystemService, _batchGuyEAC3ToSettings.BluRayDiscs);
            IMKVMergeBatchFileWriteService batchFileWriteService = new MKVMergeBatchFileWriteForEncodeService(_batchGuyEAC3ToSettings, directorySystemService, audioService, eac3ToOutputNamingService, eac3ToCommonRulesValidatorService);
            bgwMkvMergeWriteBatchFile.RunWorkerAsync(batchFileWriteService);
        }

        private void bgwMkvMergeWriteBatchFile_DoWork(object sender, DoWorkEventArgs e)
        {
            IMKVMergeBatchFileWriteService batchFileWriteService = e.Argument as MKVMergeBatchFileWriteForEncodeService;
            batchFileWriteService.Write();
            e.Result = batchFileWriteService;
        }

        private void bgwMkvMergeWriteBatchFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            IMKVMergeBatchFileWriteService batchFileWriteService = e.Result as MKVMergeBatchFileWriteForEncodeService;
            if (batchFileWriteService.Errors.Count() == 0)
            {
                MessageBox.Show("Batch File created!", "Process Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(string.Format("Error: {0}", batchFileWriteService.Errors[0].Description), "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.ClearEpisodeNames();
            gbScreen.SetEnabled(true);
        }

        private void MKVMergeWarnings(WarningCollection warnings)
        {
            if (_batchGuyEAC3ToSettings.EAC3ToSettings.EAC3ToOutputPath == _batchGuyEAC3ToSettings.EAC3ToSettings.MKVMergeOutputPath)
            {
                warnings.Add(new Warning() { Id = 0, Description = "The eac3to output path is the same as mkvmerge output path and could have output file name conflicts!" });
            }
        }

        private bool IsScreenValidForMkvMerge()
        {
            if (IsMkvMergePathSetInSettings() != true)
            {
                MessageBox.Show("Please go to settings and set the mkvmerge.exe path", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_batchGuyEAC3ToSettings.EAC3ToSettings.MKVMergeBatchFilePath == null || _batchGuyEAC3ToSettings.EAC3ToSettings.MKVMergeBatchFilePath == string.Empty)
            {
                MessageBox.Show("Please go to the Create eac3to Batch File Screen and choose an mkvmerge batch file!", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_batchGuyEAC3ToSettings.EAC3ToSettings.MKVMergeOutputPath == null || _batchGuyEAC3ToSettings.EAC3ToSettings.MKVMergeOutputPath == string.Empty)
            {
                MessageBox.Show("Please Please go to the Create eac3to Batch File Screen and choose an mkvmerge output path!", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool IsMkvMergePathSetInSettings()
        {
            Setting setting = Program.ApplicationSettingsService.GetSettingByName("mkvmerge");
            if (setting == null || string.IsNullOrEmpty(setting.Value))
                return false;
            else
                return true;
        }

        private void dgvFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1 || e.ColumnIndex == 4) //header row or episode number drop down
                    return;
                this.HandlesdgvFilesCellDoubleClick(e);
            }
            catch (Exception ex)
            {
                _displayErrorMessageService.DisplayError(new ErrorMessage() { DisplayMessage = "There was an error trying to open the external subtitle screen!", DisplayTitle = "Error.", Exception = ex, MethodNameWhereExceptionOccurred = MethodBase.GetCurrentMethod().Name });
            }
        }

        private void HandlesdgvFilesCellDoubleClick(DataGridViewCellEventArgs e)
        {
            var id = dgvFiles.Rows[e.RowIndex].Cells[4].Value;
            if (_batchGuyEAC3ToSettings.BluRayDiscs == null)
                return;
            if (id == null)
                return;

            BluRaySummaryInfo summaryInfo = _batchGuyEAC3ToSettings.BluRayDiscs.GetEpisodeByEpisodeNumber(id.ToString());
            if (summaryInfo == null)
                return;

            BluRayDiscInfo discInfo = null;
            foreach (BluRayDiscInfo disc in _batchGuyEAC3ToSettings.BluRayDiscs.Where(d => d.IsSelected))
            {
                if (disc.BluRaySummaryInfoList != null)
                {
                    if (disc.BluRaySummaryInfoList.Where(s => s == summaryInfo).Count() == 1)
                    {
                        discInfo = disc;
                    }
                }
            }
            if (discInfo == null)
                return;

            BluRayTitleInfoForm form = new BluRayTitleInfoForm();
            form.SetBluRayTitleInfo(_batchGuyEAC3ToSettings.EAC3ToSettings, discInfo.BluRayPath, summaryInfo);
            form.IsCallingScreenCreateX264BatchFile = true;
            form.ShowDialog();
        }

        private void chkIgnoreInternalSubtitles_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.HandleschkIgnoreInternalSubtitlesCheckedChanged();
            }
            catch (Exception ex)
            {
                _displayErrorMessageService.DisplayError(new ErrorMessage() { DisplayMessage = "There was an error trying to set the ignore internal subtitles flag!", DisplayTitle = "Error.", Exception = ex, MethodNameWhereExceptionOccurred = MethodBase.GetCurrentMethod().Name });
            }
        }

        private void HandleschkIgnoreInternalSubtitlesCheckedChanged()
        {
            _batchGuyEAC3ToSettings.EAC3ToSettings.IgnoreInternalSubtitles = chkIgnoreInternalSubtitles.Checked;
        }

        private void createX264BatchFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Create x264 batch file?", "Start Process?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    _batchGuyEAC3ToSettings.X264Files = this.GetX264Files();
                    _batchGuyEAC3ToSettings.X264FileSettings = this.GetX264FileSettings();

                    if (this.IsScreenValidForWriteX264BatchFile())
                    {
                        this.CreateX264BatFile();
                    }
                }
            }
            catch (Exception ex)
            {
                _displayErrorMessageService.DisplayError(new ErrorMessage() { DisplayMessage = "There was a problem trying to create the x264 batch file!", DisplayTitle = "Error.", Exception = ex, MethodNameWhereExceptionOccurred = MethodBase.GetCurrentMethod().Name });
            }
        }

        private void createMkvmergeBatchFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.HandlesMenuItemWriteToMKVMergeBatFileClick();
            }
            catch (Exception ex)
            {
                _displayErrorMessageService.DisplayError(new ErrorMessage() { DisplayMessage = "There was a problem trying to create the mkvmerge batch file!", DisplayTitle = "Error.", Exception = ex, MethodNameWhereExceptionOccurred = MethodBase.GetCurrentMethod().Name });
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Eac3to.Services;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Parser.Services;
using BatchGuy.App.Eac3to.Interfaces;
using BatchGuy.App.Parser.Interfaces;
using BatchGuy.App.Enums;
using BatchGuy.App.Helpers;
using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Extensions;
using System.Linq.Dynamic;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Shared.Services;
using BatchGuy.App.ThirdParty.FolderSelectDialog;
using System.IO;
using BatchGuy.App.Eac3To.Models;
using BatchGuy.App.Shared.Events;
using BatchGuy.App.Constants;
using BatchGuy.App.Eac3To.Services;
using BatchGuy.App.Shared.Interface;
using log4net;
using System.Reflection;
using BatchGuy.App.MKVMerge.Interfaces;
using BatchGuy.App.MKVMerge.Services;

namespace BatchGuy.App
{
    public partial class CreateEAC3ToBatchForm : Form
    {
        public event EventHandler<DialogInitialDirectoryChangedEventArgs> DialogInitialDirectoryChanged;

        private BluRayDiscInfo _currentBluRayDiscInfo;
        private CommandLineProcessStartInfo _commandLineProcessStartInfo;
        private BindingList<BluRayDiscInfo> _bindingListBluRayDiscInfo = new BindingList<BluRayDiscInfo>();
        private BindingList<BluRaySummaryInfo> _bindingListBluRaySummaryInfo;
        private int _currentBluRayDiscGridRowIndex;
        private SortConfiguration _bluRaySummaryGridSortConfiguration = new SortConfiguration();
        private SortConfiguration _bluRayDiscGridSortConfiguration = new SortConfiguration();
        private string _eac3ToPath = string.Empty;
        private EAC3ToConfiguration _eac3toConfiguration = new EAC3ToConfiguration() { RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate() };
        private string _settingsExtension = "batchGuyEac3toSettings";
        private string _mkvMergePath = string.Empty;

        public static readonly ILog _log = LogManager.GetLogger(typeof(CreateEAC3ToBatchForm));

        public CreateEAC3ToBatchForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            setDirectoryUserControl.ComboBoxCaptionText = "eac3to output directory*:";
            setDirectoryUserControl.LabelDirectoryCaptionText = @"eac3to Output Directory (example: e01, e02): {0}\e##";
            this.SetToolTips();
        }

        private void CreateEAC3ToBatchForm_Load(object sender, EventArgs e)
        {
            if (!this.IsEac3ToPathSetInSettings())
            {
                MessageBox.Show("Please go to the settings screen and set the eac3to.exe path", "eac3to path not set", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gbScreen.SetEnabled(false);
            }
            else
            {
                Setting setting = Program.ApplicationSettingsService.GetSettingByName("eac3to");
                _eac3ToPath = setting.Value;
                this.SetEac3ToConfiguration();
                cbRemuxVideoResolution.SelectedIndex = 3;
                cbRemuxMedium.SelectedIndex = 1;
                cbRemuxVideoFormat.SelectedIndex = 1;
                this.SetBtnCreateMKVMergeBatFileEnabledStatus();
            }
        }

        private void SetToolTips()
        {
            new ToolTip().SetToolTip(txtBatFilePath, "Directory where eac3to batch file will be saved");
            new ToolTip().SetToolTip(setDirectoryUserControl, "eac3to stream extract directory");
            new ToolTip().SetToolTip(txtRemuxSeriesName,"Series name");
            new ToolTip().SetToolTip(txtRemuxSeasonNumber, "Season number");
            new ToolTip().SetToolTip(txtRemuxSeasonYear, "Season year");
            new ToolTip().SetToolTip(cbRemuxVideoResolution, "Video resolution");
            new ToolTip().SetToolTip(txtRemuxAudioType, "Audio type i.e. FLAC 7.1");
            new ToolTip().SetToolTip(txtRemuxTag, "Tag to place at the end of each file i.e. BGuy");
            new ToolTip().SetToolTip(chkExtractForRemux, "Extract for Remux");
            new ToolTip().SetToolTip(txtMKVMergeBatFilePath, "Directory where mkvmerge batch file will be saved");
            new ToolTip().SetToolTip(txtMKVMergeOutputPath, "mkvmerge output directory");
            new ToolTip().SetToolTip(btnOpenMKVMergeFilePathDialog, "Directory where mkvmerge batch file will be saved");
            new ToolTip().SetToolTip(btnOpenMKVMergeOutputPathDialog, "mkvmerge output directory");
        }

        private bool IsEac3ToPathSetInSettings()
        {
            Setting setting = Program.ApplicationSettingsService.GetSettingByName("eac3to");
            if (setting == null  || string.IsNullOrEmpty(setting.Value))
                return false;
            else
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

        private void btnWriteToBatFile_Click(object sender, EventArgs e)
        {
            DialogResult startProcessResult = MessageBox.Show("Create eac3to batch file?", "Start Process?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (startProcessResult == System.Windows.Forms.DialogResult.Yes)
            {
                this.SetEac3ToConfiguration();
                this.SetEAC3ToRemuxFileNameTemplate();
                if (this.IsAtLeastOneDiscLoaded() && this.IsScreenValid())
                {
                    List<BluRayDiscInfo> discs = this.GetBluRayDiscInfoList();
                    WarningCollection warnings = new EAC3ToBatchFileWriteWarningService(discs).GetWarnings();
                    if (warnings.Count() > 0)
                    {
                        string warning = string.Format("{0}{1}{2}Would you still like to continue?", warnings.GetWarningMessage(), Environment.NewLine, Environment.NewLine);
                        DialogResult warningResult = MessageBox.Show(warning, "Warnings Found", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (warningResult == System.Windows.Forms.DialogResult.Yes)
                        {
                            this.WriteToBatchFile();                            
                        }
                    }
                    else
                    {
                        this.WriteToBatchFile();
                    }
                }                
            }
        }

        private void WriteToBatchFile()
        {
            gbScreen.SetEnabled(false);
            List<BluRayDiscInfo> discs = this.GetBluRayDiscInfoList();
            IDirectorySystemService directorySystemService = new DirectorySystemService();
            IAudioService audioService = new AudioService();
            IEAC3ToBatchFileWriteService batchFileWriteService = new EAC3ToBatchFileWriteService(_eac3toConfiguration, directorySystemService, discs, audioService);
            bgwEac3toWriteBatchFile.RunWorkerAsync(batchFileWriteService);
        }

        private void BindDgvBluRayDiscInfoGrid()
        {
            bsBluRayDiscInfo.DataSource = _bindingListBluRayDiscInfo;
            bsBluRayDiscInfo.ResetBindings(false);
            _bindingListBluRayDiscInfo.AllowEdit = true;
        }

        private void dgvBluRayDiscInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                this.SortBluRayDiscGrid(e.ColumnIndex);
            }
            else
            {
                this.HandleDgvBluRayDiscInfoCellClick(e);
                if (_currentBluRayDiscInfo.BluRaySummaryInfoList == null)
                {
                    gbScreen.SetEnabled(false);
                    this.HandleLoadBluRay();
                }
                else
                {
                    _bindingListBluRaySummaryInfo = new BindingList<BluRaySummaryInfo>();
                    foreach (BluRaySummaryInfo info in _currentBluRayDiscInfo.BluRaySummaryInfoList)
                    {
                        _bindingListBluRaySummaryInfo.Add(info);
                    }
                    this.UpdateUIForBluRaySummary();
                }
            }
        }

        private void HandleDgvBluRayDiscInfoCellClick(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            var id = dgvBluRayDiscInfo.Rows[e.RowIndex].Cells[0].Value;
            _currentBluRayDiscInfo = _bindingListBluRayDiscInfo.SingleOrDefault(d => d.Id == id.ToString().StringToInt());
            _currentBluRayDiscGridRowIndex = e.RowIndex;
        }

        private void HandleLoadBluRay()
        {
            _bindingListBluRaySummaryInfo = new BindingList<BluRaySummaryInfo>();

            //Blu ray streams
            _commandLineProcessStartInfo = new CommandLineProcessStartInfo()
            {
                FileName = _eac3ToPath,
                Arguments = string.Format("\"{0}\"", _currentBluRayDiscInfo.BluRayPath)
            };

            ICommandLineProcessService commandLineProcessService = new CommandLineProcessService(_commandLineProcessStartInfo);
            if (commandLineProcessService.Errors.Count() == 0)
            {
                bgwEac3toLoadSummary.RunWorkerAsync(commandLineProcessService);
            }
            else
            {
                MessageBox.Show(commandLineProcessService.Errors.GetErrorMessage(), "Errors Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUIForBluRaySummary()
        {
            this.BindDgvBluRaySummaryGrid();
            gbDiscSummary.Text = string.Format("Disc Summary: {0}", _currentBluRayDiscInfo.DiscName);

            if (_currentBluRayDiscGridRowIndex != -1)
                dgvBluRayDiscInfo.Rows[_currentBluRayDiscGridRowIndex].Selected = true;
            gbScreen.SetEnabled(true);
        }


        private void BindDgvBluRaySummaryGrid()
        {
            bsBluRaySummaryInfo.DataSource = _bindingListBluRaySummaryInfo;
            bsBluRaySummaryInfo.ResetBindings(false);
            _bindingListBluRaySummaryInfo.AllowEdit = true;
        }

        private void dgvBluRaySummary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.HandleDgvBluRaySummaryCellDoubleClick(e);
        }

        private void HandleDgvBluRaySummaryCellDoubleClick(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            var id = dgvBluRaySummary.Rows[e.RowIndex].Cells[1].Value;
            BluRaySummaryInfo summaryInfo = _currentBluRayDiscInfo.BluRaySummaryInfoList.SingleOrDefault(s => s.Eac3ToId == id.ToString());

            BluRayTitleInfoForm form = new BluRayTitleInfoForm();
            form.SetBluRayTitleInfo(_eac3toConfiguration,_currentBluRayDiscInfo.BluRayPath,summaryInfo);
            form.ShowDialog();
            this.BindDgvBluRaySummaryGrid();
        }

        private bool IsScreenValid()
        {
            if (_eac3toConfiguration.BatchFilePath == null || _eac3toConfiguration.BatchFilePath == string.Empty)
            {
                MessageBox.Show("Please enter the path the batch file should be created!", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;    
            }
            if (_eac3toConfiguration.EAC3ToPath == null || _eac3toConfiguration.EAC3ToPath == string.Empty)
            {
                MessageBox.Show("Please enter the eac3to.exe path with the exe in the path!", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_eac3toConfiguration.EAC3ToOutputPath == null || _eac3toConfiguration.EAC3ToOutputPath == string.Empty)
            {
                MessageBox.Show("Please choose an eac3to output path!", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;                
            }
            if (_eac3toConfiguration.IsExtractForRemux)
            {
                if (_eac3toConfiguration.RemuxFileNameTemplate.SeriesName == null || _eac3toConfiguration.RemuxFileNameTemplate.SeriesName == string.Empty)
                {
                    MessageBox.Show("Please enter a Series Name!", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;        
                }
                if (_eac3toConfiguration.RemuxFileNameTemplate.SeasonNumber == 0)
                {
                    MessageBox.Show("Please enter a Season Number!", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private bool IsAtLeastOneDiscLoaded()
        {
            if (_bindingListBluRayDiscInfo == null || _bindingListBluRayDiscInfo.Count() == 0)
            {
                MessageBox.Show("Please load at least 1 blu-ray disck!", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void dgvBluRaySummary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                this.SortBluRaySummaryGrid(e.ColumnIndex);
            }
            else
            {
                dgvBluRaySummary.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnOpenBatchFilePathDialog_Click(object sender, EventArgs e)
        {
            this.HandleBtnOpenBatchFilePathDialogClick();
        }

        private void HandleBtnOpenBatchFilePathDialogClick()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            Setting setting = Program.ApplicationSettingsService.GetSettingByName(Constant.FeatureCreateEac3toBatchFileFormSaveEac3ToBatchFileDirectory);

            if (setting != null)
                sfd.InitialDirectory = setting.Value;
            else
                sfd.InitialDirectory = @"C:\";

            sfd.Filter = "Batch File|*.bat";
            sfd.Title = "Save eac3to Batch File";
            sfd.ShowDialog();

            if (!string.IsNullOrEmpty(sfd.FileName))
            {
                OnDialogInitialDirectoryChanged(this, new DialogInitialDirectoryChangedEventArgs() { FeatureName = Constant.FeatureCreateEac3toBatchFileFormSaveEac3ToBatchFileDirectory, DirectoryPath = Path.GetDirectoryName(sfd.FileName) });
                using (FileStream fs = File.Create(sfd.FileName))
                {
                }
                txtBatFilePath.Text = sfd.FileName;
            }
        }

        private void bgwEac3toLoadSummary_DoWork(object sender, DoWorkEventArgs e)
        {
            //Get line items
            ICommandLineProcessService commandLineProcessService = e.Argument as CommandLineProcessService;
            List<ProcessOutputLineItem> processOutputLineItems = commandLineProcessService.GetProcessOutputLineItems();

            e.Result = processOutputLineItems;
        }

        private void bgwEac3toLoadSummary_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<ProcessOutputLineItem> processOutputLineItems = e.Result as List<ProcessOutputLineItem>;
            ILineItemIdentifierService lineItemService = new BluRaySummaryLineItemIdentifierService();
            IBluRaySummaryParserService parserService = new BluRaySummaryParserService(lineItemService, processOutputLineItems);
            List<BluRaySummaryInfo> bluRaySummaries = parserService.GetSummaryList();

            if (parserService.Errors.Count() == 0)
            {
                _currentBluRayDiscInfo.BluRaySummaryInfoList = bluRaySummaries;
                foreach (BluRaySummaryInfo info in _currentBluRayDiscInfo.BluRaySummaryInfoList)
                {
                    _bindingListBluRaySummaryInfo.Add(info);
                }
                this.UpdateUIForBluRaySummary();         
            }
            else
            {
                MessageBox.Show(parserService.Errors.GetErrorMessage(), "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BluRayDiscInfo disc = _bindingListBluRayDiscInfo.SingleOrDefault(d => d.Id == _currentBluRayDiscInfo.Id);
                _bindingListBluRayDiscInfo.Remove(disc);
                this.BindDgvBluRayDiscInfoGrid();
                gbScreen.SetEnabled(true);
                dgvBluRaySummary.Rows.Clear();
            }
      
        }

        private void bgwEac3toWriteBatchFile_DoWork(object sender, DoWorkEventArgs e)
        {
            IEAC3ToBatchFileWriteService batchFileWriteService = e.Argument as EAC3ToBatchFileWriteService;
            batchFileWriteService.Write();
            e.Result = batchFileWriteService;
        }

        private void bgwEac3toWriteBatchFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            IEAC3ToBatchFileWriteService batchFileWriteService = e.Result as EAC3ToBatchFileWriteService;
            if (batchFileWriteService.Errors.Count() == 0)
            {
                MessageBox.Show("Batch File created!", "Process Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(string.Format("Error: {0}", batchFileWriteService.Errors[0].Description), "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            gbScreen.SetEnabled(true);
        }

        private void SortBluRayDiscGrid(int sortColumnNumber)
        {
            if (_bindingListBluRayDiscInfo.Count() == 0)
                return;

            string sortColumnName = dgvBluRayDiscInfo.Columns[sortColumnNumber].DataPropertyName;
            _bluRayDiscGridSortConfiguration.SortByColumnName = sortColumnName;
            List<BluRayDiscInfo> discs = this.GetBluRayDiscInfoList();
            ISortService<BluRayDiscInfo> sortService = new SortService<BluRayDiscInfo>(_bluRayDiscGridSortConfiguration, discs);

            IBindingListSortService<BluRayDiscInfo> bindingListSortService = new BindingListSortService<BluRayDiscInfo>(discs, dgvBluRayDiscInfo, _bluRayDiscGridSortConfiguration, sortService);
            _bindingListBluRayDiscInfo = bindingListSortService.Sort();

            this.BindDgvBluRayDiscInfoGrid();

        }

        private void SortBluRaySummaryGrid(int sortColumnNumber)
        {
            if (_currentBluRayDiscInfo == null)
                return;

            string sortColumnName = dgvBluRaySummary.Columns[sortColumnNumber].DataPropertyName;
            _bluRaySummaryGridSortConfiguration.SortByColumnName = sortColumnName;
            ISortService<BluRaySummaryInfo> sortService = new SortService<BluRaySummaryInfo>(_bluRaySummaryGridSortConfiguration, _currentBluRayDiscInfo.BluRaySummaryInfoList);

            IBindingListSortService<BluRaySummaryInfo> bindingListSortService = new BindingListSortService<BluRaySummaryInfo>(_currentBluRayDiscInfo.BluRaySummaryInfoList,
                dgvBluRaySummary, _bluRaySummaryGridSortConfiguration, sortService);

            _bindingListBluRaySummaryInfo = bindingListSortService.Sort();

            this.BindDgvBluRaySummaryGrid();
        }

        private void SetEac3ToConfiguration()
        {
            _eac3toConfiguration.BatchFilePath = txtBatFilePath.Text;
            _eac3toConfiguration.EAC3ToPath = _eac3ToPath;
            _eac3toConfiguration.EAC3ToOutputPath = setDirectoryUserControl.CLIDirectory;
            _eac3toConfiguration.OutputDirectoryType = setDirectoryUserControl.OutputDirectoryType;
            _eac3toConfiguration.IsExtractForRemux = chkExtractForRemux.Checked;
            _eac3toConfiguration.NumberOfEpisodes = this.GetBluRayDiscInfoList().NumberOfEpisodes();
            _eac3toConfiguration.MKVMergeOutputPath = txtMKVMergeOutputPath.Text;
            Setting setting = Program.ApplicationSettingsService.GetSettingByName("mkvmerge");
            _eac3toConfiguration.MKVMergePath = setting.Value;
            _eac3toConfiguration.MKVMergeBatchFilePath = txtMKVMergeBatFilePath.Text;
            _eac3toConfiguration.ShowProgressNumbers = Program.ApplicationSettings.EAC3ToDefaultSettings.ShowProgressNumbers;
        }

        private void dgvBluRayDiscInfo_DragDrop(object sender, DragEventArgs e)
        {
            this.HandleDgvBluRayDiscInfoDragDrop(e);
        }

        private void HandleDgvBluRayDiscInfoDragDrop(DragEventArgs e)
        {
            foreach (string folder in (Array)e.Data.GetData(DataFormats.FileDrop))
            {
                if (this.IsADirectory(folder) && this.NotADuplicate(folder))
                {
                   _bindingListBluRayDiscInfo.Add(new BluRayDiscInfo() {Id = _bindingListBluRayDiscInfo.Count() + 1, IsSelected = false, BluRayPath = folder});
                }
            }
            if (_bindingListBluRayDiscInfo.Count() > 0)
            {
                this.BindDgvBluRayDiscInfoGrid();
            }
        }

        private bool IsADirectory(string folder)
        {
            if (Directory.Exists(folder))
                return true;
            else
                return false;
        }

        private bool NotADuplicate(string folder)
        {
            if (_bindingListBluRayDiscInfo.Where(d => d.BluRayPath == folder).Count() == 0)
                return true;
            else
                return false;
        }

        private void dgvBluRayDiscInfo_DragEnter(object sender, DragEventArgs e)
        {
            this.HandleDgvBluRayDiscInfoDragEnter(e);
        }

        private void HandleDgvBluRayDiscInfoDragEnter(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private List<BluRayDiscInfo> GetBluRayDiscInfoList()
        {
            List<BluRayDiscInfo> discs = new List<BluRayDiscInfo>();
            foreach (BluRayDiscInfo disc in _bindingListBluRayDiscInfo)
            {
                discs.Add(disc);
            }
            return discs;
        }

        private void chkExtractForRemux_CheckedChanged(object sender, EventArgs e)
        {
            this.HandleChkExtractForRemuxCheckedChanged();
        }

        private void HandleChkExtractForRemuxCheckedChanged()
        {
            gbExtractForRemux.Enabled = chkExtractForRemux.Checked;
            gbMKVMergeInfo.Enabled = chkExtractForRemux.Checked;
            _eac3toConfiguration.IsExtractForRemux = chkExtractForRemux.Checked;
            this.SetBtnCreateMKVMergeBatFileEnabledStatus();


            if (_eac3toConfiguration.IsExtractForRemux != true) //clear mkvmerge settings
            {
                foreach (BluRayDiscInfo disc in _bindingListBluRayDiscInfo)
                {
                    foreach (BluRaySummaryInfo summary in disc.BluRaySummaryInfoList)
                    {
                        if (summary.BluRayTitleInfo != null && summary.BluRayTitleInfo.AudioList != null)
                        {
                            foreach (BluRayTitleAudio audio in summary.BluRayTitleInfo.AudioList)
                            {
                                audio.MKVMergeItem = null;
                            }
                        }
                        if (summary.BluRayTitleInfo != null && summary.BluRayTitleInfo.Subtitles != null)
                        {
                            foreach (BluRayTitleSubtitle subtitle in summary.BluRayTitleInfo.Subtitles)
                            {
                                subtitle.MKVMergeItem = null;
                            }
                        }
                    }
                }
            }
        }

        private void txtSeasonNumber_TextChanged(object sender, EventArgs e)
        {
            this.HandleTxtSeasonNumberTextChanged();
        }

        private void HandleTxtSeasonNumberTextChanged()
        {
            this.ValidateNumbericTextBox(txtRemuxSeasonNumber);
        }

        private void ValidateNumbericTextBox(TextBox textBox)
        {
            if (!textBox.Text.IsNumeric())
            {
                textBox.Text = "";
            }
        }

        private void SetEAC3ToRemuxFileNameTemplate()
        {
            if (_eac3toConfiguration.IsExtractForRemux)
            {
                _eac3toConfiguration.RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate() { AudioType = txtRemuxAudioType.Text.Trim(), Tag = txtRemuxTag.Text.Trim(), SeriesName = txtRemuxSeriesName.Text.Trim(),
                 VideoResolution = cbRemuxVideoResolution.Text, SeasonYear = txtRemuxSeasonYear.Text.Trim(), Medium = cbRemuxMedium.Text, VideoFormat = cbRemuxVideoFormat.Text};

                if (txtRemuxSeasonNumber.Text.IsNumeric())
                    _eac3toConfiguration.RemuxFileNameTemplate.SeasonNumber = txtRemuxSeasonNumber.Text.StringToInt();
            }
        }

        protected virtual void OnDialogInitialDirectoryChanged(object sender, DialogInitialDirectoryChangedEventArgs e)
        {
            EventHandler<DialogInitialDirectoryChangedEventArgs> handler = DialogInitialDirectoryChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.HandlesSaveToolStripMenuItemClick();
        }

        private void HandlesSaveToolStripMenuItemClick()
        {
            this.SetEac3ToConfiguration();
            this.SetEAC3ToRemuxFileNameTemplate();
            if (this.IsAtLeastOneDiscLoaded() && this.IsScreenValid())
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "BatchGuy File|*.batchGuyEac3toSettings";
                sfd.Title = "Save eac3to Settings File";
                sfd.ShowDialog();

                if (!string.IsNullOrEmpty(sfd.FileName))
                {
                    dgvBluRayDiscInfo.CurrentCell = null; //force the cell change so cell changed event fires
                    dgvBluRaySummary.CurrentCell = null; //force the cell change so cell changed event fires
                    List<BluRayDiscInfo> discs = this.GetBluRayDiscInfoList();
                    BatchGuyEAC3ToSettings settings = new BatchGuyEAC3ToSettings() { BluRayDiscs = discs, Settings = _eac3toConfiguration };
                    IJsonSerializationService<BatchGuyEAC3ToSettings> jsonSerializationService = new JsonSerializationService<BatchGuyEAC3ToSettings>();
                    IBatchGuyEAC3ToSettingsService batchGuyEAC3ToSettingsService = new BatchGuyEAC3ToSettingsService(jsonSerializationService);
                    batchGuyEAC3ToSettingsService.Save(sfd.FileName, settings);
                    if (batchGuyEAC3ToSettingsService.Errors.Count() > 0)
                    {
                        MessageBox.Show(batchGuyEAC3ToSettingsService.Errors.GetErrorMessage(), "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);                        
                    }
                }                
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdFileDialog.Filter = "BatchGuy File|*.batchGuyEac3toSettings";
            ofdFileDialog.FileName = "";
            if (ofdFileDialog.ShowDialog() == DialogResult.OK)
            {
                string settingsFile = ofdFileDialog.FileName;
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
                    BatchGuyEAC3ToSettings batchGuyEAC3ToSettings = batchGuyEAC3ToSettingsService.GetBatchGuyEAC3ToSettings(settingsFile);
                    if (batchGuyEAC3ToSettingsService.Errors.Count() > 0)
                    {
                        MessageBox.Show(batchGuyEAC3ToSettingsService.Errors.GetErrorMessage(), "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.ReloadEac3ToSettingsAndBluRayDiscs(batchGuyEAC3ToSettings);
                        this.ReloadRemux();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error trying to load the eac3to Settings File", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);             
                _log.ErrorFormat(Program.GetLogErrorFormat(), ex.Message, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void ReloadEac3ToSettingsAndBluRayDiscs(BatchGuyEAC3ToSettings batchGuyEAC3ToSettings)
        {
            _bindingListBluRayDiscInfo = new BindingList<BluRayDiscInfo>();
            _bindingListBluRaySummaryInfo = new BindingList<BluRaySummaryInfo>();
            _bluRaySummaryGridSortConfiguration = new SortConfiguration();
            _bluRayDiscGridSortConfiguration = new SortConfiguration();
            _currentBluRayDiscGridRowIndex = 0;
            _eac3toConfiguration = batchGuyEAC3ToSettings.Settings;
            txtBatFilePath.Text = _eac3toConfiguration.BatchFilePath;
            txtMKVMergeBatFilePath.Text = _eac3toConfiguration.MKVMergeBatchFilePath;
            txtMKVMergeOutputPath.Text = _eac3toConfiguration.MKVMergeOutputPath;
            foreach (BluRayDiscInfo disc in batchGuyEAC3ToSettings.BluRayDiscs)
            {
                _bindingListBluRayDiscInfo.Add(disc);
            }
            _currentBluRayDiscInfo = _bindingListBluRayDiscInfo[0];
            foreach (BluRaySummaryInfo summary in _currentBluRayDiscInfo.BluRaySummaryInfoList)
            {
                _bindingListBluRaySummaryInfo.Add(summary);
            }
            setDirectoryUserControl.SetControlValues(_eac3toConfiguration.EAC3ToOutputPath, _eac3toConfiguration.OutputDirectoryType);
            this.BindDgvBluRayDiscInfoGrid();
            this.BindDgvBluRaySummaryGrid();
        }

        private void ReloadRemux()
        {
            chkExtractForRemux.Checked = _eac3toConfiguration.IsExtractForRemux;
            if (_eac3toConfiguration.IsExtractForRemux)
            {
                txtRemuxSeriesName.Text = _eac3toConfiguration.RemuxFileNameTemplate.SeriesName;
                txtRemuxSeasonNumber.Text = _eac3toConfiguration.RemuxFileNameTemplate.SeasonNumber.ToString();
                txtRemuxAudioType.Text = _eac3toConfiguration.RemuxFileNameTemplate.AudioType;
                txtRemuxTag.Text = _eac3toConfiguration.RemuxFileNameTemplate.Tag;
                txtRemuxSeasonYear.Text = _eac3toConfiguration.RemuxFileNameTemplate.SeasonYear;
                cbRemuxVideoResolution.SelectedIndex = 0;
                if (!string.IsNullOrEmpty(_eac3toConfiguration.RemuxFileNameTemplate.VideoResolution))
                {
                    int index = cbRemuxVideoResolution.FindString(_eac3toConfiguration.RemuxFileNameTemplate.VideoResolution);
                    cbRemuxVideoResolution.SelectedIndex = index;
                }
                cbRemuxMedium.SelectedIndex = 0;
                if (!string.IsNullOrEmpty(_eac3toConfiguration.RemuxFileNameTemplate.Medium))
                {
                    int index = cbRemuxMedium.FindString(_eac3toConfiguration.RemuxFileNameTemplate.Medium);
                    cbRemuxMedium.SelectedIndex = index;                    
                }
                cbRemuxVideoFormat.SelectedIndex = 0;
                if (!string.IsNullOrEmpty(_eac3toConfiguration.RemuxFileNameTemplate.VideoFormat))
                {
                    int index = cbRemuxVideoFormat.FindString(_eac3toConfiguration.RemuxFileNameTemplate.VideoFormat);
                    cbRemuxVideoFormat.SelectedIndex = index;                                        
                }
            }
        }

        private void CreateEAC3ToBatchForm_DragDrop(object sender, DragEventArgs e)
        {
            this.HandleCreateEAC3ToBatchFormDragDrop(e);
        }

        private void HandleCreateEAC3ToBatchFormDragDrop(DragEventArgs e)
        {
            foreach (string file in (Array)e.Data.GetData(DataFormats.FileDrop))
            {
                if (this.IsBatchGuyEac3toSettingsFile(file))
                {
                    this.HandlesLoadToolStripMenuItemClick(file);
                }
            }
        }

        private void CreateEAC3ToBatchForm_DragEnter(object sender, DragEventArgs e)
        {
            this.HandleCreateEAC3ToBatchFormDragEnter(e);
        }

        private void HandleCreateEAC3ToBatchFormDragEnter(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private bool IsBatchGuyEac3toSettingsFile(string file)
        {
            if (file.EndsWith(_settingsExtension))
                return true;
            else
                return false;
        }

        private void btnOpenMKVMergeOutputPathDialog_Click(object sender, EventArgs e)
        {
            this.HandleBtnSetOutputDirectoryUserControlOpenDialogClick();
        }

        private void HandleBtnSetOutputDirectoryUserControlOpenDialogClick()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            Setting setting = Program.ApplicationSettingsService.GetSettingByName(Constant.FeatureCreateEac3toBatchFileFormMKVMergeOutputDirectory);

            var fsd = new FolderSelectDialog();
            fsd.Title = "mkvmerge.exe output directory";
            if (setting != null)
                fsd.InitialDirectory = setting.Value;

            if (fsd.ShowDialog(IntPtr.Zero))
            {
                txtMKVMergeOutputPath.Text = fsd.FileName;

                OnDialogInitialDirectoryChanged(this, new DialogInitialDirectoryChangedEventArgs() { FeatureName = Constant.FeatureCreateEac3toBatchFileFormMKVMergeOutputDirectory, DirectoryPath = txtMKVMergeOutputPath.Text});
            }
        }

        private void SetBtnCreateMKVMergeBatFileEnabledStatus()
        {
            btnWriteToMKVMergeBatFile.Enabled = _eac3toConfiguration.IsExtractForRemux;
        }

        private void btnWriteToMKVMergeBatFile_Click(object sender, EventArgs e)
        {


            DialogResult startProcessResult = MessageBox.Show("Create mkvmerge batch file?", "Start Process?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (startProcessResult == System.Windows.Forms.DialogResult.Yes)
            {
                this.SetEac3ToConfiguration();
                this.SetEAC3ToRemuxFileNameTemplate();
                if (this.IsScreenValidForRemux() && this.IsAtLeastOneDiscLoaded() && this.IsScreenValid())
                {
                    List<BluRayDiscInfo> discs = this.GetBluRayDiscInfoList();
                    WarningCollection warnings = new EAC3ToBatchFileWriteWarningService(discs).GetWarnings();
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

        private bool IsScreenValidForRemux()
        {
            if (IsMkvMergePathSetInSettings() != true)
            {
                MessageBox.Show("Please go to settings and set the mkvmerge.exe path","Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_eac3toConfiguration.MKVMergeBatchFilePath == null || _eac3toConfiguration.MKVMergeBatchFilePath == string.Empty)
            {
                MessageBox.Show("Please choose an mkvmerge batch file!", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_eac3toConfiguration.MKVMergeOutputPath == null || _eac3toConfiguration.MKVMergeOutputPath == string.Empty)
            {
                MessageBox.Show("Please choose an mkvmerge output path!", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnOpenMKVMergeFilePathDialog_Click(object sender, EventArgs e)
        {
            this.HandleBtnOpenMKVMergeFilePathDialogClick();
        }

        private void HandleBtnOpenMKVMergeFilePathDialogClick()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            Setting setting = Program.ApplicationSettingsService.GetSettingByName(Constant.FeatureCreateEac3toBatchFileFormSaveMKVMergeBatchFileDirectory);

            if (setting != null)
                sfd.InitialDirectory = setting.Value;
            else
                sfd.InitialDirectory = @"C:\";

            sfd.Filter = "Batch File|*.bat";
            sfd.Title = "Save mkvmerge Batch File";
            sfd.ShowDialog();

            if (!string.IsNullOrEmpty(sfd.FileName))
            {
                OnDialogInitialDirectoryChanged(this, new DialogInitialDirectoryChangedEventArgs() { FeatureName = Constant.FeatureCreateEac3toBatchFileFormSaveMKVMergeBatchFileDirectory, DirectoryPath = Path.GetDirectoryName(sfd.FileName) });
                using (FileStream fs = File.Create(sfd.FileName))
                {
                }
                txtMKVMergeBatFilePath.Text = sfd.FileName;
            }
        }

        private void WriteToMkvMergeBatchFile()
        {
            gbScreen.SetEnabled(false);
            List<BluRayDiscInfo> discs = this.GetBluRayDiscInfoList();
            IDirectorySystemService directorySystemService = new DirectorySystemService();
            IAudioService audioService = new AudioService();
            IMKVMergeBatchFileWriteService batchFileWriteService = new MKVMergeBatchFileWriteService(_eac3toConfiguration, directorySystemService, discs, audioService);
            bgwMkvMergeWriteBatchFile.RunWorkerAsync(batchFileWriteService);
        }

        private void bgwMkvMergeWriteBatchFile_DoWork(object sender, DoWorkEventArgs e)
        {
            IMKVMergeBatchFileWriteService batchFileWriteService = e.Argument as MKVMergeBatchFileWriteService;
            batchFileWriteService.Write();
            e.Result = batchFileWriteService;
        }

        private void bgwMkvMergeWriteBatchFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            IMKVMergeBatchFileWriteService batchFileWriteService = e.Result as MKVMergeBatchFileWriteService;
            if (batchFileWriteService.Errors.Count() == 0)
            {
                MessageBox.Show("Batch File created!", "Process Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(string.Format("Error: {0}", batchFileWriteService.Errors[0].Description), "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            gbScreen.SetEnabled(true);
        }


    }
}

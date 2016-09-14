﻿using BatchGuy.App.Enums;
using BatchGuy.App.Parser.Interfaces;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Parser.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatchGuy.App.Helpers;
using BatchGuy.App.Extensions;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Shared.Services;
using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.MKVMerge.Models;
using BatchGuy.App.MKVMerge.Interfaces;
using BatchGuy.App.MKVMerge.Services;
using BatchGuy.App.Shared.Interface;
using BatchGuy.App.Settings.Interface;
using BatchGuy.App.Settings.Services;

namespace BatchGuy.App
{
    public partial class BluRayTitleInfoForm : Form
    {
        private BluRaySummaryInfo _bluRaySummaryInfo;
        private BindingList<BluRayTitleAudio> _bindingListBluRayTitleAudio = new BindingList<BluRayTitleAudio>();
        private BindingList<BluRayTitleSubtitle> _bindingListBluRayTitleSubtitle = new BindingList<BluRayTitleSubtitle>();
        private BluRayTitleAudio _currentBluRayTitleAudio;
        private SortConfiguration _audioGridSortConfiguration = new SortConfiguration();
        private SortConfiguration _subtitleGridSortConfiguration = new SortConfiguration();
        private EAC3ToConfiguration _eac3ToConfiguration;
        private string _bluRayPath;
        private bool _cbAudioTypeChangeTriggeredByDgvAudioCellClick;
        private BindingList<MKVMergeLanguageItem> _bindingListMKVMergeLanguageItem = new BindingList<MKVMergeLanguageItem>();
        private MKVMergeItem _currentMKVMergeItem;
        private bool _mkvMergeChangeTriggeredByDataGridCellClick;
        private BluRayTitleSubtitle _currentBluRayTitleSubtitle;
        private IAudioService _audioService = new AudioService();

        public BluRayTitleInfoForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        public void SetBluRayTitleInfo(EAC3ToConfiguration eac3ToConfiguration, string bluRayPath, BluRaySummaryInfo bluRaySummaryInfo)
        {
            _bluRaySummaryInfo = bluRaySummaryInfo;
            _eac3ToConfiguration = eac3ToConfiguration;
            _bluRayPath = bluRayPath;
        }

        private void BluRayTitleForm_Load(object sender, EventArgs e)
        {
            this.SetScreenInfo();
            this.gbScreen.SetEnabled(false);
            this.SetMKVToolNixGUIControlsDefaults();
            this.SetGBMKVToolNixGUIEnabledStatus(false);

            if (_bluRaySummaryInfo.BluRayTitleInfo != null)
            {
                this.LoadScreen();
                this.SetGridRowBackgroundIfUndetermindLanguage();
                gbScreen.SetEnabled(true);
            }
            else
            {
                this.LoadBluRayTitleInfo();
            }
            txtEpisodeName.SetEnabled(_eac3ToConfiguration.IsExtractForRemux);
        }

        private void LoadBluRayTitleInfo()
        {
            CommandLineProcessStartInfo commandLineProcessStartInfo = new CommandLineProcessStartInfo()
            {
                FileName = _eac3ToConfiguration.EAC3ToPath,
                Arguments = string.Format("\"{0}\" {1}",  _bluRayPath, _bluRaySummaryInfo.Eac3ToId)
            };
            
            ICommandLineProcessService commandLineProcessService = new CommandLineProcessService(commandLineProcessStartInfo);
            if (commandLineProcessService.Errors.Count() == 0)
            {
                bgwEac3toLoadTitle.RunWorkerAsync(commandLineProcessService);
            }
            else
            {
                gbScreen.SetEnabled(true);
                MessageBox.Show(commandLineProcessService.Errors.GetErrorMessage(), "Errors Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadScreen()
        {
            this.LoadTitle();
            this.LoadEpisodeNumber();
            this.LoadEpisodeName();
            this.LoadVideo();
            this.LoadAudio();
            this.LoadSubtitles();
            this.LoadChapters();
        }

        private void LoadTitle()
        {
            lblTitle.Text = string.Format("Title: {0}", _bluRaySummaryInfo.BluRayTitleInfo.HeaderText);
        }

        private void LoadEpisodeNumber()
        {
            if (_bluRaySummaryInfo.BluRayTitleInfo.EpisodeNumber != null)
            {
                txtEpisodeNumber.Text = _bluRaySummaryInfo.BluRayTitleInfo.EpisodeNumber.ToString();
            }
        }

        public void LoadEpisodeName()
        {
            if (_bluRaySummaryInfo.BluRayTitleInfo.EpisodeName != null && _eac3ToConfiguration.IsExtractForRemux)
            {
                txtEpisodeName.Text = _bluRaySummaryInfo.BluRayTitleInfo.EpisodeName;
            }
        }

        private void LoadVideo()
        {
            bsBluRayTitleVideo.DataSource = _bluRaySummaryInfo.BluRayTitleInfo.Video;
            chkVideo.Text = string.Format("Track: {0}. Title: {1}.",_bluRaySummaryInfo.BluRayTitleInfo.Video.Id,_bluRaySummaryInfo.BluRayTitleInfo.Video.Text);
            chkVideo.Checked = _bluRaySummaryInfo.BluRayTitleInfo.Video.IsSelected;

        }

        private void LoadAudio()
        {
            if (_bluRaySummaryInfo.BluRayTitleInfo.AudioList != null)
            {
                foreach (BluRayTitleAudio audio in _bluRaySummaryInfo.BluRayTitleInfo.AudioList)
                {
                    _bindingListBluRayTitleAudio.Add(audio);
                }

                bsBluRayTitleAudio.DataSource = _bindingListBluRayTitleAudio;
                _bindingListBluRayTitleAudio.AllowEdit = true;                
            }
            else
            {
                dgvAudio.Enabled = false;
            }
        }

        private void LoadSubtitles()
        {
            if (_bluRaySummaryInfo.BluRayTitleInfo.Subtitles != null )
            {
                foreach (BluRayTitleSubtitle subtitle in _bluRaySummaryInfo.BluRayTitleInfo.Subtitles)
                {
                    _bindingListBluRayTitleSubtitle.Add(subtitle);
                }
                bsBluRayTitleSubtitles.DataSource = _bindingListBluRayTitleSubtitle;
                _bindingListBluRayTitleSubtitle.AllowEdit = true;                
            }
            else
            {
                dgvSubtitles.Enabled = false;
            }
        }

        private void LoadChapters()
        {
            if (_bluRaySummaryInfo.BluRayTitleInfo.Chapter != null)
            {
                chkChapters.Checked = _bluRaySummaryInfo.BluRayTitleInfo.Chapter.IsSelected;
                chkChapters.Text = _bluRaySummaryInfo.BluRayTitleInfo.Chapter.Text;
            }
            else
            {
                chkChapters.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.HandleUpdateClick();
        }

        private void HandleUpdateClick()
        {
            this.Close();
        }

        private void dgvAudio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                this.SortAudioGrid(e.ColumnIndex);
            }
            else
            {
                panelAudioType.SetEnabled(true);
                this.SetGBMKVToolNixGUIEnabledStatus(true);
                this.HandleDGVAudioCellClick(e);
                dgvAudio.Rows[e.RowIndex].Selected = true;
            }
        }

        private void HandleDGVAudioCellClick(DataGridViewCellEventArgs e)
        {
            _cbAudioTypeChangeTriggeredByDgvAudioCellClick = true;
            _mkvMergeChangeTriggeredByDataGridCellClick = true;
            var id = dgvAudio.Rows[e.RowIndex].Cells[1].Value;

            _currentBluRayTitleAudio = _bluRaySummaryInfo.BluRayTitleInfo.AudioList.SingleOrDefault(a => a.Id == id.ToString());
            cbAudioType.SelectedIndex = cbAudioType.FindString(_audioService.GetAudioTypeName(_currentBluRayTitleAudio.AudioType));
            txtAudioTypeArguments.Text = _currentBluRayTitleAudio.Arguments;

            _currentMKVMergeItem = _currentBluRayTitleAudio.MKVMergeItem;
            this.SetMKVToolNixControlsWithValues();

            if (_cbAudioTypeChangeTriggeredByDgvAudioCellClick) //selected index may not have changed because the same audio type can exist on a blu-ray
                _cbAudioTypeChangeTriggeredByDgvAudioCellClick = false;

            if (_mkvMergeChangeTriggeredByDataGridCellClick)
                _mkvMergeChangeTriggeredByDataGridCellClick = false;
        }


        private void txtAudioTypeArguments_TextChanged(object sender, EventArgs e)
        {
            this.HandleAudioTypeArgumentsTextChanged();
        }

        private void HandleAudioTypeArgumentsTextChanged()
        {
            _currentBluRayTitleAudio.Arguments = txtAudioTypeArguments.Text;
        }

        private void cbAudioType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HandleComboBoxAudioTypeSelectedIndexChanged(cbAudioType.Text);
            txtAudioTypeArguments.Text = _currentBluRayTitleAudio.Arguments;
        }

        private void HandleComboBoxAudioTypeSelectedIndexChanged(string value)
        {
            if (_cbAudioTypeChangeTriggeredByDgvAudioCellClick)
            {
                _cbAudioTypeChangeTriggeredByDgvAudioCellClick = false;
                return;
            }

            EnumAudioType audioType = _audioService.GetAudioTypeByName(value);
            _currentBluRayTitleAudio.AudioType = audioType;
            _currentBluRayTitleAudio.Arguments = "";
        }

        private void chkChapters_CheckedChanged(object sender, EventArgs e)
        {
            this.HandleCheckBoxChaptersCheckedChanged();
        }

        private void HandleCheckBoxChaptersCheckedChanged()
        {
            _bluRaySummaryInfo.BluRayTitleInfo.Chapter.IsSelected = chkChapters.Checked;
        }

        private void chkVideo_CheckedChanged(object sender, EventArgs e)
        {
            this.HandleCheckBoxVideoCheckedChanged();
        }

        private void HandleCheckBoxVideoCheckedChanged()
        {
            _bluRaySummaryInfo.BluRayTitleInfo.Video.IsSelected = chkVideo.Checked;
        }

        private void txtEpisodeNumber_TextChanged(object sender, EventArgs e)
        {
            this.HandleTextBoxEpisodeNumberTextChanged();
        }

        private void HandleTextBoxEpisodeNumberTextChanged()
        {
            if (!txtEpisodeNumber.Text.IsNumeric())
            {
                _bluRaySummaryInfo.BluRayTitleInfo.EpisodeNumber = "";
                txtEpisodeNumber.Text = "";
            }
            else
            {
                _bluRaySummaryInfo.BluRayTitleInfo.EpisodeNumber = txtEpisodeNumber.Text;
            }
        }

        private void dgvSubtitles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                this.SortSubtitleGrid(e.ColumnIndex);
            }
            else
            {
                this.HandleDGVSubtitlesCellClick(e);
                dgvSubtitles.Rows[e.RowIndex].Selected = true;
                this.SetGBMKVToolNixGUIEnabledStatus(true);
            }
        }

        private void HandleDGVSubtitlesCellClick(DataGridViewCellEventArgs e)
        {
            _mkvMergeChangeTriggeredByDataGridCellClick = true;
            var id = dgvSubtitles.Rows[e.RowIndex].Cells[1].Value;
            _currentBluRayTitleSubtitle = _bluRaySummaryInfo.BluRayTitleInfo.Subtitles.SingleOrDefault(a => a.Id == id.ToString());
            int externalSubtitleCellNumber = 5;

            _currentMKVMergeItem = _currentBluRayTitleSubtitle.MKVMergeItem;
            this.SetMKVToolNixControlsWithValues();

            if (e.ColumnIndex == 6)
                this.AddExternalSubtitle(id.ToString(), e.RowIndex, externalSubtitleCellNumber);

            if (e.ColumnIndex == 7)
                this.RemoveExternalSubtitle(id.ToString(), e.RowIndex, externalSubtitleCellNumber);

            if (_mkvMergeChangeTriggeredByDataGridCellClick)
                _mkvMergeChangeTriggeredByDataGridCellClick = false;
        }

        private void AddExternalSubtitle(string rowId, int rowIndex, int rowCellNumber)
        {
            ofdFileDialog.FileName = "Subtitle";
            ofdFileDialog.Filter = "SubRip|*.srt|Advanced SubStation Alpha|*.ass|DVDSubtitle|*.sub|SubStation Alpha|*.ssa";
            DialogResult result = ofdFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var subtitlePath = ofdFileDialog.FileName;
                dgvSubtitles.Rows[rowIndex].Cells[rowCellNumber].Value = subtitlePath;
                _currentBluRayTitleSubtitle.ExternalSubtitlePath = subtitlePath;
            }
        }

        private void RemoveExternalSubtitle(string rowId, int rowIndex, int rowCellNumber)
        {
            if (_currentBluRayTitleSubtitle.ExternalSubtitlePath != null &&_currentBluRayTitleSubtitle.ExternalSubtitlePath != string.Empty)
            {
                DialogResult warningResult = MessageBox.Show("Are you sure you want to remove the external subtitle?", "Remove Subtitle", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (warningResult == System.Windows.Forms.DialogResult.Yes)
                {
                    dgvSubtitles.Rows[rowIndex].Cells[rowCellNumber].Value = string.Empty;
                    _currentBluRayTitleSubtitle.ExternalSubtitlePath = string.Empty;
                }
            }
        }

        private void bgwEac3toLoadTitle_DoWork(object sender, DoWorkEventArgs e)
        {
            ICommandLineProcessService commandLineProcessService = e.Argument as CommandLineProcessService;
            List<ProcessOutputLineItem> processOutputLineItems = commandLineProcessService.GetProcessOutputLineItems();
            ILineItemIdentifierService lineItemService = new BluRayTitleLineItemIdentifierService();
            IBluRayTitleParserService parserService = new BluRayTitleParserService(lineItemService, processOutputLineItems);
            _bluRaySummaryInfo.BluRayTitleInfo = parserService.GetTitleInfo();
        }

        private void bgwEac3toLoadTitle_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((_bluRaySummaryInfo.BluRayTitleInfo == null) || (_bluRaySummaryInfo.BluRayTitleInfo.AudioList == null && _bluRaySummaryInfo.BluRayTitleInfo.Chapter == null && _bluRaySummaryInfo.BluRayTitleInfo.Subtitles == null 
                && _bluRaySummaryInfo.BluRayTitleInfo.Video == null))
            {
                if (_bluRaySummaryInfo.BluRayTitleInfo != null && !string.IsNullOrEmpty(_bluRaySummaryInfo.BluRayTitleInfo.HeaderText))
                {
                    MessageBox.Show(string.Format("Blu-ray Title could not be loaded.  eac3to returned the following: {0}{1}",Environment.NewLine,_bluRaySummaryInfo.BluRayTitleInfo.HeaderText), "Invalid Blu-ray Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Blu-ray Title could not be loaded probably because it does not contain any tracks.", "Invalid Blu-ray Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _bluRaySummaryInfo.BluRayTitleInfo = null;
            }
            else
            {
                this.SetBluRayTitleInfoDefaultSettings();
                this.LoadScreen();
                txtEpisodeNumber.Focus();
                this.SortAudioGrid(2); //sort language 
                this.SortSubtitleGrid(2); //sort language
                this.SetMKVMergetItemDefaults();
                this.SetGridRowBackgroundIfUndetermindLanguage();
                gbScreen.SetEnabled(true);
            }
        }

        private void SortAudioGrid(int sortColumnNumber)
        {
            if (_bluRaySummaryInfo.BluRayTitleInfo.AudioList == null || _bluRaySummaryInfo.BluRayTitleInfo.AudioList.Count() == 0)
                return;

            string sortColumnName = dgvAudio.Columns[sortColumnNumber].DataPropertyName;
           _audioGridSortConfiguration.SortByColumnName = sortColumnName;
           ISortService<BluRayTitleAudio> sortService = new SortService<BluRayTitleAudio>(_audioGridSortConfiguration, _bluRaySummaryInfo.BluRayTitleInfo.AudioList);

           IBindingListSortService<BluRayTitleAudio> bindingListSortService = new BindingListSortService<BluRayTitleAudio>(_bluRaySummaryInfo.BluRayTitleInfo.AudioList, dgvAudio,
               _audioGridSortConfiguration, sortService);
           _bindingListBluRayTitleAudio = bindingListSortService.Sort();

           this.BindAudioGrid();
        }

        private void BindAudioGrid()
        {
            bsBluRayTitleAudio.DataSource = _bindingListBluRayTitleAudio;
            bsBluRayTitleAudio.ResetBindings(false);
            _bindingListBluRayTitleAudio.AllowEdit = true;
        }

        private void SortSubtitleGrid(int sortColumnNumber)
        {
            if (_bluRaySummaryInfo.BluRayTitleInfo.Subtitles == null || _bluRaySummaryInfo.BluRayTitleInfo.Subtitles.Count() == 0)
                return;

            string sortColumnName = dgvSubtitles.Columns[sortColumnNumber].DataPropertyName;
            _subtitleGridSortConfiguration.SortByColumnName = sortColumnName;
            ISortService<BluRayTitleSubtitle> sortService = new SortService<BluRayTitleSubtitle>(_subtitleGridSortConfiguration, _bluRaySummaryInfo.BluRayTitleInfo.Subtitles);

            IBindingListSortService<BluRayTitleSubtitle> bindingListSortService = new BindingListSortService<BluRayTitleSubtitle>(_bluRaySummaryInfo.BluRayTitleInfo.Subtitles, dgvSubtitles,
                _subtitleGridSortConfiguration, sortService);
            _bindingListBluRayTitleSubtitle = bindingListSortService.Sort();

            this.BindSubtitleGrid();
        }

        private void BindSubtitleGrid()
        {
            bsBluRayTitleSubtitles.DataSource = _bindingListBluRayTitleSubtitle;
            bsBluRayTitleSubtitles.ResetBindings(false);
            _bindingListBluRayTitleSubtitle.AllowEdit = true;
        }

        private void txtEpisodeName_TextChanged(object sender, EventArgs e)
        {
            this.HandleTxtEpisodeNameTextChanged();
        }

        private void HandleTxtEpisodeNameTextChanged()
        {
            _bluRaySummaryInfo.BluRayTitleInfo.EpisodeName = txtEpisodeName.Text.Trim();
        }

        private void LoadMKVMergeLangugeItemsDropDown()
        {
            IJsonSerializationService<ISOLanguageCodeCollection> jsonSerializationService = new JsonSerializationService<ISOLanguageCodeCollection>();
            IMKVMergeLanguageService service = new MKVMergeLanguageService(jsonSerializationService);
            foreach (MKVMergeLanguageItem item in service.GetLanguages())
            {
                _bindingListMKVMergeLanguageItem.Add(item);
            }

            bsMKVMergeLanguageItem.DataSource = _bindingListMKVMergeLanguageItem;
            _bindingListMKVMergeLanguageItem.AllowEdit = false;
        }

        private void SetMKVMergetItemDefaults()
        {
            if (_eac3ToConfiguration.IsExtractForRemux)
            {
                IJsonSerializationService<ISOLanguageCodeCollection> jsonSerializationService = new JsonSerializationService<ISOLanguageCodeCollection>();
                IMKVMergeLanguageService languageService = new MKVMergeLanguageService(jsonSerializationService);
                IMKVMergeDefaultSettingsService mkvMergeDefaultSettingsService = new MKVMergeDefaultSettingsService(_eac3ToConfiguration, Program.ApplicationSettings,
                    _bluRaySummaryInfo, languageService, _audioService);

                mkvMergeDefaultSettingsService.SetAudioDefaultSettings();
                mkvMergeDefaultSettingsService.SetSubtitleDefaultSettings();
            }
        }

        private void SetMKVToolNixGUIControlsDefaults()
        {
            this.SetMKVToolNixGUIControlsEnabledStatus();
            if (_eac3ToConfiguration.IsExtractForRemux)
            {
                LoadMKVMergeLangugeItemsDropDown();
            }
        }

        private void SetMKVToolNixGUIControlsEnabledStatus()
        {
            gbMKVToolNixGUI.Enabled = _eac3ToConfiguration.IsExtractForRemux;
        }

        private void cbMKVToolNixGUILanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HandleComboBoxMKVToolNixGUILanguageSelectedIndexChanged();
        }

        private void HandleComboBoxMKVToolNixGUILanguageSelectedIndexChanged()
        {
            if (_mkvMergeChangeTriggeredByDataGridCellClick)
            {
                _mkvMergeChangeTriggeredByDataGridCellClick = false;
                return;
            }

            _currentMKVMergeItem.Language = (MKVMergeLanguageItem)cbMKVToolNixGUILanguage.SelectedItem;
        }

        private void SetMKVToolNixControlsWithValues()
        {
            if (_eac3ToConfiguration.IsExtractForRemux)
            {
                txtMKVToolNixGUITrackName.Text = _currentMKVMergeItem.TrackName;
                cbMKVToolNixGUILanguage.SelectedValue = _currentMKVMergeItem.Language.Value;
                cbMKVToolNixGUIDefaultTrackFlag.SelectedIndex = cbMKVToolNixGUIDefaultTrackFlag.FindString(_currentMKVMergeItem.DefaultTrackFlag);
                cbMKVToolNixGUIForcedTrackFlag.SelectedIndex = cbMKVToolNixGUIForcedTrackFlag.FindString(_currentMKVMergeItem.ForcedTrackFlag);
                cbMKVToolNixGUICompression.SelectedIndex = cbMKVToolNixGUICompression.FindString(_currentMKVMergeItem.Compression);
            }

            if (_mkvMergeChangeTriggeredByDataGridCellClick)
                _mkvMergeChangeTriggeredByDataGridCellClick = false;
        }

        private void txtMKVToolNixGUITrackName_TextChanged(object sender, EventArgs e)
        {
            this.HandleTextBoxMKVToolNixGUITrackNameTextChanged();
        }

        private void HandleTextBoxMKVToolNixGUITrackNameTextChanged()
        {
            _currentMKVMergeItem.TrackName = txtMKVToolNixGUITrackName.Text.Trim();
        }

        private void cbMKVToolNixGUIDefaultTrackFlag_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HandleComboBoxMKVToolNixGUIDefaultTrackFlagSelectedIndexChanged();
        }

        private void HandleComboBoxMKVToolNixGUIDefaultTrackFlagSelectedIndexChanged()
        {
            if (_mkvMergeChangeTriggeredByDataGridCellClick)
            {
                _mkvMergeChangeTriggeredByDataGridCellClick = false;
                return;
            }

            _currentMKVMergeItem.DefaultTrackFlag = cbMKVToolNixGUIDefaultTrackFlag.Text;
        }

        private void cbMKVToolNixGUIForcedTrackFlag_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HandleComboBoxMKVToolNixGUIForcedFlagSelectedIndexChanged();
        }

        private void HandleComboBoxMKVToolNixGUIForcedFlagSelectedIndexChanged()
        {
            _currentMKVMergeItem.ForcedTrackFlag = cbMKVToolNixGUIForcedTrackFlag.Text;
        }

        private void SetGBMKVToolNixGUIEnabledStatus(bool enabled)
        {
            if (_eac3ToConfiguration.IsExtractForRemux == false)
            {
                gbMKVToolNixGUI.Enabled = false;
                return;
            }

            gbMKVToolNixGUI.Enabled = enabled;
        }

        private void SetGridRowBackgroundIfUndetermindLanguage()
        {
            if (_eac3ToConfiguration.IsExtractForRemux)
            {
                if (_bluRaySummaryInfo.BluRayTitleInfo.AudioList != null)
                {
                    foreach (DataGridViewRow row in dgvAudio.Rows)
                    {
                        string id = (string)row.Cells[1].Value;
                        BluRayTitleAudio audio = _bluRaySummaryInfo.BluRayTitleInfo.AudioList.Where(s => s.Id == id).SingleOrDefault();
                        if (audio != null && audio.MKVMergeItem.Language.Language == "Undetermined")
                        {
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                cell.ToolTipText = "eac3to language could not be matched with mkvmerge langage";
                            }
                        }
                    }
                }

                if (_bluRaySummaryInfo.BluRayTitleInfo.Subtitles != null)
                {
                    foreach (DataGridViewRow row in dgvSubtitles.Rows)
                    {
                        string id = (string)row.Cells[1].Value;
                        BluRayTitleSubtitle subtitle = _bluRaySummaryInfo.BluRayTitleInfo.Subtitles.Where(s => s.Id == id).SingleOrDefault();
                        if (subtitle != null && subtitle.MKVMergeItem.Language.Language == "Undetermined")
                        {
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                cell.ToolTipText = "eac3to language could not be matched with mkvmerge langage";
                            }
                        }
                    }
                }
            }
        }

        private void SetScreenInfo()
        {
            gbScreen.Text = string.Format("Playlist / Videofile / Runtime: {0}", _bluRaySummaryInfo.HeaderText);
        }

        private void SetBluRayTitleInfoDefaultSettings()
        {
            IBluRayTitleInfoDefaultSettingsService service = new BluRayTitleInfoDefaultSettingsService(Program.ApplicationSettings,
                _bluRaySummaryInfo, _audioService);

            service.SetSubtitleDefaultSettings();
            service.SetChaptersDefaultSettings();
            service.SetAudioDefaultSettings();
        }

        private void cbMKVToolNixGUICompression_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HandleComboBoxMKVToolNixGUICompressionSelectedIndexChanged();
        }

        private void HandleComboBoxMKVToolNixGUICompressionSelectedIndexChanged()
        {
            _currentMKVMergeItem.Compression = cbMKVToolNixGUICompression.Text;
        }

        private void dgvSubtitles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.HandlesDGVSubtitlesCellDoubleClick(e);
        }

        private void HandlesDGVSubtitlesCellDoubleClick(DataGridViewCellEventArgs e)
        {
            var id = dgvSubtitles.Rows[e.RowIndex].Cells[1].Value;
            _currentBluRayTitleSubtitle = _bluRaySummaryInfo.BluRayTitleInfo.Subtitles.SingleOrDefault(a => a.Id == id.ToString());
            if (_currentBluRayTitleSubtitle.CanEdit == false)
                return;
        }
    }
}

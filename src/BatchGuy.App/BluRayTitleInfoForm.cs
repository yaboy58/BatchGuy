using BatchGuy.App.Enums;
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
            gbScreen.SetEnabled(false);
            if (_bluRaySummaryInfo.BluRayTitleInfo != null)
            {
                this.LoadScreen();
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
            if (this.IsScreenValid())
            {
                this.HandleUpdateClick();                
            }
            else
            {
                txtEpisodeNumber.Focus();
            }
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
                this.HandleDGVAudioCellClick(e);
                dgvAudio.Rows[e.RowIndex].Selected = true;
            }
        }

        private void HandleDGVAudioCellClick(DataGridViewCellEventArgs e)
        {
            _cbAudioTypeChangeTriggeredByDgvAudioCellClick = true;
            var id = dgvAudio.Rows[e.RowIndex].Cells[1].Value;
            _currentBluRayTitleAudio = _bluRaySummaryInfo.BluRayTitleInfo.AudioList.SingleOrDefault(a => a.Id == id.ToString());
            cbAudioType.SelectedIndex = cbAudioType.FindString(this.GetAudioTypeName(_currentBluRayTitleAudio.AudioType));
            txtAudioTypeArguments.Text = _currentBluRayTitleAudio.Arguments;

            if (_cbAudioTypeChangeTriggeredByDgvAudioCellClick) //selected index may not have changed because the same audio type can exist on a blu-ray
                _cbAudioTypeChangeTriggeredByDgvAudioCellClick = false;
        }

        private string GetAudioTypeName(EnumAudioType audioType)
        {
            string name = string.Empty;

            switch (audioType)
            {
                case EnumAudioType.DTS:
                    name = "DTS";
                    break;
                case EnumAudioType.AC3:
                    name = "AC3";
                    break;
                case EnumAudioType.FLAC:
                    name = "FLAC";
                    break;
                case EnumAudioType.TrueHD:
                    name = "TrueHD";
                    break;
                case EnumAudioType.MPA:
                    name = "MPA";
                    break;
                case EnumAudioType.DTSMA:
                    name = "DTSMA";
                    break;
                case EnumAudioType.WAVE:
                    name = "Wave";
                    break;
                default:
                    throw new Exception("Invalid Audio Type");
            }
            return name;
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

            switch (value)
            {
                case "DTS":
                    _currentBluRayTitleAudio.AudioType = EnumAudioType.DTS;
                    _currentBluRayTitleAudio.Arguments = "-core";
                    break;
                case "AC3":
                    _currentBluRayTitleAudio.AudioType = EnumAudioType.AC3;
                    _currentBluRayTitleAudio.Arguments = "";
                    break;
                case "FLAC":
                    _currentBluRayTitleAudio.AudioType = EnumAudioType.FLAC;
                    _currentBluRayTitleAudio.Arguments = "";
                    break;
                case "TrueHD":
                    _currentBluRayTitleAudio.AudioType = EnumAudioType.TrueHD;
                    _currentBluRayTitleAudio.Arguments = "";
                    break;
                case "DTSMA":
                    _currentBluRayTitleAudio.AudioType = EnumAudioType.DTSMA;
                    _currentBluRayTitleAudio.Arguments = "";
                    break;
                case "Wave":
                    _currentBluRayTitleAudio.AudioType = EnumAudioType.WAVE;
                    _currentBluRayTitleAudio.Arguments = "";
                    break;
            }
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

        private bool IsScreenValid()
        {
            if (_bluRaySummaryInfo.BluRayTitleInfo != null && string.IsNullOrEmpty(_bluRaySummaryInfo.BluRayTitleInfo.EpisodeNumber))
            {
                if ((_bluRaySummaryInfo.BluRayTitleInfo.AudioList != null && _bluRaySummaryInfo.BluRayTitleInfo.AudioList.Where(a => a.IsSelected).Count() > 0) 
                    || (_bluRaySummaryInfo.BluRayTitleInfo.Subtitles != null && _bluRaySummaryInfo.BluRayTitleInfo.Subtitles.Where(s => s.IsSelected).Count() > 0)
                    || (_bluRaySummaryInfo.BluRayTitleInfo.Chapter != null && _bluRaySummaryInfo.BluRayTitleInfo.Chapter.IsSelected)
                    || (_bluRaySummaryInfo.BluRayTitleInfo.Video != null  && _bluRaySummaryInfo.BluRayTitleInfo.Video.IsSelected))
                {
                    MessageBox.Show("Please enter an episode number!", "Episode number required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void BluRayTitleInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.IsScreenValid())
            {
                e.Cancel = true; 
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
                dgvSubtitles.Rows[e.RowIndex].Selected = true;
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
                this.LoadScreen();
                txtEpisodeNumber.Focus();
                this.SortAudioGrid(2); //sort language 
                this.SortSubtitleGrid(2); //sort language
                this.AutoSelectEnglishAudio();
                this.AutoSelectEnglishSubtitles();
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

        private void AutoSelectEnglishAudio()
        {
            if (_bluRaySummaryInfo.BluRayTitleInfo != null && _bluRaySummaryInfo.BluRayTitleInfo.AudioList != null)
            {
                foreach (BluRayTitleAudio audio in _bluRaySummaryInfo.BluRayTitleInfo.AudioList.Where(a => a.Text.ToLower().Contains("english")))
                {
                    audio.IsSelected = true;
                }
            }
        }

        private void AutoSelectEnglishSubtitles()
        {
            if (_bluRaySummaryInfo.BluRayTitleInfo != null && _bluRaySummaryInfo.BluRayTitleInfo.Subtitles != null)
            {
                foreach (BluRayTitleSubtitle subtitle in _bluRaySummaryInfo.BluRayTitleInfo.Subtitles.Where(a => a.Text.ToLower().Contains("english")))
                {
                    subtitle.IsSelected = true;
                }
            }
        }
    }
}

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

namespace BatchGuy.App
{
    public partial class BluRayTitleInfoForm : Form
    {
        private BluRayDiscInfo _currentBluRayDisc;
        private BluRaySummaryInfo _bluRaySummaryInfo;
        private BindingList<BluRayTitleAudio> _bindingListBluRayTitleAudio = new BindingList<BluRayTitleAudio>();
        private BindingList<BluRayTitleSubtitle> _bindingListBluRayTitleSubtitle = new BindingList<BluRayTitleSubtitle>();
        private BluRayTitleAudio _currentBluRayTitleAudio;
        private SortConfiguration _audioGridSortConfiguration = new SortConfiguration();
        private SortConfiguration _subtitleGridSortConfiguration = new SortConfiguration();
        
        public BluRayTitleInfoForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        public void SetBluRayTitleInfo(BluRaySummaryInfo bluRaySummaryInfo, BluRayDiscInfo currentBluRayDisc)
        {
            _bluRaySummaryInfo = bluRaySummaryInfo;
            _currentBluRayDisc = currentBluRayDisc;
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
        }

        private void LoadBluRayTitleInfo()
        {
            CommandLineProcessStartInfo commandLineProcessStartInfo = new CommandLineProcessStartInfo()
            {
                FileName = _currentBluRayDisc.EAC3ToConfiguration.EAC3ToPath,
                Arguments = string.Format("\"{0}\" {1}", _currentBluRayDisc.EAC3ToConfiguration.BluRayPath, _bluRaySummaryInfo.Id)
            };
            
            ICommandLineProcessService commandLineProcessService = new CommandLineProcessService(commandLineProcessStartInfo);
            if (commandLineProcessService.Errors.Count() == 0)
            {
                bgwEac3toLoadTitle.RunWorkerAsync(commandLineProcessService);
            }
            else
            {
                MessageBox.Show(commandLineProcessService.Errors.GetErrorMessage(), "Errors Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadScreen()
        {
            this.LoadTitle();
            this.LoadEpisodeNumber();
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

        private void LoadVideo()
        {
            bsBluRayTitleVideo.DataSource = _bluRaySummaryInfo.BluRayTitleInfo.Video;
            chkVideo.Text = string.Format("Track: {0}. Title: {1}.",_bluRaySummaryInfo.BluRayTitleInfo.Video.Id,_bluRaySummaryInfo.BluRayTitleInfo.Video.Text);
            chkVideo.Checked = _bluRaySummaryInfo.BluRayTitleInfo.Video.IsSelected;

        }

        private void LoadAudio()
        {
            foreach (BluRayTitleAudio audio in _bluRaySummaryInfo.BluRayTitleInfo.AudioList)
            {
                _bindingListBluRayTitleAudio.Add(audio);
            }

            bsBluRayTitleAudio.DataSource = _bindingListBluRayTitleAudio;
            _bindingListBluRayTitleAudio.AllowEdit = true;
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
                this.HandleDGVAudioCellClick(e);
                dgvAudio.Rows[e.RowIndex].Selected = true;
            }
        }

        private void HandleDGVAudioCellClick(DataGridViewCellEventArgs e)
        {
            var id = dgvAudio.Rows[e.RowIndex].Cells[1].Value;
            _currentBluRayTitleAudio = _bluRaySummaryInfo.BluRayTitleInfo.AudioList.SingleOrDefault(a => a.Id == id.ToString());
            cbAudioType.SelectedIndex = cbAudioType.FindString(this.GetAudioTypeName(_currentBluRayTitleAudio.AudioType));
            txtAudioTypeArguments.Text = _currentBluRayTitleAudio.Arguments;
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
        }

        private void HandleComboBoxAudioTypeSelectedIndexChanged(string value)
        {
            switch (value)
            {
                case "DTS":
                    _currentBluRayTitleAudio.AudioType = EnumAudioType.DTS;
                    break;
                case "AC3":
                    _currentBluRayTitleAudio.AudioType = EnumAudioType.AC3;
                    break;
                case "FLAC":
                    _currentBluRayTitleAudio.AudioType = EnumAudioType.FLAC;
                    break;
                case "TrueHD":
                    _currentBluRayTitleAudio.AudioType = EnumAudioType.TrueHD;
                    break;
                case "DTSMA":
                    _currentBluRayTitleAudio.AudioType = EnumAudioType.DTSMA;
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
            if (string.IsNullOrEmpty(_bluRaySummaryInfo.BluRayTitleInfo.EpisodeNumber) || _bluRaySummaryInfo.BluRayTitleInfo.EpisodeNumber.IsNumeric() == false)
            {
                MessageBox.Show("Please enter an episode number!", "Invalid episode number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
            this.LoadScreen();
            txtEpisodeNumber.Focus();
            gbScreen.SetEnabled(true);
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
    }
}

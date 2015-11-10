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

namespace BatchGuy.App
{
    public partial class BluRayTitleInfoForm : Form
    {
        private BluRaySummaryInfo _bluRaySummaryInfo;
        private CommandLineProcessStartInfo _commandLineProcessStartInfo;
        private BindingList<BluRayTitleAudio> _bindingListBluRayTitleAudio = new BindingList<BluRayTitleAudio>();
        private BindingList<BluRayTitleSubtitle> _bindingListBluRayTitleSubtitle = new BindingList<BluRayTitleSubtitle>();
        private BluRayTitleAudio _currentBluRayTitleAudio;

        public BluRayTitleInfoForm()
        {
            InitializeComponent();
        }

        public void SetBluRayTitleInfo(BluRaySummaryInfo bluRaySummaryInfo, CommandLineProcessStartInfo commandLineProcessStartInfo)
        {
            _bluRaySummaryInfo = bluRaySummaryInfo;
            _commandLineProcessStartInfo = commandLineProcessStartInfo;
        }

        private void BluRayTitleForm_Load(object sender, EventArgs e)
        {
            if (_bluRaySummaryInfo.BluRayTitleInfo != null)
            {
                this.LoadScreen();   
            }
            else
            {
                this.LoadBluRayTitleInfo();
                this.LoadScreen();
                txtEpisodeNumber.Focus();
            }
        }

        private void LoadBluRayTitleInfo()
        {
            CommandLineProcessStartInfo commandLineProcessStartInfo = new CommandLineProcessStartInfo()
            {
                FileName = _commandLineProcessStartInfo.FileName,
                Arguments = string.Format("{0} {1}", _commandLineProcessStartInfo.Arguments, _bluRaySummaryInfo.Id)
            };
            
            ICommandLineProcessService commandLineProcessService = new CommandLineProcessService(commandLineProcessStartInfo);
            if (commandLineProcessService.Errors.Count() == 0)
            {
                List<ProcessOutputLineItem> processOutputLineItems = commandLineProcessService.GetProcessOutputLineItems();
                ILineItemIdentifierService lineItemService = new BluRayTitleLineItemIdentifierService();
                IBluRayTitleParserService parserService = new BluRayTitleParserService(lineItemService, processOutputLineItems);
                _bluRaySummaryInfo.BluRayTitleInfo = parserService.GetTitleInfo();
            }
            else
            {
                //error handling
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
            this.HandleUpdateClick();
        }

        private void HandleUpdateClick()
        {
            this.Close();
        }

        private void dgvAudio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.HandleDGVAudioCellClick(e);
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
            if (!HelperFunctions.IsNumeric(txtEpisodeNumber.Text))
            {
                //MessageBox.Show("Episode Number must be numberic", "Invalid Episode Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _bluRaySummaryInfo.BluRayTitleInfo.EpisodeNumber = "";
                txtEpisodeNumber.Text = "";
            }
            else
            {
                _bluRaySummaryInfo.BluRayTitleInfo.EpisodeNumber = txtEpisodeNumber.Text;
            }
        }
    }
}

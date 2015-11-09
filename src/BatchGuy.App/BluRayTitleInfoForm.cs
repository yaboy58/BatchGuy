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

namespace BatchGuy.App
{
    public partial class BluRayTitleInfoForm : Form
    {
        private BluRaySummaryInfo _bluRaySummaryInfo;
        private CommandLineProcessStartInfo _commandLineProcessStartInfo;
        private BindingList<BluRayTitleAudio> _bindingListBluRayTitleAudio = new BindingList<BluRayTitleAudio>();

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
            this.LoadVideo();
            this.LoadAudio();
        }

        private void LoadTitle()
        {
            lblTitle.Text = string.Format("Title: {0}", _bluRaySummaryInfo.BluRayTitleInfo.HeaderText);
        }

        private void LoadVideo()
        {
            bsBluRayTitleVideo.DataSource = _bluRaySummaryInfo.BluRayTitleInfo.Video;
            lblVideoText.Text = string.Format("Track: {0}. Title: {1}.",_bluRaySummaryInfo.BluRayTitleInfo.Video.Id,_bluRaySummaryInfo.BluRayTitleInfo.Video.Text);
        }

        private void LoadAudio()
        {
            foreach (BluRayTitleAudio audio in _bluRaySummaryInfo.BluRayTitleInfo.AudioList)
            {
                _bindingListBluRayTitleAudio.Add(audio);
            }

            bsBluRayTitleAudio.DataSource = _bindingListBluRayTitleAudio;
            _bindingListBluRayTitleAudio.AllowEdit = true;

            DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
            col.Name = "Audio Type";
            col.DataSource = Enum.GetValues(typeof(EnumAudioType));
            col.ValueType = typeof(EnumAudioType);
            col.DisplayIndex = 3;
            col.DataPropertyName = EnumAudioType.AC3.ToString();
            dgvAudio.Columns.Add(col);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.HandleUpdateClick();
        }

        private void HandleUpdateClick()
        {
            this.Close();
        }
    }
}

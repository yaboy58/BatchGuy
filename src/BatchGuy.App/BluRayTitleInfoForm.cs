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
            bsBluRayTitleAudio.DataSource = _bluRaySummaryInfo.BluRayTitleInfo.AudioList;
        }


        private void dgvAudio_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAudio.Columns[e.ColumnIndex].Name ==  "IsSelected")
            {
                var id = dgvAudio.Rows[e.RowIndex].Cells[0].Value;
                bool isSelected = (bool) dgvAudio.Rows[e.RowIndex].Cells[4].Value;
               BluRayTitleAudio audio =  _bluRaySummaryInfo.BluRayTitleInfo.AudioList.SingleOrDefault(a => a.Id == id.ToString());
               audio.IsSelected = isSelected;
            }
        }
    }
}

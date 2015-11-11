using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatchGuy.App.EAC.Models;
using BatchGuy.App.EAC.Services;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Parser.Services;
using BatchGuy.App.EAC.Interfaces;
using BatchGuy.App.Parser.Interfaces;
using BatchGuy.App.Enums;
using BatchGuy.App.Helpers;

namespace BatchGuy.App
{
    public partial class CreateEAC3ToBatchForm : Form
    {
        private List<BluRayDiscInfo> _bluRayDiscInfoList;
        private BluRayDiscInfo _currentBluRayDiscInfo;
        private CommandLineProcessStartInfo _commandLineProcessStartInfo;
        private BindingList<BluRayDiscInfo> _bindingListBluRayDiscInfo = new BindingList<BluRayDiscInfo>();
        private BindingList<BluRaySummaryInfo> _bindingListBluRaySummaryInfo;


        public CreateEAC3ToBatchForm()
        {
            InitializeComponent();
        }

        private void CreateEAC3ToBatchForm_Load(object sender, EventArgs e)
        {
        }

        private void btnWriteToBatFile_Click(object sender, EventArgs e)
        {
            if (this.IsAtLeastOneDiscLoaded())
            {
                this.WriteToBatchFile();                
            }
        }

        private void WriteToBatchFile()
        {
            IBatchFileWriteService batchFileWriteService = new BatchFileWriteService(_bluRayDiscInfoList);
            batchFileWriteService.Write();
            if (batchFileWriteService.Errors.Count() == 0)
            {
                MessageBox.Show("Batch File created!", "Process Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();   
            }
            else
            {
                MessageBox.Show(string.Format("Error: {0}", batchFileWriteService.Errors[0].Description), "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddBluRayDisc_Click(object sender, EventArgs e)
        {
            if (this.IsScreenValid())
            {
                this.HandleAddBluRayDiscClick();
                txtBluRayPath.Text = string.Empty;                
            }
        }

        private void HandleAddBluRayDiscClick()
        {
            if (_bluRayDiscInfoList == null)
                _bluRayDiscInfoList = new List<BluRayDiscInfo>();

            BluRayDiscInfo info = new BluRayDiscInfo()
            {
                Id = _bluRayDiscInfoList.Count + 1,
                IsSelected = false,
                EAC3ToConfiguration = new EAC3ToConfiguration()
                {
                    BatchFilePath = txtBatFilePath.Text,
                    BluRayPath = txtBluRayPath.Text,
                    EAC3ToPath = txtEAC3ToPath.Text
                }
            };

            _bluRayDiscInfoList.Add(info);
            _bindingListBluRayDiscInfo.Add(info);

            bsBluRayDiscInfo.DataSource = _bindingListBluRayDiscInfo;
        }

        private void dgvBluRayDiscInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.HandleDgvBluRayDiscInfoCellClick(e);
            if (_currentBluRayDiscInfo.BluRaySummaryInfoList == null)
            {
                this.HandleLoadBluRay();
            }
            else
            {
                _bindingListBluRaySummaryInfo = new BindingList<BluRaySummaryInfo>();
                foreach (BluRaySummaryInfo info in _currentBluRayDiscInfo.BluRaySummaryInfoList)
                {
                    _bindingListBluRaySummaryInfo.Add(info);
                }
            }
            this.BindDgvBluRaySummaryGrid();
            gbDiscSummary.Text = string.Format("Disc Summary: {0}", _currentBluRayDiscInfo.DiscName);
            dgvBluRayDiscInfo.Rows[e.RowIndex].Selected = true;
        }

        private void HandleDgvBluRayDiscInfoCellClick(DataGridViewCellEventArgs e)
        {
            var id = dgvBluRayDiscInfo.Rows[e.RowIndex].Cells[1].Value;
            _currentBluRayDiscInfo = _bluRayDiscInfoList.SingleOrDefault(d => d.Id == HelperFunctions.StringToInt(id.ToString()));
        }

        private void HandleLoadBluRay()
        {
            _bindingListBluRaySummaryInfo = new BindingList<BluRaySummaryInfo>();

            //Blu ray streams
            _commandLineProcessStartInfo = new CommandLineProcessStartInfo()
            {
                FileName = txtEAC3ToPath.Text,
                Arguments = string.Format("\"{0}\"", _currentBluRayDiscInfo.EAC3ToConfiguration.BluRayPath)
            };

            ICommandLineProcessService commandLineProcessService = new CommandLineProcessService(_commandLineProcessStartInfo);
            if (commandLineProcessService.Errors.Count() == 0)
            {
                //Get line items
                List<ProcessOutputLineItem> processOutputLineItems = commandLineProcessService.GetProcessOutputLineItems();
                ////:Get the Blu ray summary list
                ILineItemIdentifierService lineItemService = new BluRaySummaryLineItemIdentifierService();
                IBluRaySummaryParserService parserService = new BluRaySummaryParserService(lineItemService, processOutputLineItems);
                _currentBluRayDiscInfo.BluRaySummaryInfoList = parserService.GetSummaryList();

                foreach (BluRaySummaryInfo info in _currentBluRayDiscInfo.BluRaySummaryInfoList)
                {
                    _bindingListBluRaySummaryInfo.Add(info);
                }
            }
            else
            {
                System.Console.WriteLine("The following errors were found:");
                foreach (var error in commandLineProcessService.Errors)
                {
                    //TODO:Display Error Message
                }
            }
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
            var id = dgvBluRaySummary.Rows[e.RowIndex].Cells[1].Value;
            BluRaySummaryInfo summaryInfo = _currentBluRayDiscInfo.BluRaySummaryInfoList.SingleOrDefault(s => s.Id == id.ToString());

            BluRayTitleInfoForm form = new BluRayTitleInfoForm();
            form.SetBluRayTitleInfo(summaryInfo, _currentBluRayDiscInfo);
            form.ShowDialog();
            this.BindDgvBluRaySummaryGrid();
        }

        private bool IsScreenValid()
        {
            if (txtBatFilePath.Text == string.Empty)
            {
                MessageBox.Show("Please enter the path the batch file should be created!", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;    
            }
            if (txtBluRayPath.Text == string.Empty)
            {
                MessageBox.Show("Please enter the path where the blu-ray disc is located!", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtEAC3ToPath.Text == string.Empty)
            {
                MessageBox.Show("Please enter the eac3to.exe path with the exe in the path!", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool IsAtLeastOneDiscLoaded()
        {
            if (_bluRayDiscInfoList == null || _bluRayDiscInfoList.Count() == 0)
            {
                MessageBox.Show("Please load at least 1 blu-ray disck!", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void dgvBluRaySummary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvBluRaySummary.Rows[e.RowIndex].Selected = true;
        }

        private void btnOpenBluRayPathDialog_Click(object sender, EventArgs e)
        {
            this.HandleBtnOpenBluRayPathDialogClick();
        }

        private void HandleBtnOpenBluRayPathDialogClick()
        {
            
            fbdDialog.ShowNewFolderButton = true;
            fbdDialog.RootFolder = Environment.SpecialFolder.Desktop;
            DialogResult result = fbdDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtBluRayPath.Text = fbdDialog.SelectedPath;
            }
        }

        private void btnOpenEac3ToFileDialog_Click(object sender, EventArgs e)
        {
            this.HandleOpenEac3ToFileDialogClick();
        }

        private void HandleOpenEac3ToFileDialogClick()
        {
            DialogResult result = ofdFileDialog.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtEAC3ToPath.Text = ofdFileDialog.FileName;
            }
        }

        private void btnOpenBatchFilePathDialog_Click(object sender, EventArgs e)
        {
            this.HandleBtnOpenBatchFilePathDialogClick();
        }

        private void HandleBtnOpenBatchFilePathDialogClick()
        {
            fbdDialog.ShowNewFolderButton = true;
            fbdDialog.RootFolder = Environment.SpecialFolder.Desktop;
            DialogResult result = fbdDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
               txtBatFilePath.Text= fbdDialog.SelectedPath;
            }
        }
    }
}

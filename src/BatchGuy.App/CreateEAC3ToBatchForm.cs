using System;
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

namespace BatchGuy.App
{
    public partial class CreateEAC3ToBatchForm : Form
    {
        private List<BluRayDiscInfo> _bluRayDiscInfoList;
        private BluRayDiscInfo _currentBluRayDiscInfo;
        private CommandLineProcessStartInfo _commandLineProcessStartInfo;
        private BindingList<BluRayDiscInfo> _bindingListBluRayDiscInfo = new BindingList<BluRayDiscInfo>();
        private BindingList<BluRaySummaryInfo> _bindingListBluRaySummaryInfo;
        private int _currentBluRayDiscGridRowIndex;
        private SortConfiguration _bluRaySummaryGridSortConfiguration = new SortConfiguration();
        private SortConfiguration _bluRayDiscGridSortConfiguration = new SortConfiguration();

        public CreateEAC3ToBatchForm()
        {
            InitializeComponent();
#if DEBUG
            txtBluRayPath.Text = @"C:\temp\My Encodes\Blu-ray\DISC\D1";   
            txtEAC3ToPath.Text = @"C:\exe\eac3to\eac3to.exe";
            txtBatFilePath.Text = @"C:\temp\My Encodes\Blu-ray";
#endif
            
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
            gbScreen.SetEnabled(false);
            IBatchFileWriteService batchFileWriteService = new BatchFileWriteService(_bluRayDiscInfoList);
            bgwEac3toWriteBatchFile.RunWorkerAsync(batchFileWriteService);
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
            var id = dgvBluRayDiscInfo.Rows[e.RowIndex].Cells[1].Value;
            _currentBluRayDiscInfo = _bluRayDiscInfoList.SingleOrDefault(d => d.Id == id.ToString().StringToInt());
            _currentBluRayDiscGridRowIndex = e.RowIndex;
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
            if (e.RowIndex == -1)
            {
                this.SortBluRaySummaryGrid(e.ColumnIndex);
            }
            else
            {
                dgvBluRaySummary.Rows[e.RowIndex].Selected = true;
            }
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
            IBatchFileWriteService batchFileWriteService = e.Argument as BatchFileWriteService;
            batchFileWriteService.Write();
            e.Result = batchFileWriteService;
        }

        private void bgwEac3toWriteBatchFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            IBatchFileWriteService batchFileWriteService = e.Result as BatchFileWriteService;
            if (batchFileWriteService.Errors.Count() == 0)
            {
                MessageBox.Show("Batch File created!", "Process Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                MessageBox.Show(string.Format("Error: {0}", batchFileWriteService.Errors[0].Description), "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            gbScreen.SetEnabled(true);
        }

        private void SortBluRayDiscGrid(int sortColumnNumber)
        {
            if (_bluRayDiscInfoList == null)
                return;

            string sortColumnName = dgvBluRayDiscInfo.Columns[sortColumnNumber].DataPropertyName;
            _bluRayDiscGridSortConfiguration.SortByColumnName = sortColumnName;
            ISortService<BluRayDiscInfo> sortService = new SortService<BluRayDiscInfo>(_bluRayDiscGridSortConfiguration, _bluRayDiscInfoList);

            IBindingListSortService<BluRayDiscInfo> bindingListSortService = new BindingListSortService<BluRayDiscInfo>(_bluRayDiscInfoList, dgvBluRayDiscInfo, _bluRayDiscGridSortConfiguration, sortService);
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

    }
}

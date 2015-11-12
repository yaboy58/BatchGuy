using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatchGuy.App;

namespace BatchGuy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void createAVSFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAviSynthFilesForm form = new CreateAviSynthFilesForm();
            form.ShowDialog();
        }

        private void createEac3ToBatFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateEAC3ToBatchForm form = new CreateEAC3ToBatchForm();
            form.ShowDialog();
        }

        private void createX264BatFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateX264BatchFileForm form = new CreateX264BatchFileForm();
            form.ShowDialog();
        }
    }
}

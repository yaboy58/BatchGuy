using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviSynthBatchScriptCreator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void createAVSFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAVSFilesForm form = new CreateAVSFilesForm();
            form.ShowDialog();
        }
    }
}

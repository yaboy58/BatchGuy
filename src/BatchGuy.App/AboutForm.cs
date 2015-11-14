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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            lblVersion.Text = string.Format("Version: {0}.{1}", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major.ToString(), System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString());
        }
    }
}

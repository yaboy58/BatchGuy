using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatchGuy.App.AVS.Models;
using BatchGuy.App.AVS.Services;
using BatchGuy.App.Models;

namespace BatchGuy
{
    public partial class CreateAVSFilesForm : Form
    {
        private AVSScript _avsScript;
        private IFileService _fileService;
        private IValidationService _validationService;
        private AVSBatchSettings _avsBatchSettings;

        public CreateAVSFilesForm()
        {
            InitializeComponent();
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {

        }

        private List<Error> Process()
        {
            return null;
        }
    }
}

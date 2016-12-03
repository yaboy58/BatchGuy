using BatchGuy.App.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Shared.Models;
using System.Windows.Forms;

namespace BatchGuy.App.Shared.Services
{
    public class DisplayErrorMessageService : IDisplayErrorMessageService
    {
        private ILoggingService _loggingService = new LoggingService(Program.GetLogErrorFormat());

        public void DisplayError(ErrorMessage message)
        {
            MessageBox.Show(string.Format("{0}.  Please view the error log for more details.", message.DisplayMessage), message.DisplayTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void LogAndDisplayError(ErrorMessage message)
        {
            _loggingService.LogErrorFormat(message.Exception, message.MethodNameWhereExceptionOccurred);
            MessageBox.Show(string.Format("{0}.  Please view the error log for more details.",message.DisplayMessage), message.DisplayTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

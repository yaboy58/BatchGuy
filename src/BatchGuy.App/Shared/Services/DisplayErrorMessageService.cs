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

        public void DisplayError(ErrorMessage errorMessage)
        {
            _loggingService.LogErrorFormat(errorMessage.ExceptionMessage, errorMessage.MethodNameWhereExceptionOccurred);
            MessageBox.Show(errorMessage.DisplayMessage, errorMessage.DisplayTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

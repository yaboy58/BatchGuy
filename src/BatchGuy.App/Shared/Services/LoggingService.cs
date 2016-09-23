using BatchGuy.App.Shared.Interfaces;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Shared.Services
{
    public class LoggingService : ILoggingService
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(LoggingService));
        private string _logErrorFormat = string.Empty;

        public LoggingService(string logErrorFormat)
        {
            _logErrorFormat = logErrorFormat;
        }

        public void LogErrorFormat(string exceptionMessage, string methodName)
        {
            _log.ErrorFormat(_logErrorFormat, exceptionMessage, methodName);
        }
    }
}

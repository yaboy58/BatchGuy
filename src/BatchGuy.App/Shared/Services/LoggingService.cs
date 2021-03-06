﻿using BatchGuy.App.Shared.Interfaces;
using log4net;
using System;

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

        public void LogErrorFormat(Exception exception, string methodName)
        {
            _log.ErrorFormat(_logErrorFormat, exception.Message, exception.StackTrace, methodName);
        }
    }
}

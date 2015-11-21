using BatchGuy.App.Shared.Models;
using BatchGuy.App.X264Log.Interfaces;
using BatchGuy.App.X264Log.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.X264Log.Services
{
    public class X264LogParserService : IX264LogParserService
    {
        private ErrorCollection _errors;
        private IX264LogLineItemIdentifierService _x264LogLineItemIdentifierService;
        private X264LogFileSettings _x264LogFileSerttings;
        private List<X264LogFile> _logFiles;

        public ErrorCollection Errors
        {
            get { return _errors; }
        }

        public X264LogParserService(IX264LogLineItemIdentifierService x264LogLineItemIdentifierService, X264LogFileSettings x264LogFileSerttings, List<X264LogFile> logFiles)
        {
            _x264LogLineItemIdentifierService = x264LogLineItemIdentifierService;
            _x264LogFileSerttings = x264LogFileSerttings;
            _logFiles = logFiles;
        }
        public string GetLogs()
        {
            throw new NotImplementedException();
        }
    }
}

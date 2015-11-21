using BatchGuy.App.Shared.Models;
using BatchGuy.App.X264Log.Interfaces;
using BatchGuy.App.X264Log.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BatchGuy.App.Enums;

namespace BatchGuy.App.X264Log.Services
{
    public class X264LogParserService : IX264LogParserService
    {
        private ErrorCollection _errors;
        private IX264LogLineItemIdentifierService _x264LogLineItemIdentifierService;
        private X264LogFileSettings _x264LogFileSerttings;
        private List<X264LogFile> _logFiles;
        private string _logs = string.Empty;

        public ErrorCollection Errors
        {
            get { return _errors; }
        }

        public string Logs
        {
            get { return _logs; }
        }

        public X264LogParserService(IX264LogLineItemIdentifierService x264LogLineItemIdentifierService, X264LogFileSettings x264LogFileSerttings, List<X264LogFile> logFiles)
        {
            _x264LogLineItemIdentifierService = x264LogLineItemIdentifierService;
            _x264LogFileSerttings = x264LogFileSerttings;
            _logFiles = logFiles;
            _errors = new ErrorCollection();
        }
        public string GetLogs()
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                sb.AppendLine("[pre]");
                sb.AppendLine("[quote]");
                sb.AppendLine("[b]x264 Logs[/b]");
                sb.AppendLine();

                if (_x264LogFileSerttings.BBCodeHiddenAroundLogs)
                    sb.AppendLine("[hide]");

                foreach (X264LogFile logFile in _logFiles.OrderBy(l => l.FileNameOnly))
                {
                    if (_x264LogFileSerttings.BBCodeBoldLogFileName)
                        sb.AppendLine(string.Format("[b]{0}[/b]", logFile.FileNameOnly));
                    else
                        sb.AppendLine(string.Format("{0}", logFile.FileNameOnly));

                    sb.AppendLine();

                    using (StreamReader sw = new StreamReader(logFile.FilePath))
                    {
                        while (true)
                        {
                            string line = sw.ReadLine();
                            if (line != null)
                            {
                                EnumX264LogLineItemType lineItemType = _x264LogLineItemIdentifierService.GetLineItemType(line);
                                if (lineItemType != EnumX264LogLineItemType.None)
                                {
                                    sb.AppendLine(line);
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        sb.AppendLine();
                    }
                }

                if (_x264LogFileSerttings.BBCodeHiddenAroundLogs)
                    sb.AppendLine("[/hide]");

                sb.AppendLine("[/quote]");
                sb.AppendLine("[/pre]");
            }
            catch (Exception ex)
            {
                _errors.Add(new Error() { Description = string.Format("Error: {0}", ex.Message) });
            }

            _logs = sb.ToString();

            return sb.ToString();
        }
    }
}

using BatchGuy.App.Enums;
using BatchGuy.App.Parser.Interfaces;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Models;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BatchGuy.App.Parser.Services
{
    public class BluRaySummaryParserService : IBluRaySummaryParserService
    {
        private ILineItemIdentifierService _lineItemIdentifierService;
        private List<ProcessOutputLineItem> _processOutputLineItems;
        private List<BluRaySummaryInfo> _summaryList;
        private ErrorCollection _errors;

        public static readonly ILog _log = LogManager.GetLogger(typeof(BluRaySummaryParserService));

        public ErrorCollection Errors
        {
            get { return _errors; }
        }

        public BluRaySummaryParserService(ILineItemIdentifierService lineItemIdentifierService, List<ProcessOutputLineItem> processOutputLineItems)
        {
            _lineItemIdentifierService = lineItemIdentifierService;
            _processOutputLineItems = processOutputLineItems;
            _summaryList = new List<BluRaySummaryInfo>();
            _errors = new ErrorCollection();
        }

        public List<BluRaySummaryInfo> GetSummaryList()
        {
            StringBuilder sbHeader = null;
            StringBuilder sbDetail = null;
            BluRaySummaryInfo summaryInfo = null;

            try
            {
                foreach (ProcessOutputLineItem item in _processOutputLineItems)
                {
                    EnumBluRayLineItemType type = _lineItemIdentifierService.GetLineItemType(item);
                    switch (type)
                    {
                        case EnumBluRayLineItemType.BluRaySummaryHeaderLine:
                            if (this.IsIdHeader(item))
                            {
                                sbHeader = new StringBuilder();
                                sbDetail = new StringBuilder();
                                summaryInfo = new BluRaySummaryInfo();
                                summaryInfo.Id = this.GetId(item);
                                sbHeader.Append(item.Text);
                            }
                            else
                            {
                                sbHeader.AppendLine(string.Format(" {0}", item.Text));
                            }
                            break;
                        case EnumBluRayLineItemType.BluRaySummaryDetailLine:
                            sbDetail.AppendLine(item.Text);
                            break;
                        case EnumBluRayLineItemType.BluRaySummaryEmptyLine:
                            summaryInfo.HeaderText = sbHeader.ToString();
                            summaryInfo.DetailText = sbDetail.ToString();
                            _summaryList.Add(summaryInfo);
                            break;
                        case EnumBluRayLineItemType.BluRayError:
                            throw new Exception(item.Text);
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                _log.ErrorFormat(Program.GetLogErrorFormat(), ex.Message, MethodBase.GetCurrentMethod().Name);
                _errors.Add(new Error() { Description = "There was an error trying to parse the blu-ray disc" });
            }

            return _summaryList;
        }

        public bool IsIdHeader(ProcessOutputLineItem lineItem)
        {
            string firstPhrase = this.GetId(lineItem);
            string pattern = @"^(\d+)\)";
            Regex regEx = new Regex(pattern, RegexOptions.IgnoreCase);

            bool isMatch = regEx.IsMatch(firstPhrase);

            return isMatch;
        }

        public string GetId(ProcessOutputLineItem lineItem)
        {
            string[] splitted = lineItem.Text.Split(' ');
            return splitted[0];
        }
    }
}

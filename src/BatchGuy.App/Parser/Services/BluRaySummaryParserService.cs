using BatchGuy.App.Parser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Parser.Services
{
    public class BluRaySummaryParserService : IBluRaySummaryParserService
    {
        private ILineItemIdentifierService _lineItemIdentifierService;
        private List<ProcessOutputLineItem> _processOutputLineItems;
        private List<BluRaySummaryInfo> _summaryList;

        public BluRaySummaryParserService(ILineItemIdentifierService lineItemIdentifierService, List<ProcessOutputLineItem> processOutputLineItems)
        {
            _lineItemIdentifierService = lineItemIdentifierService;
            _processOutputLineItems = processOutputLineItems;
            _summaryList = new List<BluRaySummaryInfo>();
        }

        public List<BluRaySummaryInfo> GetSummaryList()
        {
            StringBuilder sbHeader = null;
            StringBuilder sbDetail = null;
            BluRaySummaryInfo summaryInfo = null;

            foreach (ProcessOutputLineItem item in _processOutputLineItems)
            {
                EnumLineItemType type = _lineItemIdentifierService.GetLineItemType(item);
                switch (type)
                {
                    case EnumLineItemType.BluRaySummaryHeaderLine:
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
                            sbHeader.AppendLine(string.Format(" {0}",item.Text));
                        }
                        break;
                    case EnumLineItemType.BluRaySummaryDetailLine:
                        sbDetail.AppendLine(item.Text);
                        break;
                    case EnumLineItemType.BluRaySummaryEmptyLine:
                        summaryInfo.HeaderText = sbHeader.ToString();
                        summaryInfo.DetailText = sbDetail.ToString();
                        _summaryList.Add(summaryInfo);
                        break;
                    default:
                        break;
                }
            }
            return _summaryList;
        }

        public bool IsIdHeader(ProcessOutputLineItem lineItem)
        {
            bool isId = lineItem.Text.Contains(")");
            return isId;
        }

        public string GetId(ProcessOutputLineItem lineItem)
        {
            string[] splitted = lineItem.Text.Split(' ');
            return splitted[0];
        }
    }
}

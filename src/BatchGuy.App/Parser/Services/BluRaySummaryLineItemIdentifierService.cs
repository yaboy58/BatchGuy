using BatchGuy.App.Enums;
using BatchGuy.App.Parser.Interfaces;
using BatchGuy.App.Parser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Parser.Services
{
    public class BluRaySummaryLineItemIdentifierService : ILineItemIdentifierService
    {
        public EnumBluRayLineItemType GetLineItemType(ProcessOutputLineItem processOutputLineItem)
        {
            EnumBluRayLineItemType type;

            if (this.IsHeaderLine(processOutputLineItem))
            {
                type = EnumBluRayLineItemType.BluRaySummaryHeaderLine;
            }
            else if (this.IsDetailLine(processOutputLineItem))
            {
                type = EnumBluRayLineItemType.BluRaySummaryDetailLine;    
            }
            else if (this.IsEmptyLine(processOutputLineItem))
            {
                type = EnumBluRayLineItemType.BluRaySummaryEmptyLine;
            }
            else
            {
                type = EnumBluRayLineItemType.BluRayError;
            }

            return type;
        }

        private bool IsHeaderLine(ProcessOutputLineItem processOutputLineItem)
        {
            string[] values = new string[] { ".mpls", ".m2ts" };

            bool isHeader = values.Any(v => processOutputLineItem.Text.ToLower().Contains(v));

            return isHeader;
        }

        private bool IsDetailLine(ProcessOutputLineItem processOutputLineItem)
        {
            string[] values = new string[] { "chapters", "h264", "dts", "ac3", "pcm", "stero", "raw","truehd","avc","mpeg2","vc-1" };

            bool isDetail = values.Any(v => processOutputLineItem.Text.ToLower().Contains(v));

            return isDetail;
        }

        private bool IsEmptyLine(ProcessOutputLineItem processOutputLineItem)
        {
            if (processOutputLineItem.Text == "")
                return true;
            else
                return false;
        }
    }
}

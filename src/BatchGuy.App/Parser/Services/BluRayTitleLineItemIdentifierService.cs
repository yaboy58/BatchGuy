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
    public class BluRayTitleLineItemIdentifierService : ILineItemIdentifierService
    {
        public EnumLineItemType GetLineItemType(ProcessOutputLineItem processOutputLineItem)
        {
            EnumLineItemType type;

            if (this.IsHeaderLine(processOutputLineItem))
            {
                type = EnumLineItemType.BluRayTitleHeaderLine;
            }
            else if (this.IsChapterLine(processOutputLineItem))
            {
                type = EnumLineItemType.BluRayTitleChapterLine;
            }
            else if (this.IsVideoLine(processOutputLineItem))
            {
                type = EnumLineItemType.BluRayTitleVideoLine;
            }
            else if (this.IsAudioLine(processOutputLineItem))
            {
                type = EnumLineItemType.BluRayTitleAudioLine;
            }
            else if (this.IsSubtitleLine(processOutputLineItem))
            {
                type = EnumLineItemType.BluRayTitleSubtitleLine;
            }
            else
            {
                type = EnumLineItemType.BluRayTitleEmptyLine;
            }
            return type;
        }

        private bool IsHeaderLine(ProcessOutputLineItem processOutputLineItem)
        {
            string[] values = new string[] { "track" };

            bool isHeader = values.Any(v => processOutputLineItem.Text.ToLower().Contains(v));

            return isHeader;
        }

        private bool IsChapterLine(ProcessOutputLineItem processOutputLineItem)
        {
            string[] values = new string[] { "chapters" };

            bool isChapter = values.Any(v => processOutputLineItem.Text.ToLower().Contains(v));

            return isChapter;
        }

        private bool IsVideoLine(ProcessOutputLineItem processOutputLineItem)
        {
            string[] values = new string[] { "h264","avc","1080","video", "mpeg-4" };

            bool isChapter = values.Any(v => processOutputLineItem.Text.ToLower().Contains(v));

            return isChapter;
        }

        private bool IsAudioLine(ProcessOutputLineItem processOutputLineItem)
        {
            string[] values = new string[] { "dts", "audio", "channels", "ac3", "pcm", "truehd" };

            bool isChapter = values.Any(v => processOutputLineItem.Text.ToLower().Contains(v));

            return isChapter;
        }

        private bool IsSubtitleLine(ProcessOutputLineItem processOutputLineItem)
        {
            string[] values = new string[] { "pgs" };

            bool isChapter = values.Any(v => processOutputLineItem.Text.ToLower().Contains(v));

            return isChapter;
        }
    }
}

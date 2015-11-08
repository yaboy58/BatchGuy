using BatchGuy.App.Enums;
using BatchGuy.App.Parser.Interfaces;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Parser.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssert;

namespace BatchGuy.Unit.Tests.Services.Parser
{
    [TestFixture]
    public class BluRayTitleLineItemIdentifierServiceTests
    {
        [Test]
        public void bluraytitlelineitemidentifierservice_can_identify_bluray_header_line_item_test()
        {
            ProcessOutputLineItem lineItem = new ProcessOutputLineItem() { Id = 1, Text = "M2TS, 1 video track, 1 audio track, 1 subtitle track, 0:58:28, 50i" };
            ILineItemIdentifierService service = new BluRayTitleLineItemIdentifierService();
            EnumLineItemType type = service.GetLineItemType(lineItem);
            type.ShouldBeEqualTo(EnumLineItemType.BluRayTitleHeaderLine);
        }

        [Test]
        public void bluraytitlelineitemidentifierservice_can_identify_bluray_chapter_line_item_test()
        {
            ProcessOutputLineItem lineItem = new ProcessOutputLineItem() { Id = 1, Text = "1: Chapters, 6 chapters" };
            ILineItemIdentifierService service = new BluRayTitleLineItemIdentifierService();
            EnumLineItemType type = service.GetLineItemType(lineItem);
            type.ShouldBeEqualTo(EnumLineItemType.BluRayTitleChapterLine);
        }

        [Test]
        public void bluraytitlelineitemidentifierservice_can_identify_bluray_video_line_item_test()
        {
            ProcessOutputLineItem lineItem = new ProcessOutputLineItem() { Id = 1, Text = "2: h264/AVC, 1080i50 (16:9)" };
            ILineItemIdentifierService service = new BluRayTitleLineItemIdentifierService();
            EnumLineItemType type = service.GetLineItemType(lineItem);
            type.ShouldBeEqualTo(EnumLineItemType.BluRayTitleVideoLine);
        }

        [Test]
        public void bluraytitlelineitemidentifierservice_can_identify_bluray_audio_line_item_test()
        {
            ProcessOutputLineItem lineItem = new ProcessOutputLineItem() { Id = 1, Text = "3: DTS Master Audio, French, 5.1 channels, 24 bits, 48kHz" };
            ILineItemIdentifierService service = new BluRayTitleLineItemIdentifierService();
            EnumLineItemType type = service.GetLineItemType(lineItem);
            type.ShouldBeEqualTo(EnumLineItemType.BluRayTitleAudioLine);
        }

        [Test]
        public void bluraytitlelineitemidentifierservice_can_identify_bluray_subtitle_line_item_test()
        {
            ProcessOutputLineItem lineItem = new ProcessOutputLineItem() { Id = 1, Text = "4: Subtitle (pgs), French" };
            ILineItemIdentifierService service = new BluRayTitleLineItemIdentifierService();
            EnumLineItemType type = service.GetLineItemType(lineItem);
            type.ShouldBeEqualTo(EnumLineItemType.BluRayTitleSubtitleLine);
        }

        [Test]
        public void bluraytitlelineitemidentifierservice_can_identify_bluray_empty_line_item_test()
        {
            ProcessOutputLineItem lineItem = new ProcessOutputLineItem() { Id = 1, Text = "" };
            ILineItemIdentifierService service = new BluRayTitleLineItemIdentifierService();
            EnumLineItemType type = service.GetLineItemType(lineItem);
            type.ShouldBeEqualTo(EnumLineItemType.BluRayTitleEmptyLine);
        }
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssert;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Parser.Services;
using BatchGuy.App.Parser.Interfaces;

namespace BatchGuy.Unit.Tests.Services.Parser
{
    [TestFixture]
    public class BluRaySummaryParserServiceTests
    {
        [Test]
        public void bluraysummaryparserservice_can_set_summary_id_test()
        {
            List<ProcessOutputLineItem> lineItems = new List<ProcessOutputLineItem> 
            {
                new ProcessOutputLineItem()  { Id = 1, Text = "1) 00010.mpls, 3:04:31" },
                new ProcessOutputLineItem()  { Id = 2, Text = "- [0+3+4+5].m2ts" },
                new ProcessOutputLineItem()  { Id = 3, Text = "- h264/AVC, 1080p24 /1.001 (16:9)" },
                new ProcessOutputLineItem()  { Id = 4, Text = "- DTS Master Audio, Swedish, multi-channel, 48kHz" } ,
                new ProcessOutputLineItem()  { Id = 5, Text = "- AC3, Swedish, multi-channel, 48kHz" },
                new ProcessOutputLineItem()  { Id = 6, Text = "" } 
            };
            ILineItemIdentifierService lineItemService = new BluRaySummaryLineItemIdentifierService();
            IBluRaySummaryParserService parserService = new BluRaySummaryParserService(lineItemService, lineItems);
            List<BluRaySummaryInfo> summaryList = parserService.GetSummaryList();

            summaryList[0].Id.ShouldBeEqualTo("1)");
        }
    }
}

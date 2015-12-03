using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;
using BatchGuy.App.X264Log.Interfaces;
using BatchGuy.App.X264Log.Services;
using BatchGuy.App.Enums;

namespace BatchGuy.Unit.Tests.Services.X264Log
{
    [TestFixture]
    public class X264LogLineItemIdentifierServiceTests
    {
        [Test]
       public void x264loglineitemidentifierservice_can_identify_iframe_lineitem_test()
        {
            //given a iframe line item
            string lineItem = "x264 [info]: frame I:417   Avg QP:12.56  size:134237";
            //when i attempt to identify it
            IX264LogLineItemIdentifierService service = new X264LogLineItemIdentifierService();
            EnumX264LogLineItemType lineItemType = service.GetLineItemType(lineItem);
            //then line item type is iframe
            lineItemType.Should().Be(EnumX264LogLineItemType.IFrame);
        }

        [Test]
        public void x264loglineitemidentifierservice_can_identify_pframe_lineitem_test()
        {
            //given a pframe line item
            string lineItem = "x264 [info]: frame P:14240 Avg QP:14.42  size: 52055";
            //when i attempt to identify it
            IX264LogLineItemIdentifierService service = new X264LogLineItemIdentifierService();
            EnumX264LogLineItemType lineItemType = service.GetLineItemType(lineItem);
            //then line item type is pframe
            lineItemType.Should().Be(EnumX264LogLineItemType.PFrame);
        }

        [Test]
        public void x264loglineitemidentifierservice_can_identify_bframe_lineitem_test()
        {
            //given a bframe line item
            string lineItem = "x264 [info]: frame B:59868 Avg QP:16.37  size: 19269";
            //when i attempt to identify it
            IX264LogLineItemIdentifierService service = new X264LogLineItemIdentifierService();
            EnumX264LogLineItemType lineItemType = service.GetLineItemType(lineItem);
            //then line item type is bframe
            lineItemType.Should().Be(EnumX264LogLineItemType.BFrame);
        }

        [Test]
        public void x264loglineitemidentifierservice_can_identify_consecutivebframes_lineitem_test()
        {
            //given a consecutive b frames line item
            string lineItem = "x264 [info]: consecutive B-frames:  1.1%  1.7%  5.0%  8.2% 17.7% 47.3% 11.8%  3.3%  3.8%";
            //when i attempt to identify it
            IX264LogLineItemIdentifierService service = new X264LogLineItemIdentifierService();
            EnumX264LogLineItemType lineItemType = service.GetLineItemType(lineItem);
            //then line item type is consecutive b frames
            lineItemType.Should().Be(EnumX264LogLineItemType.ConsecutiveBFrames);
        }

        [Test]
        public void x264loglineitemidentifierservice_can_identify_encodedframes_lineitem_test()
        {
            //given a encoded frames line item
            string lineItem = "encoded 74525 frames, 2.48 fps, 5235.46 kb/s";
            //when i attempt to identify it
            IX264LogLineItemIdentifierService service = new X264LogLineItemIdentifierService();
            EnumX264LogLineItemType lineItemType = service.GetLineItemType(lineItem);
            //then line item type is encode frames
            lineItemType.Should().Be(EnumX264LogLineItemType.EncodedFrames);
        }
    }
}

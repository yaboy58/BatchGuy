using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;
using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Eac3To.Services;
using BatchGuy.App.MKVMerge.Interfaces;
using BatchGuy.App.MKVMerge.Services;

namespace BatchGuy.Unit.Tests.Services.MKVMerge
{
    [TestFixture]
    public class MKVMergeOutputServiceTests
    {
        [Test]
        public void mkvmergeoutputservice_can_getmkvmergepathPart_Tests()
        {
            //given
            EAC3ToConfiguration config = new EAC3ToConfiguration() {  MKVMergePath = "c:\\exe\\mkvmerge.exe" };
            BluRaySummaryInfo bluRaySummaryInfo = new BluRaySummaryInfo() { Eac3ToId = "1)", BluRayTitleInfo = new BluRayTitleInfo() { EpisodeNumber = "1" } };
            IEAC3ToOutputNamingService eac3ToOutputNamingService = new EAC3ToOutputNamingService();
            //when
            IMKVMergeOutputService mkvMergeOutputService = new MKVMergeOutputService(config, eac3ToOutputNamingService, @"c:\temp", bluRaySummaryInfo);
            var mkvmergepath = mkvMergeOutputService.GetMKVMergePathPart();
            //then
            mkvmergepath.Should().Be("\"c:\\exe\\mkvmerge.exe\"");
        }
    }
}

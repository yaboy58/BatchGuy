﻿using NUnit.Framework;
using FluentAssertions;
using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Eac3To.Services;
using BatchGuy.App.MKVMerge.Interfaces;
using BatchGuy.App.MKVMerge.Services;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Shared.Services;
using BatchGuy.App.Eac3To.Abstracts;

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
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService eac3ToOutputNamingService = new RemuxTemplate1EAC3ToOutputNamingService(audioService);
            //when
            IMKVMergeOutputService mkvMergeOutputService = new MKVMergeOutputService(config, eac3ToOutputNamingService, @"c:\temp", bluRaySummaryInfo);
            var mkvmergepath = mkvMergeOutputService.GetMKVMergePathPart();
            //then
            mkvmergepath.Should().Be("\"c:\\exe\\mkvmerge.exe\"");
        }
    }
}

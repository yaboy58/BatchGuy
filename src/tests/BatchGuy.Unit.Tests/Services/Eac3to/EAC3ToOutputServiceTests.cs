using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Eac3to.Services;
using BatchGuy.App;
using BatchGuy.App.Eac3to.Interfaces;
using BatchGuy.App.Enums;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Eac3To.Services;
using BatchGuy.App.Shared.Services;
using BatchGuy.App.Shared.Interfaces;

namespace BatchGuy.Unit.Tests.Services.Eac3to
{
    [TestFixture]
    public class EAC3ToOutputServiceTests
    {
        [Test]
        public void eacoutputservice_can_set_eac3to_executable_path_test()
        {
            
            //given eac3to path
            EAC3ToConfiguration config = new EAC3ToConfiguration() { EAC3ToPath = "c:\\exe\\eac3to" };
            BluRaySummaryInfo bluRaySummaryInfo = new BluRaySummaryInfo() { Eac3ToId = "1)", BluRayTitleInfo = new BluRayTitleInfo() { EpisodeNumber = "1" } };
            IAudioService audioService = new AudioService();
            IEAC3ToOutputNamingService eac3ToOutputNamingService = new EAC3ToOutputNamingService(audioService);
            string bluRayPath = "c:\\temp";
            //when I want the output
            IEAC3ToOutputService service = new EAC3ToOutputService(config, eac3ToOutputNamingService, bluRayPath, bluRaySummaryInfo);
            //then the eac3to path is set
            string output = service.GetEAC3ToPathPart();
            output.Should().Contain(config.EAC3ToPath);
        }

        [Test]
        public void eacoutputservice_can_set_bluray_stream_test()
        {
            //given bluray folder and stream#
            string bluRayPath = "c:\\disc";
            EAC3ToConfiguration config = new EAC3ToConfiguration();
            BluRaySummaryInfo bluRaySummaryInfo = new BluRaySummaryInfo() { Eac3ToId = "1)", BluRayTitleInfo = new BluRayTitleInfo() { EpisodeNumber = "1" }  };
            IAudioService audioService = new AudioService();
            IEAC3ToOutputNamingService eac3ToOutputNamingService = new EAC3ToOutputNamingService(audioService);
            //when I want the output
            IEAC3ToOutputService service = new EAC3ToOutputService(config,eac3ToOutputNamingService, bluRayPath, bluRaySummaryInfo);
            //then the bluray path/stream# is set
            string output = service.GetBluRayStreamPart();
            output.Should().Contain(bluRayPath);
            output.Should().Contain("1)");
        }

        [Test]
        public void eacoutputservice_can_set_dts_audio_settings_test()
        {
            //given dts and audio settings
            EAC3ToConfiguration config = new EAC3ToConfiguration() {  BatchFilePath = "c:\\temp" };
            BluRaySummaryInfo summaryInfo = new BluRaySummaryInfo() { Eac3ToId = "1)", BluRayTitleInfo = new BluRayTitleInfo() { EpisodeNumber = "1", AudioList = new List<BluRayTitleAudio>() { new BluRayTitleAudio() {Id="3:", AudioType = EnumAudioType.DTS, IsSelected = true, Arguments = "-core"}}} };
            string bluRayPath = "c:\\disc";
            IAudioService audioService = new AudioService();
            IEAC3ToOutputNamingService eac3ToOutputNamingService = new EAC3ToOutputNamingService(audioService);
            //when I want the output
            IEAC3ToOutputService service = new EAC3ToOutputService(config, eac3ToOutputNamingService, bluRayPath, summaryInfo);
            //then the dts audio is set
            string output = service.GetAudioStreamPart();
            output.Should().Contain(".dts");
            output.Should().Contain("-core");
        }

        [Test]
        public void eacoutputservice_can_set_progress_numbers_true_settings_test()
        {
            //given
            EAC3ToConfiguration config = new EAC3ToConfiguration() { BatchFilePath = "c:\\temp", ShowProgressNumbers = true };
            BluRaySummaryInfo summaryInfo = new BluRaySummaryInfo() { Eac3ToId = "1)", BluRayTitleInfo = new BluRayTitleInfo() { EpisodeNumber = "1", AudioList = new List<BluRayTitleAudio>() { new BluRayTitleAudio() { Id = "3:", AudioType = EnumAudioType.DTS, IsSelected = true, Arguments = "-core" } } } };
            string bluRayPath = "c:\\disc";
            IAudioService audioService = new AudioService();
            IEAC3ToOutputNamingService eac3ToOutputNamingService = new EAC3ToOutputNamingService(audioService);
            //when
            IEAC3ToOutputService service = new EAC3ToOutputService(config, eac3ToOutputNamingService, bluRayPath, summaryInfo);
            //then
            string output = service.GetShowProgressNumbersPart();
            output.Should().Contain("-progressnumbers");
        }

        [Test]
        public void eacoutputservice_can_set_progress_numbers_false_settings_test()
        {
            //given
            EAC3ToConfiguration config = new EAC3ToConfiguration() { BatchFilePath = "c:\\temp", ShowProgressNumbers = false };
            BluRaySummaryInfo summaryInfo = new BluRaySummaryInfo() { Eac3ToId = "1)", BluRayTitleInfo = new BluRayTitleInfo() { EpisodeNumber = "1", AudioList = new List<BluRayTitleAudio>() { new BluRayTitleAudio() { Id = "3:", AudioType = EnumAudioType.DTS, IsSelected = true, Arguments = "-core" } } } };
            string bluRayPath = "c:\\disc";
            IAudioService audioService = new AudioService();
            IEAC3ToOutputNamingService eac3ToOutputNamingService = new EAC3ToOutputNamingService(audioService);
            //when
            IEAC3ToOutputService service = new EAC3ToOutputService(config, eac3ToOutputNamingService, bluRayPath, summaryInfo);
            //then
            string output = service.GetShowProgressNumbersPart();
            output.Should().Be("");
        }
    }
}

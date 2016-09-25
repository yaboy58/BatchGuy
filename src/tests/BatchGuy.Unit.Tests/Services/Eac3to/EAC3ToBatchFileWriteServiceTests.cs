using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BatchGuy.App.Eac3to.Interfaces;
using BatchGuy.App.Eac3to.Services;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Eac3to.Models;
using FluentAssertions;
using Moq;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Shared.Services;
using BatchGuy.App.Eac3To.Abstracts;
using BatchGuy.App.Eac3To.Services;

namespace BatchGuy.Unit.Tests.Services.Eac3to
{
    [TestFixture]
    public class EAC3ToBatchFileWriteServiceTests
    {
        [Test]
        public void eac3tobatchfilewriteservice_has_no_disc_selected_error_when_no_disc_selected_test()
        {
            List<BluRayDiscInfo> discList = new List<BluRayDiscInfo>() {new BluRayDiscInfo() { Id = 1, IsSelected = false, BluRayPath = @"c:\temp\disc1" }};
            EAC3ToConfiguration config = new EAC3ToConfiguration();
            var directorySystemServiceMock = new Mock<IDirectorySystemService>();
            directorySystemServiceMock.Setup(m => m.Exists(It.IsAny<string>())).Returns(true);
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService eac3ToOutputNamingService = new EncodeTemplate1EAC3ToOutputNamingService(audioService);
            IEAC3ToCommonRulesValidatorService eac3ToCommonRulesValidatorService = new EAC3ToCommonRulesValidatorService(config, directorySystemServiceMock.Object, discList);
            IEAC3ToBatchFileWriteService service = new EAC3ToBatchFileWriteService(config,directorySystemServiceMock.Object, discList, audioService, eac3ToOutputNamingService, eac3ToCommonRulesValidatorService);
            bool isValid = service.IsValid();
            service.Errors[0].Description.Should().Be("No Disc was selected.");
        }

        [Test]
        public void eac3tobatchfilewriteservice_has_no_episodes_selected_error_when_no_episodes_selected_test()
        {
            List<BluRayDiscInfo> discList = new List<BluRayDiscInfo>() { new BluRayDiscInfo() { Id = 1, IsSelected = true, BluRayPath = @"c:\temp\disc1", 
                BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = false } } } };
            EAC3ToConfiguration config = new EAC3ToConfiguration();
            var directorySystemServiceMock = new Mock<IDirectorySystemService>();
            directorySystemServiceMock.Setup(m => m.Exists(It.IsAny<string>())).Returns(true);
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService eac3ToOutputNamingService = new EncodeTemplate1EAC3ToOutputNamingService(audioService);
            IEAC3ToCommonRulesValidatorService eac3ToCommonRulesValidatorService = new EAC3ToCommonRulesValidatorService(config, directorySystemServiceMock.Object, discList);
            IEAC3ToBatchFileWriteService service = new EAC3ToBatchFileWriteService(config, directorySystemServiceMock.Object, discList, audioService, eac3ToOutputNamingService, eac3ToCommonRulesValidatorService);
            bool isValid = service.IsValid();
            service.Errors[0].Description.Should().Be("No episodes selected.");
        }

        [Test]
        public void eac3tobatchfilewriteservice_has_episode_number_not_set_for_all_titles_error_when_some_episodes_numbers_not_set_test()
        {
            List<BluRayDiscInfo> discList = new List<BluRayDiscInfo>() { new BluRayDiscInfo() { Id = 1, IsSelected = true,BluRayPath = @"c:\temp\disc1", 
                BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = true,
             BluRayTitleInfo = new BluRayTitleInfo() { Video = new BluRayTitleVideo() { IsSelected = true} }} } } };
            EAC3ToConfiguration config = new EAC3ToConfiguration();
            var directorySystemServiceMock = new Mock<IDirectorySystemService>();
            directorySystemServiceMock.Setup(m => m.Exists(It.IsAny<string>())).Returns(true);
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService eac3ToOutputNamingService = new EncodeTemplate1EAC3ToOutputNamingService(audioService);
            IEAC3ToCommonRulesValidatorService eac3ToCommonRulesValidatorService = new EAC3ToCommonRulesValidatorService(config, directorySystemServiceMock.Object, discList);
            IEAC3ToBatchFileWriteService service = new EAC3ToBatchFileWriteService(config, directorySystemServiceMock.Object, discList, audioService, eac3ToOutputNamingService, eac3ToCommonRulesValidatorService);
            bool isValid = service.IsValid();
            service.Errors[0].Description.Should().Be("Episode number not set for all selected titles.");
        }

        [Test]
        public void eac3tobatchfilewriteservice_has_invalid_bluray_directory_error_when_some_bluray_disc_directories_dont_exist_test()
        {
            List<BluRayDiscInfo> discList = new List<BluRayDiscInfo>() { new BluRayDiscInfo() { Id = 1, IsSelected = true,BluRayPath = @"c:\temp\disc1", 
                BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = true,
             BluRayTitleInfo = new BluRayTitleInfo() { EpisodeNumber = "1", Video = new BluRayTitleVideo() { IsSelected = true} }} } } };
            EAC3ToConfiguration config = new EAC3ToConfiguration();
            var directorySystemServiceMock = new Mock<IDirectorySystemService>();
            directorySystemServiceMock.Setup(m => m.Exists(It.IsAny<string>())).Returns(false);
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService eac3ToOutputNamingService = new EncodeTemplate1EAC3ToOutputNamingService(audioService);
            IEAC3ToCommonRulesValidatorService eac3ToCommonRulesValidatorService = new EAC3ToCommonRulesValidatorService(config, directorySystemServiceMock.Object, discList);
            IEAC3ToBatchFileWriteService service = new EAC3ToBatchFileWriteService(config, directorySystemServiceMock.Object, discList, audioService, eac3ToOutputNamingService, eac3ToCommonRulesValidatorService);
            bool isValid = service.IsValid();
            service.Errors[0].Description.Should().Be("Invalid Blu-ray disc directories found.");
        }
    }
}

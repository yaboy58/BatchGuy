using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Shared.Services;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace BatchGuy.Unit.Tests.Services.Shared
{
    [TestFixture]
    public class EAC3ToCommonRulesValidatorServiceTests
    {
        [Test]
        public void eac3tocommonrulesvalidatorservice_has_no_disc_selected_error_when_no_disc_selected_test()
        {
            List<BluRayDiscInfo> discList = new List<BluRayDiscInfo>() { new BluRayDiscInfo() { Id = 1, IsSelected = false, BluRayPath = @"c:\temp\disc1" } };
            EAC3ToConfiguration config = new EAC3ToConfiguration();
            var directorySystemServiceMock = new Mock<IDirectorySystemService>();
            directorySystemServiceMock.Setup(m => m.Exists(It.IsAny<string>())).Returns(true);
            IEAC3ToCommonRulesValidatorService service = new EAC3ToCommonRulesValidatorService(config, directorySystemServiceMock.Object, discList);
            bool isValid = service.IsAtLeastOneDiscSelected();
            service.Errors[0].Description.Should().Be("No Disc was selected.");
        }

        [Test]
        public void eac3tocommonrulesvalidatorservice_has_no_episodes_selected_error_when_no_episodes_selected_test()
        {
            List<BluRayDiscInfo> discList = new List<BluRayDiscInfo>() { new BluRayDiscInfo() { Id = 1, IsSelected = true, BluRayPath = @"c:\temp\disc1",
                BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = false } } } };
            EAC3ToConfiguration config = new EAC3ToConfiguration();
            var directorySystemServiceMock = new Mock<IDirectorySystemService>();
            directorySystemServiceMock.Setup(m => m.Exists(It.IsAny<string>())).Returns(true);
            IEAC3ToCommonRulesValidatorService service = new EAC3ToCommonRulesValidatorService(config, directorySystemServiceMock.Object, discList);
            bool isValid = service.IsAtLeastOneSummarySelected();
            service.Errors[0].Description.Should().Be("No episodes selected.");
        }

        [Test]
        public void eac3tocommonrulesvalidatorservice_has_episode_number_not_set_for_all_titles_error_when_some_episodes_numbers_not_set_test()
        {
            List<BluRayDiscInfo> discList = new List<BluRayDiscInfo>() { new BluRayDiscInfo() { Id = 1, IsSelected = true,BluRayPath = @"c:\temp\disc1",
                BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = true,
             BluRayTitleInfo = new BluRayTitleInfo() { Video = new BluRayTitleVideo() { IsSelected = true} }} } } };
            EAC3ToConfiguration config = new EAC3ToConfiguration();
            var directorySystemServiceMock = new Mock<IDirectorySystemService>();
            directorySystemServiceMock.Setup(m => m.Exists(It.IsAny<string>())).Returns(true);
            IEAC3ToCommonRulesValidatorService service = new EAC3ToCommonRulesValidatorService(config, directorySystemServiceMock.Object, discList);
            bool isValid = service.IsAllEpisodeNumbersSet();
            service.Errors[0].Description.Should().Be("Episode number not set for all selected titles.");
        }

        [Test]
        public void eac3tocommonrulesvalidatorservice_has_invalid_bluray_directory_error_when_some_bluray_disc_directories_dont_exist_test()
        {
            List<BluRayDiscInfo> discList = new List<BluRayDiscInfo>() { new BluRayDiscInfo() { Id = 1, IsSelected = true,BluRayPath = @"c:\temp\disc1",
                BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = true,
             BluRayTitleInfo = new BluRayTitleInfo() { EpisodeNumber = "1", Video = new BluRayTitleVideo() { IsSelected = true} }} } } };
            EAC3ToConfiguration config = new EAC3ToConfiguration();
            var directorySystemServiceMock = new Mock<IDirectorySystemService>();
            directorySystemServiceMock.Setup(m => m.Exists(It.IsAny<string>())).Returns(false);
            IEAC3ToCommonRulesValidatorService service = new EAC3ToCommonRulesValidatorService(config, directorySystemServiceMock.Object, discList);
            bool isValid = service.IsAllBluRayPathsValid();
            service.Errors[0].Description.Should().Be("Invalid Blu-ray disc directories found.");
        }

        [Test]
        public void eac3tocommonrulesvalidatorservice_when_summary_selected_at_least_one_stream_selected_test()
        {
            List<BluRayDiscInfo> discList = new List<BluRayDiscInfo>() { new BluRayDiscInfo() { Id = 1, IsSelected = true,BluRayPath = @"c:\temp\disc1",
                BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = true,
             BluRayTitleInfo = new BluRayTitleInfo() { EpisodeNumber = "1", Video = new BluRayTitleVideo() { IsSelected = false} }} } } };
            EAC3ToConfiguration config = new EAC3ToConfiguration();
            var directorySystemServiceMock = new Mock<IDirectorySystemService>();
            directorySystemServiceMock.Setup(m => m.Exists(It.IsAny<string>())).Returns(false);
            IEAC3ToCommonRulesValidatorService service = new EAC3ToCommonRulesValidatorService(config, directorySystemServiceMock.Object, discList);
            bool isValid = service.WhenSummarySelectedAtLeastOneStreamSelected();
            service.Errors[0].Description.Should().Be("Some selected titles have no streams selected.");
        }
    }
}

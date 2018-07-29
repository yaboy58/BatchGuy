using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using FluentAssertions;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Settings.Models;
using BatchGuy.App.Settings.Interface;
using BatchGuy.App.Settings.Services;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Shared.Services;
using BatchGuy.App.Shared.Models;

namespace BatchGuy.Unit.Tests.Services.Settings
{
    [TestFixture]
    public class BluRayTitleInfoDefaultSettingsServiceTests
    {
        [Test]
        public void bluraytitleinfodefaultsettingsservice_can_mark_all_subtitles_as_selected_as_default_Test()
        {
            //given
            ApplicationSettings applicationSettings = new ApplicationSettings() { BluRayTitleInfoDefaultSettings = new BluRayTitleInfoDefaultSettings() { SelectAllSubtitles = true } };
            BluRaySummaryInfo bluraySummaryInfo = new BluRaySummaryInfo() { BluRayTitleInfo = new BluRayTitleInfo()
            { Subtitles = new List<BluRayTitleSubtitle>() { new BluRayTitleSubtitle() { IsSelected = false },
            new BluRayTitleSubtitle() { IsSelected = false } } } };
            IAudioService audioService = new AudioService();
            IBluRayTitleInfoDefaultSettingsService service = new BluRayTitleInfoDefaultSettingsService(applicationSettings, bluraySummaryInfo, audioService);
            //when
            service.SetSubtitleDefaultSettings();
            //then
            bluraySummaryInfo.BluRayTitleInfo.Subtitles.Where(s => s.IsSelected == true).Count().Should().Be(2);
        }

        [Test]
        public void bluraytitleinfodefaultsettingsservice_can_mark_all_chapter_as_selected_as_default_Test()
        {
            //given
            ApplicationSettings applicationSettings = new ApplicationSettings() { BluRayTitleInfoDefaultSettings = new BluRayTitleInfoDefaultSettings() { SelectChapters = true} };
            BluRaySummaryInfo bluraySummaryInfo = new BluRaySummaryInfo() { BluRayTitleInfo = new BluRayTitleInfo() { Chapter = new BluRayTitleChapter() { IsSelected = false } } };
            BluRayTitleInfoDefaultSettings defaultSettings = new BluRayTitleInfoDefaultSettings() {  SelectChapters = true };
            IAudioService audioService = new AudioService();
            IBluRayTitleInfoDefaultSettingsService service = new BluRayTitleInfoDefaultSettingsService(applicationSettings, bluraySummaryInfo, audioService);
            //when
            service.SetChaptersDefaultSettings();
            //then
            bluraySummaryInfo.BluRayTitleInfo.Chapter.IsSelected.Should().BeTrue();
        }
    }
}

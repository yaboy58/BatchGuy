using System.Collections.Generic;
using NUnit.Framework;
using FluentAssertions;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Extensions;


namespace BatchGuy.Unit.Tests.ExtensionMethods
{
    [TestFixture]
    public class ExtensionMethodTests
    {
        [Test]
        public void extensionmethods_listofbluraydiscinfo_numberofepisodes_test()
        {
            List<BluRayDiscInfo> discs = new List<BluRayDiscInfo>() { new BluRayDiscInfo() { IsSelected = true, BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = true}, new BluRaySummaryInfo() { IsSelected = false} }},
            new BluRayDiscInfo() { IsSelected = true, BluRaySummaryInfoList = new List<BluRaySummaryInfo>() {new BluRaySummaryInfo() {IsSelected = true}, new BluRaySummaryInfo() { IsSelected = true}}} };

            discs.NumberOfEpisodes().Should().Be(3);
        }

        [Test]
        public void extensionmethods_removecolons_test()
        {
            //given a string with a colon in it
            string stringWithColon = "1:";
            //when i attempt to remove colons
            string stringWithNoColon = stringWithColon.RemoveColons();
            //then colons should be removed
            stringWithNoColon.Should().Be("1");
        }

        [Test]
        public void extensionmethods_replacespaceswithperiods_test()
        {
            //given
            string episodeWithSpaces = "The First 48 S01E01 First Episode 1080p Remux AVC FLAC7.1-BatchGuy.mkv";
            //when
            string episodeWithPeriods = episodeWithSpaces.ReplaceSpacesWithPeriods();
            //then
            episodeWithPeriods.Should().Be("The.First.48.S01E01.First.Episode.1080p.Remux.AVC.FLAC7.1-BatchGuy.mkv");
        }

        [Test]
        public void extensionmethods_subtitlefileextension__test()
        {
            //given
            string file = @"c:\external subtitles\my tv show episode.ssa";
            //when
            string extension = file.SubtitleFileExtension();
            //then
            extension.Should().Be("ssa");
        }
    }
}

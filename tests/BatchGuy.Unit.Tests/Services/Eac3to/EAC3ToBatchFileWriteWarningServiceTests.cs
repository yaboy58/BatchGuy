using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssert;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Eac3To.Services;

namespace BatchGuy.Unit.Tests.Services.Eac3to
{
    [TestFixture]
    public class EAC3ToBatchFileWriteWarningServiceTests
    {
        [Test]
        public void eac3tobatchfilewritewarningwervice_has_no_warnings_when_no_data_anomalies_test()
        {
            //given a list of discs where there is no data anomalis
            List<BluRayDiscInfo> discs = new List<BluRayDiscInfo>() { new BluRayDiscInfo() { IsSelected = true, BluRayPath = "c:\\temp\\disc1" }, new BluRayDiscInfo() { IsSelected = true, BluRayPath = "c:\\temp\\disc2" } };
            discs[0].BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = true }, new BluRaySummaryInfo() { IsSelected = true, Eac3ToId = "1)" } };

            discs[1].BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = true }, new BluRaySummaryInfo() { IsSelected = true, Eac3ToId = "2)" } };
            //when i get warnings
            IEAC3ToBatchFileWriteWarningService service = new EAC3ToBatchFileWriteWarningService(discs);
            WarningCollection warnings = service.GetWarnings();
            //then there should be no warnings
            warnings.Count().ShouldBeEqualTo(0);
        }

        [Test]
        public void eac3tobatchfilewritewarningwervice_has_warning_when_disc_selected_but_no_summaries_selected_test()
        {
            //given a list of discs where a disc is selected but no summaries selected
            List<BluRayDiscInfo> discs = new List<BluRayDiscInfo>() { new BluRayDiscInfo() { IsSelected = true, BluRayPath = "c:\\temp\\disc1" }, new BluRayDiscInfo() { IsSelected = true, BluRayPath = "c:\\temp\\disc2" } };
            discs[0].BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = true }, new BluRaySummaryInfo() { IsSelected = true, Eac3ToId = "1)" } };
            //when i get warnings
            IEAC3ToBatchFileWriteWarningService service = new EAC3ToBatchFileWriteWarningService(discs);
            WarningCollection warnings = service.GetWarnings();
            //then warnings should tell me i have selected discs found with no summary selected
            warnings.Where(w => w.Description.Contains("disc2 selected but no summary selected")).Count().ShouldBeEqualTo(1);
        }

        [Test]
        public void eac3tobatchfilewritewarningwervice_has_warning_when_summary_and_title_selected_but_no_disc_selected_test()
        {
            //given a list of discs where summary and titles selected but disc not selected
            List<BluRayDiscInfo> discs = new List<BluRayDiscInfo>() { new BluRayDiscInfo() { IsSelected = true, BluRayPath = "c:\\temp\\disc1" }, new BluRayDiscInfo() { IsSelected = false, BluRayPath = "c:\\temp\\disc2" } };
            discs[0].BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = true, Eac3ToId = "1)" }, new BluRaySummaryInfo() { IsSelected = true, Eac3ToId = "2)" } };

            discs[1].BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = true, BluRayTitleInfo = new BluRayTitleInfo() {Video = new BluRayTitleVideo() {IsSelected = true}} }, 
                new BluRaySummaryInfo() { IsSelected = true, BluRayTitleInfo = new BluRayTitleInfo() { AudioList = new List<BluRayTitleAudio>() {new BluRayTitleAudio() { IsSelected = true} } } } };
            //when i get warnings
            IEAC3ToBatchFileWriteWarningService service = new EAC3ToBatchFileWriteWarningService(discs);
            WarningCollection warnings = service.GetWarnings();
            //then warnings should tell me i have selected summary and titles found with no disc selected
            warnings.Where(w => w.Description.Contains("Disc disc2 is not selected but has selected summary and video")).Count().ShouldBeEqualTo(1);
        }

        [Test]
        public void eac3tobatchfilewritewarningwervice_has_warning_when_title_selected_and_no_summary_and_disc_selected_test()
        {
            //given a list of discs where title selected and summary and disc not selected 
            List<BluRayDiscInfo> discs = new List<BluRayDiscInfo>() { new BluRayDiscInfo() { IsSelected = false, BluRayPath = "c:\\temp\\disc1" }, new BluRayDiscInfo() { IsSelected = false, BluRayPath = "c:\\temp\\disc2" } };
            discs[0].BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = true, Eac3ToId = "1)" }, new BluRaySummaryInfo() { IsSelected = true, Eac3ToId = "2)" } };

            discs[1].BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = false, Eac3ToId = "1)", BluRayTitleInfo = new BluRayTitleInfo() {Video = new BluRayTitleVideo() {IsSelected = true}} }, 
                new BluRaySummaryInfo() { IsSelected = true, Eac3ToId = "2)", BluRayTitleInfo = new BluRayTitleInfo() { AudioList = new List<BluRayTitleAudio>() {new BluRayTitleAudio() { IsSelected = true} } } } };
            //when i get warnings
            IEAC3ToBatchFileWriteWarningService service = new EAC3ToBatchFileWriteWarningService(discs);
            WarningCollection warnings = service.GetWarnings();
            //then warnings should tell me i have selected titles found with no disc or summary selected
            warnings.Where(w => w.Description.Contains("Disc disc2 summary 1) is not selected but has selected video")).Count().ShouldBeEqualTo(1);
        }
    }
}

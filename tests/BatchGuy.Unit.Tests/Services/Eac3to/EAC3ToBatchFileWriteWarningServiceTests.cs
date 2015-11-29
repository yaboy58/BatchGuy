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
            List<BluRayDiscInfo> discs = new List<BluRayDiscInfo>() { new BluRayDiscInfo() { IsSelected = true }, new BluRayDiscInfo() { IsSelected = true } };
            discs[0].BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = true }, new BluRaySummaryInfo() { IsSelected = true } };
            discs[1].BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = true }, new BluRaySummaryInfo() { IsSelected = true } };
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
            List<BluRayDiscInfo> discs = new List<BluRayDiscInfo>() { new BluRayDiscInfo() { IsSelected = true }, new BluRayDiscInfo() { IsSelected = true } };
            discs[0].BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = true }, new BluRaySummaryInfo() { IsSelected = true } };
            //when i get warnings
            IEAC3ToBatchFileWriteWarningService service = new EAC3ToBatchFileWriteWarningService(discs);
            WarningCollection warnings = service.GetWarnings();
            //then warnings should tell me i have selected discs found with no summary selected
            warnings.Where(w => w.Description.Contains("Selected discs found with no summary selected")).Count().ShouldBeEqualTo(1);
        }

        [Test]
        public void eac3tobatchfilewritewarningwervice_has_warning_when_summary_and_title_select_but_no_disc_selected_test()
        {
            //given a list of discs where summary and titles selected but disc not selected
            List<BluRayDiscInfo> discs = new List<BluRayDiscInfo>() { new BluRayDiscInfo() { IsSelected = true }, new BluRayDiscInfo() { IsSelected = false } };
            discs[0].BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = true }, new BluRaySummaryInfo() { IsSelected = true } };
            discs[1].BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = true, BluRayTitleInfo = new BluRayTitleInfo() {Video = new BluRayTitleVideo() {IsSelected = true}} }, 
                new BluRaySummaryInfo() { IsSelected = true, BluRayTitleInfo = new BluRayTitleInfo() { AudioList = new List<BluRayTitleAudio>() {new BluRayTitleAudio() { IsSelected = true} } } } };
            //when i get warnings
            IEAC3ToBatchFileWriteWarningService service = new EAC3ToBatchFileWriteWarningService(discs);
            WarningCollection warnings = service.GetWarnings();
            //then warnings should tell me i have selected summary and titles found with no disc selected
            warnings.Where(w => w.Description.Contains("Selected summary and titles found with no disc selected")).Count().ShouldBeEqualTo(1);
        }
    }
}

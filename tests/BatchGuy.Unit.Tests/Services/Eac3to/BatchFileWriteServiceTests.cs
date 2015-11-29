using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssert;
using NUnit.Framework;
using BatchGuy.App.Eac3to.Interfaces;
using BatchGuy.App.Eac3to.Services;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Eac3to.Models;

namespace BatchGuy.Unit.Tests.Services.Eac3to
{
    [TestFixture]
    public class BatchFileWriteServiceTests
    {
        [Test]
        public void batchfilewriterservice_has_no_disc_selected_error_when_no_disc_selected_test()
        {
            List<BluRayDiscInfo> discList = new List<BluRayDiscInfo>() {new BluRayDiscInfo() { Id = 1, IsSelected = false }};
            EAC3ToConfiguration config = new EAC3ToConfiguration();
            IEAC3ToBatchFileWriteService service = new EAC3ToBatchFileWriteService(config, discList);
            bool isValid = service.IsValid();
            service.Errors[0].Description.ShouldBeEqualTo("No Disc was selected.");
        }

        [Test]
        public void batchfilewriterservice_has_no_episodes_selected_error_when_no_episodes_selected_test()
        {
            List<BluRayDiscInfo> discList = new List<BluRayDiscInfo>() { new BluRayDiscInfo() { Id = 1, IsSelected = true, BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = false} } } };
            EAC3ToConfiguration config = new EAC3ToConfiguration();
            IEAC3ToBatchFileWriteService service = new EAC3ToBatchFileWriteService(config,discList);
            bool isValid = service.IsValid();
            service.Errors[0].Description.ShouldBeEqualTo("No episodes selected.");
        }

        [Test]
        public void batchfilewriterservice_has_episodes_not_set_for_all_titles_error_when_some_episodes_numbers_not_set_test()
        {
            List<BluRayDiscInfo> discList = new List<BluRayDiscInfo>() { new BluRayDiscInfo() { Id = 1, IsSelected = true, BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = true,
             BluRayTitleInfo = new BluRayTitleInfo() { Video = new BluRayTitleVideo() { IsSelected = true} }} } } };
            EAC3ToConfiguration config = new EAC3ToConfiguration();
            IEAC3ToBatchFileWriteService service = new EAC3ToBatchFileWriteService(config, discList);
            bool isValid = service.IsValid();
            service.Errors[0].Description.ShouldBeEqualTo("Episode not set for all titles.");
        }
    }
}

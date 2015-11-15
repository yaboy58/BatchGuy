using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssert;
using NUnit.Framework;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.Enums;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Shared.Services;

namespace BatchGuy.Unit.Tests.Services.Shared
{
    [TestFixture]
    public class SortServiceTests
    {
        [Test]
        public void sortservice_can_sort_list_desc_test()
        {
            //given a list
            List<BluRaySummaryInfo> unsortedList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { Id = "1)",  BluRayTitleInfo = new BluRayTitleInfo() { EpisodeNumber = "1"} }, 
                new BluRaySummaryInfo() { Id = "8)", BluRayTitleInfo = new BluRayTitleInfo() { EpisodeNumber = "8"} }, new BluRaySummaryInfo() { Id = "4)", BluRayTitleInfo = new BluRayTitleInfo() { EpisodeNumber = "4"} } };
            //when i attempt to sort by a column in desc order
            SortConfiguration config = new SortConfiguration() { LastSortByColumnName = string.Empty, SortByColumnName = "EpisodeNumber", SortDirection = EnumSortDirection.Desc };
            ISortService<BluRaySummaryInfo> service = new SortService<BluRaySummaryInfo>(config, unsortedList);
            //list should be ordered by column in desc order
            List<BluRaySummaryInfo> sortedList = service.Sort();
            sortedList[0].EpisodeNumber.ShouldBeEqualTo(8);
        }

        [Test]
        public void sortservice_can_sort_list_asc_test()
        {
            //given a list
            List<BluRaySummaryInfo> unsortedList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { Id = "8)", BluRayTitleInfo = new BluRayTitleInfo() { EpisodeNumber = "8"} }, new BluRaySummaryInfo() { Id = "1)",  BluRayTitleInfo = new BluRayTitleInfo() { EpisodeNumber = "1"} },
                new BluRaySummaryInfo() { Id = "4)", BluRayTitleInfo = new BluRayTitleInfo() { EpisodeNumber = "4"} } };
            //when i attempt to sort by a column in desc order
            SortConfiguration config = new SortConfiguration() { LastSortByColumnName = string.Empty, SortByColumnName = "EpisodeNumber", SortDirection = EnumSortDirection.Asc };
            ISortService<BluRaySummaryInfo> service = new SortService<BluRaySummaryInfo>(config, unsortedList);
            //list should be ordered by column in desc order
            List<BluRaySummaryInfo> sortedList = service.Sort();
            sortedList[0].EpisodeNumber.ShouldBeEqualTo(1);
        }

        [Test]
        public void sortservice_will_update_sort_configuration_lastsortbycolumn_test()
        {
            //given a list
            List<BluRaySummaryInfo> unsortedList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { Id = "8)", BluRayTitleInfo = new BluRayTitleInfo() { EpisodeNumber = "8"} }, new BluRaySummaryInfo() { Id = "1)",  BluRayTitleInfo = new BluRayTitleInfo() { EpisodeNumber = "1"} },
                new BluRaySummaryInfo() { Id = "4)", BluRayTitleInfo = new BluRayTitleInfo() { EpisodeNumber = "4"} } };
            //when i attempt to sort by a column in desc order
            SortConfiguration config = new SortConfiguration() { LastSortByColumnName = string.Empty, SortByColumnName = "EpisodeNumber", SortDirection = EnumSortDirection.Asc };
            ISortService<BluRaySummaryInfo> service = new SortService<BluRaySummaryInfo>(config, unsortedList);
            //list should be ordered by column in desc order
            List<BluRaySummaryInfo> sortedList = service.Sort();
            config.LastSortByColumnName.ShouldBeEqualTo("EpisodeNumber");
        }
    }
}

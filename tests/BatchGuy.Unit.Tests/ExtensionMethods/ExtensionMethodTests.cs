using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssert;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Extensions;
namespace BatchGuy.Unit.Tests.ExtensionMethods
{
    [TestFixture]
    public class ExtensionMethodTests
    {
        public void extensionmethods_listofbluraydiscinfo_numberofepisodes_test()
        {
            List<BluRayDiscInfo> discs = new List<BluRayDiscInfo>() { new BluRayDiscInfo() { IsSelected = true, BluRaySummaryInfoList = new List<BluRaySummaryInfo>() { new BluRaySummaryInfo() { IsSelected = true}, new BluRaySummaryInfo() { IsSelected = false} }},
            new BluRayDiscInfo() { IsSelected = true, BluRaySummaryInfoList = new List<BluRaySummaryInfo>() {new BluRaySummaryInfo() {IsSelected = true}, new BluRaySummaryInfo() { IsSelected = true}}} };

            discs.NumberOfEpisodes().ShouldBeEqualTo(3);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;
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
    }
}

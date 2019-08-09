using NUnit.Framework;
using FluentAssertions;
using BatchGuy.App.Parser.Models;

namespace BatchGuy.Unit.Tests.Models
{
    [TestFixture]
    public class BluRayTitleSubtitleTests
    {
        [Test]
        public void bluraytitlesubtitle_idnumber_set_to_zero_when_id_empty_test()
        {
            //given
            BluRayTitleSubtitle subtitle = new BluRayTitleSubtitle() { Id = "" };
            //when
            int idNumber = subtitle.IdNumber;
            //then
            idNumber.Should().Be(0);
        }

        [Test]
        public void bluraytitlesubtitle_idnumber_converted_to_valid_int_when_id_is_not_empty_test()
        {
            //given
            BluRayTitleSubtitle subtitle = new BluRayTitleSubtitle() { Id = "18:" };
            //when
            int idNumber = subtitle.IdNumber;
            //then
            idNumber.Should().Be(18);
        }
    }
}

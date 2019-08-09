using NUnit.Framework;
using FluentAssertions;
using BatchGuy.App.Parser.Models;

namespace BatchGuy.Unit.Tests.Models
{
    [TestFixture]
    public class BluRayTitleAudioTests
    {
        [Test]
        public void bluraytitleaudio_idnumber_set_to_zero_when_id_empty_test()
        {
            //given
            BluRayTitleAudio audio = new BluRayTitleAudio() { Id = "" };
            //when
            int idNumber = audio.IdNumber;
            //then
            idNumber.Should().Be(0);
        }

        [Test]
        public void bluraytitleaudio_idnumber_converted_to_valid_int_when_id_is_not_empty_test()
        {
            //given
            BluRayTitleAudio audio = new BluRayTitleAudio() { Id = "18:" };
            //when
            int idNumber = audio.IdNumber;
            //then
            idNumber.Should().Be(18);
        }
    }
}

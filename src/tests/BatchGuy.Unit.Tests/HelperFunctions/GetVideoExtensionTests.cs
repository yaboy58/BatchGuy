using BatchGuy.App.Helpers;
using NUnit.Framework;
using FluentAssertions;

namespace BatchGuy.Unit.Tests
{
    [TestFixture]
    public class GetVideoExtensionTests
    {
        [Test]
        public void extension_is_mkv_when_video_text_is_empty_test()
        {
            string text = string.Empty;
            //given empty text
            //when I get the extension
            string extension = HelperFunctions.GetVideoExtension(text);
            //then the extension is mkv
            extension.Should().Be("mkv");
        }

        [Test]
        public void extension_is_h265_when_video_text_contains_hevc_test()
        {
            string text = "2: HEVC, (16:9), 10 bits";
            //given hevc text
            //when I get the extension
            string extension = HelperFunctions.GetVideoExtension(text);
            //then the extension is h265
            extension.Should().Be("h265");
        }

        [Test]
        public void extension_is_h265_when_video_text_contains_h265_test()
        {
            string text = "2: h265 (16:9), 10 bits";
            //given h265 text
            //when I get the extension
            string extension = HelperFunctions.GetVideoExtension(text);
            //then the extension is h265
            extension.Should().Be("h265");
        }

        [Test]
        public void extension_is_h265_when_video_text_contains_2160_test()
        {
            string text = "2: 2160p24 (16:9), 10 bits";
            //given 2160 text
            //when I get the extension
            string extension = HelperFunctions.GetVideoExtension(text);
            //then the extension is h265
            extension.Should().Be("h265");
        }
    }
}

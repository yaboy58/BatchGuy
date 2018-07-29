using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Eac3To.Abstracts;
using BatchGuy.App.Eac3To.Services;
using BatchGuy.App.Enums;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Shared.Services;
using FluentAssertions;
using NUnit.Framework;

namespace BatchGuy.Unit.Tests.Services.Eac3to
{
    [TestFixture]
    public class EncodeTemplate1EAC3ToOutputNamingServiceTests
    {
        [Test]
        public void encodeTemplate1EAC3ToOutputNamingService_can_set_chapter_name_when_not_extract_for_remux_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration() { IsExtractForRemux = false };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the chapter name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new EncodeTemplate1EAC3ToOutputNamingService(audioService);
            string chapterName = service.GetChapterName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then chapter name should be hard coded for workflow
            chapterName.Should().Be("\"c:\\bluray\\chapters01.txt\"");
        }

        [Test]
        public void encodeTemplate1EAC3ToOutputNamingService_can_set_video_name_when_not_extract_for_remux_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration() { IsExtractForRemux = false };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new EncodeTemplate1EAC3ToOutputNamingService(audioService);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then video name should be hard coded for workflow
            videoName.Should().Be("\"c:\\bluray\\video01.mkv\"");
        }

        [Test]
        public void encodeTemplate1EAC3ToOutputNamingService_can_set_audio_name_when_not_extract_for_remux_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration() { IsExtractForRemux = false };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            BluRayTitleAudio audio = new BluRayTitleAudio() { Id = "13:", AudioType = EnumAudioType.DTSMA, Language = "english" };
            //when i get the audio name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new EncodeTemplate1EAC3ToOutputNamingService(audioService);
            string audioName = service.GetAudioName(config, audio, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then audio name should be hard coded for workflow
            audioName.Should().Be("\"c:\\bluray\\english01-13.dtsma\"");
        }

        [Test]
        public void encodeTemplate1EAC3ToOutputNamingService_can_set_subtitle_name_when_not_extract_for_remux_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration() { IsExtractForRemux = false };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            BluRayTitleSubtitle subtitle = new BluRayTitleSubtitle() { Id = "3:", Language = "english" };
            //when i get the subtitle name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new EncodeTemplate1EAC3ToOutputNamingService(audioService);
            string subtitleName = service.GetSubtitleName(config, subtitle, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then subtitle name should be hard coded for workflow
            subtitleName.Should().Be("\"c:\\bluray\\english01-3.sup\"");
        }

        [Test]
        public void encodeTemplate1EAC3ToOutputNamingService_can_set_audio_commentary_when_is_commentary_and_not_extract_for_remux_test()
        {
            //given not extract for remux and commentary
            EAC3ToConfiguration config = new EAC3ToConfiguration() { IsExtractForRemux = false };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            BluRayTitleAudio audio = new BluRayTitleAudio() { Id = "13:", AudioType = EnumAudioType.DTSMA, Language = "english", IsCommentary = true };
            //when i get the audio name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new EncodeTemplate1EAC3ToOutputNamingService(audioService);
            string audioName = service.GetAudioName(config, audio, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then audio name should have commentary in the name
            audioName.Should().Be("\"c:\\bluray\\english01-13-commentary.dtsma\"");
        }

        [Test]
        public void encodeTemplate1EAC3ToOutputNamingService_can_set_subtitle_name_when_is_commentary_and_not_extract_for_remux_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration() { IsExtractForRemux = false };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            BluRayTitleSubtitle subtitle = new BluRayTitleSubtitle() { Id = "3:", Language = "english", IsCommentary = true };
            //when i get the subtitle name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new EncodeTemplate1EAC3ToOutputNamingService(audioService);
            string subtitleName = service.GetSubtitleName(config, subtitle, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then subtitle name should be hard coded for workflow and commentary
            subtitleName.Should().Be("\"c:\\bluray\\english01-3-commentary.sup\"");
        }
    }
}

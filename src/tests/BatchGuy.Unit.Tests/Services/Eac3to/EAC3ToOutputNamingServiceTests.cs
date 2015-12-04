using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Eac3To.Services;
using BatchGuy.App.Eac3To.Models;
using BatchGuy.App.Extensions;
using BatchGuy.App.Helpers;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Enums;

namespace BatchGuy.Unit.Tests.Services.Eac3to
{
    [TestFixture]
    public class EAC3ToOutputNamingServiceTests
    {
        [Test]
        public void eac3ToOutputNamingService_can_set_chapter_name_when_not_extract_for_remux_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration() { IsExtractForRemux = false };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the chapter name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            string chapterName = service.GetChapterName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then chapter name should be hard coded for workflow
            chapterName.Should().Be("\"c:\\bluray\\chapters01.txt\"");
        }

        [Test]
        public void eac3ToOutputNamingService_can_set_chapter_name_when_is_extract_for_remux_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration() { IsExtractForRemux = true, RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate() { AudioType = "FLAC 5.1", SeriesName = "BatchGuy",
             SeasonNumber = 2, SeasonYear = "1978", Tag = "Guy", VideoResolution = "1080p", Medium = "Remux"} };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the chapter name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            string chapterName = service.GetChapterName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then chapter name should be based on the remux template
            chapterName.Should().Be("\"c:\\bluray\\BatchGuy 1978 S02E01 1080p Remux FLAC 5.1-Guy chapters.txt\"");
        }

        [Test]
        public void eac3ToOutputNamingService_can_set_video_name_when_not_extract_for_remux_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration() { IsExtractForRemux = false };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the video name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then video name should be hard coded for workflow
            videoName.Should().Be("\"c:\\bluray\\video01.mkv\"");
        }

        [Test]
        public void eac3ToOutputNamingService_can_set_video_name_when_is_extract_for_remux_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    AudioType = "FLAC 5.1",
                    SeriesName = "BatchGuy",
                    SeasonNumber = 2,
                    SeasonYear = "1978",
                    Tag = "Guy",
                    VideoResolution = "1080p"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the video name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy 1978 S02E01 1080p FLAC 5.1-Guy.mkv\"");
        }

        [Test]
        public void eac3ToOutputNamingService_can_set_video_name_when_is_extract_for_remux_and_no_audio_type_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    SeriesName = "BatchGuy",
                    SeasonNumber = 2,
                    SeasonYear = "1978",
                    Tag = "Guy",
                    VideoResolution = "1080p"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the video name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy 1978 S02E01 1080p -Guy.mkv\"");
        }

        [Test]
        public void eac3ToOutputNamingService_can_set_video_name_when_is_extract_for_remux_and_no_tag_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    SeriesName = "BatchGuy",
                    SeasonNumber = 2,
                    SeasonYear = "1978"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = "Episode 1";
            //when i get the video name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy 1978 S02E01 Episode 1.mkv\"");
        }

        [Test]
        public void eac3ToOutputNamingService_can_set_audio_name_when_not_extract_for_remux_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration() { IsExtractForRemux = false };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            BluRayTitleAudio audio = new BluRayTitleAudio() {Id = "13:", AudioType = EnumAudioType.DTS, Language = "english" };
            //when i get the audio name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            string audioName = service.GetAudioName(config, audio, filesOutputPath, paddedEpisodeNumber,episodeName);
            //then audio name should be hard coded for workflow
            audioName.Should().Be("\"c:\\bluray\\english01-13.dts\"");
        }

        [Test]
        public void eac3ToOutputNamingService_can_set_audio_name_when_is_extract_for_remux_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    AudioType = "FLAC 5.1",
                    SeriesName = "BatchGuy",
                    SeasonNumber = 2,
                    SeasonYear = "1978",
                    Tag = "Guy",
                    VideoResolution = "1080p"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the audio name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            BluRayTitleAudio audio = new BluRayTitleAudio() { Id = "5:", AudioType = EnumAudioType.DTS, Language = "english" };
            string audioName = service.GetAudioName(config, audio, filesOutputPath, paddedEpisodeNumber,episodeName);
            //then audio name should be based on the remux template
            audioName.Should().Be("\"c:\\bluray\\BatchGuy 1978 S02E01 1080p FLAC 5.1-Guy english01-5.dts\"");
        }

        [Test]
        public void eac3ToOutputNamingService_can_set_subtitle_name_when_not_extract_for_remux_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration() { IsExtractForRemux = false };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            BluRayTitleSubtitle subtitle = new BluRayTitleSubtitle() { Language = "english" };
            //when i get the subtitle name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            string  subtitleName = service.GetSubtitleName(config, subtitle, filesOutputPath, paddedEpisodeNumber, episodeName,1);
            //then subtitle name should be hard coded for workflow
            subtitleName.Should().Be("\"c:\\bluray\\english01-1.sup\"");
        }

        [Test]
        public void eac3ToOutputNamingService_can_set_subtitle_name_when_is_extract_for_remux_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    AudioType = "FLAC 5.1",
                    SeriesName = "BatchGuy",
                    SeasonNumber = 2,
                    SeasonYear = "1978",
                    Tag = "Guy",
                    VideoResolution = "1080p",
                     Medium = "Remux",
                      VideoFormat = "H.264"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the subtitle name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            BluRayTitleSubtitle subtitle = new BluRayTitleSubtitle() { Language = "english" };
            string subtitleName = service.GetSubtitleName(config, subtitle, filesOutputPath, paddedEpisodeNumber, episodeName,1);
            //then subtitle name should be based on the remux template
            subtitleName.Should().Be("\"c:\\bluray\\BatchGuy 1978 S02E01 1080p Remux H.264 FLAC 5.1-Guy english01-1.sup\"");
        }

        [Test]
        public void eac3ToOutputNamingService_can_set_subtitle_name_when_is_extract_for_remux_and_only_required_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    SeriesName = "BatchGuy",
                    SeasonNumber = 2,
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the subtitle name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            BluRayTitleSubtitle subtitle = new BluRayTitleSubtitle() { Language = "english" };
            string subtitleName = service.GetSubtitleName(config, subtitle, filesOutputPath, paddedEpisodeNumber, episodeName,1);
            //then subtitle name should be based on the remux template
            subtitleName.Should().Be("\"c:\\bluray\\BatchGuy S02E01 english01-1.sup\"");
        }

        [Test]
        public void eac3ToOutputNamingService_can_set_log_name_when_is_extract_for_remux_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    SeriesName = "BatchGuy",
                    SeasonNumber = 2,
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = "Episode 3";
            //when i get the subtitle name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            string logName = service.GetLogName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then subtitle name should be based on the remux template
            logName.Should().Be(" -log=\"c:\\bluray\\BatchGuy S02E01 Episode 3 log.txt\"");
        }
    }
}

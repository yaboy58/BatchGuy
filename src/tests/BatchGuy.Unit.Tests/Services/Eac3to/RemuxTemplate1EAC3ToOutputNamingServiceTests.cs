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
using BatchGuy.App.Shared.Services;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Eac3To.Abstracts;

namespace BatchGuy.Unit.Tests.Services.Eac3to
{
    [TestFixture]
    public class RemuxTemplate1EAC3ToOutputNamingServiceTests
    {


        [Test]
        public void RemuxTemplate1EAC3ToOutputNamingService_can_set_chapter_name_when_is_extract_for_remux_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration() { IsExtractForRemux = true, RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate() { AudioType = "FLAC 5.1", SeriesName = "BatchGuy",
             SeasonNumber = "2", SeasonYear = "1978", Tag = "Guy", VideoResolution = "1080p", Medium = "Remux"} };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the chapter name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate1EAC3ToOutputNamingService(audioService);
            string chapterName = service.GetChapterName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then chapter name should be based on the remux template
            chapterName.Should().Be("\"c:\\bluray\\BatchGuy 1978 S02E01 1080p Remux FLAC 5.1-Guy chapters.txt\"");
        }



        [Test]
        public void RemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_when_is_extract_for_remux_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    AudioType = "FLAC 5.1",
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                    SeasonYear = "1978",
                    Tag = "Guy",
                    VideoResolution = "1080p"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate1EAC3ToOutputNamingService(audioService);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy 1978 S02E01 1080p FLAC 5.1-Guy.mkv\"");
        }

        [Test]
        public void RemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_when_is_extract_for_remux_and_series_name_only_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    SeriesName = "BatchGuy"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate1EAC3ToOutputNamingService(audioService);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy E01.mkv\"");
        }

        [Test]
        public void RemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_when_is_extract_for_remux_and_no_audio_type_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                    SeasonYear = "1978",
                    Tag = "Guy",
                    VideoResolution = "1080p"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate1EAC3ToOutputNamingService(audioService);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy 1978 S02E01 1080p -Guy.mkv\"");
        }

        [Test]
        public void RemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_when_is_extract_for_remux_and_no_tag_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                    SeasonYear = "1978"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = "Episode 1";
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate1EAC3ToOutputNamingService(audioService);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy 1978 S02E01 Episode 1.mkv\"");
        }

        [Test]
        public void RemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_when_is_extract_for_remux_and_no_season_year_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                    Tag = "Guy",
                    VideoResolution = "1080p"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate1EAC3ToOutputNamingService(audioService);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy S02E01 1080p -Guy.mkv\"");
        }

        [Test]
        public void RemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_when_is_extract_for_remux_and_no_season_year_and_no_season_number_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    SeriesName = "BatchGuy",
                    Tag = "Guy",
                    VideoResolution = "1080p"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate1EAC3ToOutputNamingService(audioService);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy E01 1080p -Guy.mkv\"");
        }

        [Test]
        public void RemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_when_is_extract_for_remux_and_no_season_number_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    SeriesName = "BatchGuy",
                    SeasonYear = "1978",
                    Tag = "Guy",
                    VideoResolution = "1080p"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate1EAC3ToOutputNamingService(audioService);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy 1978 E01 1080p -Guy.mkv\"");
        }



        [Test]
        public void RemuxTemplate1EAC3ToOutputNamingService_can_set_audio_name_when_is_extract_for_remux_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    AudioType = "FLAC 5.1",
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                    SeasonYear = "1978",
                    Tag = "Guy",
                    VideoResolution = "1080p"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the audio name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate1EAC3ToOutputNamingService(audioService);
            BluRayTitleAudio audio = new BluRayTitleAudio() { Id = "5:", AudioType = EnumAudioType.DTS, Language = "english" };
            string audioName = service.GetAudioName(config, audio, filesOutputPath, paddedEpisodeNumber,episodeName);
            //then audio name should be based on the remux template
            audioName.Should().Be("\"c:\\bluray\\BatchGuy 1978 S02E01 1080p FLAC 5.1-Guy english01-5.dts\"");
        }



        [Test]
        public void RemuxTemplate1EAC3ToOutputNamingService_can_set_subtitle_name_when_is_extract_for_remux_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    AudioType = "FLAC 5.1",
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
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
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate1EAC3ToOutputNamingService(audioService);
            BluRayTitleSubtitle subtitle = new BluRayTitleSubtitle() {Id = "11:", Language = "english" };
            string subtitleName = service.GetSubtitleName(config, subtitle, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then subtitle name should be based on the remux template
            subtitleName.Should().Be("\"c:\\bluray\\BatchGuy 1978 S02E01 1080p Remux H.264 FLAC 5.1-Guy english01-11.sup\"");
        }

        [Test]
        public void RemuxTemplate1EAC3ToOutputNamingService_can_set_subtitle_name_when_is_extract_for_remux_and_only_required_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the subtitle name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate1EAC3ToOutputNamingService(audioService);
            BluRayTitleSubtitle subtitle = new BluRayTitleSubtitle() {Id = "3:", Language = "english" };
            string subtitleName = service.GetSubtitleName(config, subtitle, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then subtitle name should be based on the remux template
            subtitleName.Should().Be("\"c:\\bluray\\BatchGuy S02E01 english01-3.sup\"");
        }

        [Test]
        public void RemuxTemplate1EAC3ToOutputNamingService_can_set_log_name_when_is_extract_for_remux_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = "Episode 3";
            //when i get the subtitle name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate1EAC3ToOutputNamingService(audioService);
            string logName = service.GetLogName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then subtitle name should be based on the remux template
            logName.Should().Be(" -log=\"c:\\bluray\\BatchGuy S02E01 Episode 3 log.log\"");
        }



        [Test]
        public void RemuxTemplate1EAC3ToOutputNamingService_can_set_audio_commentary_when_is_commentary_and_extract_for_remux_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    AudioType = "FLAC 5.1",
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                    SeasonYear = "1978",
                    Tag = "Guy",
                    VideoResolution = "1080p"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the audio name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate1EAC3ToOutputNamingService(audioService);
            BluRayTitleAudio audio = new BluRayTitleAudio() { Id = "5:", AudioType = EnumAudioType.DTS, Language = "english", IsCommentary = true };
            string audioName = service.GetAudioName(config, audio, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then audio name should be based on the remux template and commentary
            audioName.Should().Be("\"c:\\bluray\\BatchGuy 1978 S02E01 1080p FLAC 5.1-Guy english01-5-commentary.dts\"");
        }



        [Test]
        public void RemuxTemplate1EAC3ToOutputNamingService_can_set_subtitle_name_when_is_commentary_and_is_extract_for_remux_and_only_required_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the subtitle name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate1EAC3ToOutputNamingService(audioService);
            BluRayTitleSubtitle subtitle = new BluRayTitleSubtitle() { Id = "3:", Language = "english", IsCommentary = true };
            string subtitleName = service.GetSubtitleName(config, subtitle, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then subtitle name should be based on the remux template and commentary
            subtitleName.Should().Be("\"c:\\bluray\\BatchGuy S02E01 english01-3-commentary.sup\"");
        }

        [Test]
        public void RemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_when_is_extract_for_remux_and_separate_with_spaces_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    AudioType = "FLAC 5.1",
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                    SeasonYear = "1978",
                    Tag = "Guy",
                    VideoResolution = "1080p",
                    UsePeriodsInFileName = false
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate1EAC3ToOutputNamingService(audioService);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy 1978 S02E01 1080p FLAC 5.1-Guy.mkv\"");
        }

        [Test]
        public void RemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_when_is_extract_for_remux_and_separate_with_periods_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    AudioType = "FLAC 5.1",
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                    SeasonYear = "1978",
                    Tag = "Guy",
                    VideoResolution = "1080p",
                    UsePeriodsInFileName = true
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate1EAC3ToOutputNamingService(audioService);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy.1978.S02E01.1080p.FLAC.5.1-Guy.mkv\"");
        }
    }
}

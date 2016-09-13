using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Eac3To.Abstracts;
using BatchGuy.App.Eac3To.Models;
using BatchGuy.App.Eac3To.Services;
using BatchGuy.App.Enums;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Shared.Services;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.Unit.Tests.Services.Eac3to
{
    [TestFixture]
    public class RemuxTemplate3EAC3ToOutputNamingServiceTests
    {
        [Test]
        public void remuxTemplate3EAC3ToOutputNamingService_can_set_video_name_test()
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
                    Medium = "Remux"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = "Episode One";
            //when i get the chapter name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate3EAC3ToOutputNamingService(audioService);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then chapter name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\2x01 Episode One.mkv\"");
        }

        [Test]
        public void remuxTemplate3EAC3ToOutputNamingService_can_set_video_name_no_season_number_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    AudioType = "FLAC 5.1",
                    SeriesName = "BatchGuy",
                    SeasonYear = "1978",
                    Tag = "Guy",
                    VideoResolution = "1080p",
                    Medium = "Remux"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = "Episode One";
            //when i get the chapter name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate3EAC3ToOutputNamingService(audioService);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then chapter name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\01 Episode One.mkv\"");
        }

        [Test]
        public void remuxTemplate3EAC3ToOutputNamingService_can_set_video_name_no_episode_name_test()
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
                    Medium = "Remux"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the chapter name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate3EAC3ToOutputNamingService(audioService);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then chapter name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\2x01.mkv\"");
        }

        [Test]
        public void remuxTemplate3EAC3ToOutputNamingService_can_set_video_name_no_season_number_and_no_episode_name_test()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    AudioType = "FLAC 5.1",
                    SeriesName = "BatchGuy",
                    SeasonYear = "1978",
                    Tag = "Guy",
                    VideoResolution = "1080p",
                    Medium = "Remux"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the chapter name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate3EAC3ToOutputNamingService(audioService);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then chapter name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\01.mkv\"");
        }

        [Test]
        public void remuxTemplate3EAC3ToOutputNamingService_can_set_audio_name_test()
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
            string episodeName = "Episode 1";
            //when i get the audio name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate3EAC3ToOutputNamingService(audioService);
            BluRayTitleAudio audio = new BluRayTitleAudio() { Id = "5:", AudioType = EnumAudioType.DTS, Language = "english" };
            string audioName = service.GetAudioName(config, audio, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then audio name should be based on the remux template
            audioName.Should().Be("\"c:\\bluray\\2x01 Episode 1 english01-5.dts\"");
        }

        [Test]
        public void remuxTemplate3EAC3ToOutputNamingService_can_set_audio_name_no_episode_name_test()
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
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate3EAC3ToOutputNamingService(audioService);
            BluRayTitleAudio audio = new BluRayTitleAudio() { Id = "5:", AudioType = EnumAudioType.DTS, Language = "english" };
            string audioName = service.GetAudioName(config, audio, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then audio name should be based on the remux template
            audioName.Should().Be("\"c:\\bluray\\2x01 english01-5.dts\"");
        }

        [Test]
        public void remuxTemplate3EAC3ToOutputNamingService_can_set_chapter_name_test()
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
                    Medium = "Remux"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = "A New Hope";
            //when i get the chapter name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate3EAC3ToOutputNamingService(audioService);
            string chapterName = service.GetChapterName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then chapter name should be based on the remux template
            chapterName.Should().Be("\"c:\\bluray\\2x01 A New Hope chapters.txt\"");
        }

        [Test]
        public void remuxTemplate3EAC3ToOutputNamingService_can_set_chapter_name_no_episode_name_test()
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
                    Medium = "Remux"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the chapter name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate3EAC3ToOutputNamingService(audioService);
            string chapterName = service.GetChapterName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then chapter name should be based on the remux template
            chapterName.Should().Be("\"c:\\bluray\\2x01 chapters.txt\"");
        }

        [Test]
        public void remuxTemplate3EAC3ToOutputNamingService_can_set_log_name_test()
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
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate3EAC3ToOutputNamingService(audioService);
            string logName = service.GetLogName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then subtitle name should be based on the remux template
            logName.Should().Be(" -log=\"c:\\bluray\\2x01 Episode 3 log.log\"");
        }

        [Test]
        public void remuxTemplate3EAC3ToOutputNamingService_can_set_log_name_no_episode_name_test()
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
            AbstractEAC3ToOutputNamingService service = new RemuxTemplate3EAC3ToOutputNamingService(audioService);
            string logName = service.GetLogName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then subtitle name should be based on the remux template
            logName.Should().Be(" -log=\"c:\\bluray\\2x01 log.log\"");
        }
    }
}

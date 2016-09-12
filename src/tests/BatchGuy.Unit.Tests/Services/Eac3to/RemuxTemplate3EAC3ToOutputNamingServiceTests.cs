using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Eac3To.Abstracts;
using BatchGuy.App.Eac3To.Models;
using BatchGuy.App.Eac3To.Services;
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
    }
}

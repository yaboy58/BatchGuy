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
    public class MovieRemuxTemplate1EAC3ToOutputNamingServiceTests
    {
        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_chapter_name_test()
        {
            //given not extract for remux
            EAC3ToRemuxFileNameTemplate movieRemuxTemplate = new EAC3ToRemuxFileNameTemplate()
            {
                AudioType = "FLAC 5.1",
                SeriesName = "BatchGuy",
                SeasonNumber = "2",
                SeasonYear = "1978",
                Tag = "Guy",
                VideoResolution = "1080p",
                Medium = "Remux"
            };
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                 IfIsExtractForRemuxIsItForAMovie = true
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the chapter name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService, movieRemuxTemplate);
            string chapterName = service.GetChapterName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then chapter name should be based on the remux template
            chapterName.Should().Be("\"c:\\bluray\\BatchGuy 1978 1080p Remux FLAC 5.1-Guy chapters.txt\"");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_test()
        {
            //given not extract for remux
            EAC3ToRemuxFileNameTemplate movieRemuxTemplate = new EAC3ToRemuxFileNameTemplate()
            {
                AudioType = "FLAC 5.1",
                SeriesName = "BatchGuy",
                SeasonNumber = "2",
                SeasonYear = "1978",
                Tag = "Guy",
                VideoResolution = "1080p"
            };
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true
            };

            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService, movieRemuxTemplate);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy 1978 1080p FLAC 5.1-Guy.mkv\"");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_when_use_periods_in_file_name_test()
        {
            //given not extract for remux
            EAC3ToRemuxFileNameTemplate movieRemuxTemplate = new EAC3ToRemuxFileNameTemplate()
            {
                AudioType = "FLAC 5.1",
                SeriesName = "BatchGuy",
                SeasonNumber = "2",
                SeasonYear = "1978",
                Tag = "Guy",
                VideoResolution = "1080p",
                UsePeriodsInFileName = true
            };

            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService,movieRemuxTemplate);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy.1978.1080p.FLAC.5.1-Guy.mkv\"");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_and_series_name_only_test()
        {
            //given not extract for remux
            EAC3ToRemuxFileNameTemplate movieRemuxTemplate = new EAC3ToRemuxFileNameTemplate()
            {
                SeriesName = "BatchGuy"
            };
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService, movieRemuxTemplate);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy.mkv\"");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_and_no_audio_type_test()
        {
            //given not extract for remux
            EAC3ToRemuxFileNameTemplate movieRemuxTemplate = new EAC3ToRemuxFileNameTemplate()
            {
                SeriesName = "BatchGuy",
                SeasonNumber = "2",
                SeasonYear = "1978",
                Tag = "Guy",
                VideoResolution = "1080p"
            };
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService, movieRemuxTemplate);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy 1978 1080p -Guy.mkv\"");
        }
    }
}

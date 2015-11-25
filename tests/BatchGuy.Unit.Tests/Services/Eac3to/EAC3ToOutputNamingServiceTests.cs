using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssert;
using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Eac3To.Services;
using BatchGuy.App.Eac3To.Models;
using BatchGuy.App.Extensions;
using BatchGuy.App.Helpers;

namespace BatchGuy.Unit.Tests.Services.Eac3to
{
    [TestFixture]
    public class EAC3ToOutputNamingServiceTests
    {
        [Test]
        public void eac3ToOutputNamingService_can_set_chapter_name_when_not_extract_for_remux()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration() { IsExtractForRemux = false };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            //when i get the chapter name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            string chapterName = service.GetChapterName(config, filesOutputPath, paddedEpisodeNumber);
            //then chapter name should be hard coded for workflow
            chapterName.ShouldBeEqualTo(string.Format("\"{0}\\chapters{1}.txt\"", filesOutputPath, paddedEpisodeNumber));
        }

        [Test]
        public void eac3ToOutputNamingService_can_set_chapter_name_when_is_extract_for_remux()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration() { IsExtractForRemux = true, RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate() { AudioType = "FLAC 5.1", SeasonName = "BatchGuy",
             SeasonNumber = 2, SeasonYear = 1978, Tag = "Guy", VideoResolution = "1080p"} };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            //when i get the chapter name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            string chapterName = service.GetChapterName(config, filesOutputPath, paddedEpisodeNumber);
            //then chapter name should be based on the remux template
            chapterName.ShouldBeEqualTo(string.Format("\"{0}\\BatchGuy S02E{1} 1080p Remux AVC FLAC 5.1-Guy chapters.txt\"",filesOutputPath, paddedEpisodeNumber));
        }

        [Test]
        public void eac3ToOutputNamingService_can_set_video_name_when_not_extract_for_remux()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration() { IsExtractForRemux = false };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            //when i get the video name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber);
            //then video name should be hard coded for workflow
            videoName.ShouldBeEqualTo(string.Format("\"{0}\\video{1}.mkv\"", filesOutputPath, paddedEpisodeNumber));
        }

        [Test]
        public void eac3ToOutputNamingService_can_set_video_name_when_is_extract_for_remux()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    AudioType = "FLAC 5.1",
                    SeasonName = "BatchGuy",
                    SeasonNumber = 2,
                    SeasonYear = 1978,
                    Tag = "Guy",
                    VideoResolution = "1080p"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            //when i get the video name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber);
            //then video name should be based on the remux template
            videoName.ShouldBeEqualTo(string.Format("\"{0}\\BatchGuy S02E{1} 1080p Remux AVC FLAC 5.1-Guy.mkv\"", filesOutputPath, paddedEpisodeNumber));
        }
    }
}

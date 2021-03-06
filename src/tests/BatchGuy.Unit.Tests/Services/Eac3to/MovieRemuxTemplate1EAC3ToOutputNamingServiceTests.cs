﻿using BatchGuy.App.Eac3to.Models;
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

namespace BatchGuy.Unit.Tests.Services.Eac3to
{
    [TestFixture]
    public class MovieRemuxTemplate1EAC3ToOutputNamingServiceTests
    {
        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_chapter_name_test()
        {
            //given not extract for remux
            BluRaySummaryInfo summary = new BluRaySummaryInfo()
            {
                IsSelected = true,
                RemuxFileNameForMovieTemplate = new EAC3ToRemuxFileNameTemplate()
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
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService);
            service.SetCurrentBluRaySummaryInfo(summary);
            string chapterName = service.GetChapterName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then chapter name should be based on the remux template
            chapterName.Should().Be("\"c:\\bluray\\BatchGuy 1978 1080p Remux FLAC 5.1-Guy chapters.txt\"");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_test()
        {
            //given not extract for remux
            BluRaySummaryInfo summary = new BluRaySummaryInfo() { IsSelected = true, RemuxFileNameForMovieTemplate =
                new EAC3ToRemuxFileNameTemplate()
                {
                    AudioType = "FLAC 5.1",
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                    SeasonYear = "1978",
                    Tag = "Guy",
                    VideoResolution = "1080p"
                }
            };

            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true
            };

            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            string extension = "mkv";
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService);
            service.SetCurrentBluRaySummaryInfo(summary);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName, extension);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy 1978 1080p FLAC 5.1-Guy.mkv\"");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_when_use_periods_in_file_name_test()
        {
            //given not extract for remux
            BluRaySummaryInfo summary = new BluRaySummaryInfo()
            {
                IsSelected = true,
                RemuxFileNameForMovieTemplate = new EAC3ToRemuxFileNameTemplate()
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

            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            string extension = "mkv";
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService);
            service.SetCurrentBluRaySummaryInfo(summary);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName, extension);

            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy.1978.1080p.FLAC.5.1-Guy.mkv\"");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_and_series_name_only_test()
        {
            //given not extract for remux
            BluRaySummaryInfo summary = new BluRaySummaryInfo() { IsSelected = true, RemuxFileNameForMovieTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    SeriesName = "BatchGuy"
                }
            };
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            string extension = "mkv";
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService);
            service.SetCurrentBluRaySummaryInfo(summary);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName, extension);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy.mkv\"");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_and_no_audio_type_test()
        {
            //given not extract for remux
            BluRaySummaryInfo summary = new BluRaySummaryInfo() { IsSelected = true, RemuxFileNameForMovieTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                    SeasonYear = "1978",
                    Tag = "Guy",
                    VideoResolution = "1080p"
                }
            };
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            string extension = "mkv";
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService);
            service.SetCurrentBluRaySummaryInfo(summary);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName, extension);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy 1978 1080p -Guy.mkv\"");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_and_no_tag_test()
        {
            //given not extract for remux
            BluRaySummaryInfo summary = new BluRaySummaryInfo() { IsSelected = true, RemuxFileNameForMovieTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                    SeasonYear = "1978"
                }
            };

            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = "Episode 1";
            string extension = "mkv";
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService);
            service.SetCurrentBluRaySummaryInfo(summary);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName, extension);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy 1978.mkv\"");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_and_no_season_year_test()
        {
            //given not extract for remux
            BluRaySummaryInfo summary = new BluRaySummaryInfo() { IsSelected = true, RemuxFileNameForMovieTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                    Tag = "Guy",
                    VideoResolution = "1080p"
                }
            };
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            string extension = "mkv";
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService);
            service.SetCurrentBluRaySummaryInfo(summary);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName, extension);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy 1080p -Guy.mkv\"");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_and_no_season_year_and_no_season_number_test()
        {
            //given not extract for remux
            BluRaySummaryInfo summary = new BluRaySummaryInfo() { IsSelected = true, RemuxFileNameForMovieTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    SeriesName = "BatchGuy",
                    Tag = "Guy",
                    VideoResolution = "1080p"
                }
            };
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            string extension = "mkv";
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService);
            service.SetCurrentBluRaySummaryInfo(summary);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName, extension);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy 1080p -Guy.mkv\"");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_and_no_season_number_test()
        {
            //given not extract for remux
            BluRaySummaryInfo summary = new BluRaySummaryInfo() { IsSelected = true, RemuxFileNameForMovieTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    SeriesName = "BatchGuy",
                    SeasonYear = "1978",
                    Tag = "Guy",
                    VideoResolution = "1080p"
                }
            };
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true    
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            string extension = "mkv";
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService);
            service.SetCurrentBluRaySummaryInfo(summary);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName, extension);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy 1978 1080p -Guy.mkv\"");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_audio_name_test()
        {
            //given not extract for remux
            BluRaySummaryInfo summary = new BluRaySummaryInfo() { IsSelected = true, RemuxFileNameForMovieTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    AudioType = "FLAC 5.1",
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                    SeasonYear = "1978",
                    Tag = "Guy",
                    VideoResolution = "1080p"
                }
            };
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the audio name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService);
            BluRayTitleAudio audio = new BluRayTitleAudio() { Id = "5:", AudioType = EnumAudioType.DTSMA, Language = "english" };
            service.SetCurrentBluRaySummaryInfo(summary);
            string audioName = service.GetAudioName(config, audio, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then audio name should be based on the remux template
            audioName.Should().Be("\"c:\\bluray\\BatchGuy 1978 1080p FLAC 5.1-Guy english01-5.dtsma\"");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_subtitle_name_test()
        {
            //given not extract for remux
            BluRaySummaryInfo summary = new BluRaySummaryInfo() { IsSelected = true, RemuxFileNameForMovieTemplate = new EAC3ToRemuxFileNameTemplate()
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
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the subtitle name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService);
            service.SetCurrentBluRaySummaryInfo(summary);
            BluRayTitleSubtitle subtitle = new BluRayTitleSubtitle() { Id = "11:", Language = "english" };
            string subtitleName = service.GetSubtitleName(config, subtitle, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then subtitle name should be based on the remux template
            subtitleName.Should().Be("\"c:\\bluray\\BatchGuy 1978 1080p Remux H.264 FLAC 5.1-Guy english01-11.sup\"");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_subtitle_name_and_only_required_test()
        {
            //given not extract for remux
            BluRaySummaryInfo summary = new BluRaySummaryInfo() { IsSelected = true, RemuxFileNameForMovieTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                }
            };
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the subtitle name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService);
            service.SetCurrentBluRaySummaryInfo(summary);
            BluRayTitleSubtitle subtitle = new BluRayTitleSubtitle() { Id = "3:", Language = "english" };
            string subtitleName = service.GetSubtitleName(config, subtitle, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then subtitle name should be based on the remux template
            subtitleName.Should().Be("\"c:\\bluray\\BatchGuy english01-3.sup\"");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_log_name_test()
        {
            //given not extract for remux
            BluRaySummaryInfo summary = new BluRaySummaryInfo() { IsSelected = true, RemuxFileNameForMovieTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                }
            };
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = "Episode 3";
            //when i get the subtitle name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService);
            service.SetCurrentBluRaySummaryInfo(summary);
            string logName = service.GetLogName(config, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then subtitle name should be based on the remux template
            logName.Should().Be(" -log=\"c:\\bluray\\BatchGuy log.log\"");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_audio_commentary_when_is_commentary_test()
        {
            //given not extract for remux
            BluRaySummaryInfo summary = new BluRaySummaryInfo() { IsSelected = true, RemuxFileNameForMovieTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    AudioType = "FLAC 5.1",
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                    SeasonYear = "1978",
                    Tag = "Guy",
                    VideoResolution = "1080p"
                }
            };
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the audio name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService);
            service.SetCurrentBluRaySummaryInfo(summary);
            BluRayTitleAudio audio = new BluRayTitleAudio() { Id = "5:", AudioType = EnumAudioType.DTSMA, Language = "english", IsCommentary = true };
            string audioName = service.GetAudioName(config, audio, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then audio name should be based on the remux template and commentary
            audioName.Should().Be("\"c:\\bluray\\BatchGuy 1978 1080p FLAC 5.1-Guy english01-5-commentary.dtsma\"");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_subtitle_name_when_is_commentary_and_only_required_test()
        {
            //given not extract for remux
            BluRaySummaryInfo summary = new BluRaySummaryInfo() { IsSelected = true, RemuxFileNameForMovieTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                }
            };

            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            //when i get the subtitle name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService);
            service.SetCurrentBluRaySummaryInfo(summary);
            BluRayTitleSubtitle subtitle = new BluRayTitleSubtitle() { Id = "3:", Language = "english", IsCommentary = true };
            string subtitleName = service.GetSubtitleName(config, subtitle, filesOutputPath, paddedEpisodeNumber, episodeName);
            //then subtitle name should be based on the remux template and commentary
            subtitleName.Should().Be("\"c:\\bluray\\BatchGuy english01-3-commentary.sup\"");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_and_separate_with_spaces_test()
        {
            //given not extract for remux
            BluRaySummaryInfo summary = new BluRaySummaryInfo() { IsSelected = true, RemuxFileNameForMovieTemplate = new EAC3ToRemuxFileNameTemplate()
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

            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            string extension = "mkv";
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService);
            service.SetCurrentBluRaySummaryInfo(summary);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName, extension);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy 1978 1080p FLAC 5.1-Guy.mkv\"");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_and_separate_with_periods_test()
        {
            //given not extract for remux
            BluRaySummaryInfo summary = new BluRaySummaryInfo() { IsSelected = true, RemuxFileNameForMovieTemplate = new EAC3ToRemuxFileNameTemplate()
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
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            string extension = "mkv";
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService);
            service.SetCurrentBluRaySummaryInfo(summary);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName, extension);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy.1978.1080p.FLAC.5.1-Guy.mkv\"");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_getvideoname_throws_exception_when_currentMovieRemuxTemplate_is_null_test()
        {
            //given not extract for remux
            BluRaySummaryInfo summary = new BluRaySummaryInfo()
            {
                IsSelected = true,
                RemuxFileNameForMovieTemplate =
                new EAC3ToRemuxFileNameTemplate()
                {
                    AudioType = "FLAC 5.1",
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                    SeasonYear = "1978",
                    Tag = "Guy",
                    VideoResolution = "1080p"
                }
            };

            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true
            };

            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            string extension = "mkv";
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService);
            Action action = () => service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName, extension);
            //then video name should throw an exception
            action.ShouldThrow<NullReferenceException>().WithMessage("Current Movie Template is Null.");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_with_country_test()
        {
            //given not extract for remux
            BluRaySummaryInfo summary = new BluRaySummaryInfo()
            {
                IsSelected = true,
                RemuxFileNameForMovieTemplate =
                new EAC3ToRemuxFileNameTemplate()
                {
                    AudioType = "FLAC 5.1",
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                    SeasonYear = "1978",
                    Tag = "Guy",
                    VideoResolution = "1080p",
                    Country = "PNG"
                }
            };

            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true
            };

            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            string extension = "mkv";
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService);
            service.SetCurrentBluRaySummaryInfo(summary);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName, extension);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy 1978 1080p PNG FLAC 5.1-Guy.mkv\"");
        }

        [Test]
        public void movieRemuxTemplate1EAC3ToOutputNamingService_can_set_video_name_when_mpeg2_video_format_test()
        {
            //given not extract for remux
            BluRaySummaryInfo summary = new BluRaySummaryInfo()
            {
                IsSelected = true,
                RemuxFileNameForMovieTemplate =
                new EAC3ToRemuxFileNameTemplate()
                {
                    AudioType = "FLAC 5.1",
                    SeriesName = "BatchGuy",
                    SeasonNumber = "2",
                    SeasonYear = "1978",
                    Tag = "Guy",
                    VideoResolution = "1080p",
                    VideoFormat = "MPEG-2"
                }
            };

            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                IfIsExtractForRemuxIsItForAMovie = true
            };

            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            string episodeName = string.Empty;
            string extension = "mkv";
            //when i get the video name
            IAudioService audioService = new AudioService();
            AbstractEAC3ToOutputNamingService service = new MovieRemuxTemplate1EAC3ToOutputNamingService(audioService);
            service.SetCurrentBluRaySummaryInfo(summary);
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber, episodeName, extension);
            //then video name should be based on the remux template
            videoName.Should().Be("\"c:\\bluray\\BatchGuy 1978 1080p MPEG-2 FLAC 5.1-Guy.mkv\"");
        }
    }
}

using BatchGuy.App.Eac3To.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Extensions;
using BatchGuy.App.Eac3To.Models;

namespace BatchGuy.App.Eac3To.Services
{
    public class MovieRemuxTemplate1EAC3ToOutputNamingService : AbstractEAC3ToOutputNamingService
    {
        public MovieRemuxTemplate1EAC3ToOutputNamingService(IAudioService audioService) : base(audioService)
        {
            _enumEAC3ToNamingConventionType = Enums.EnumEAC3ToNamingConventionType.MovieRemuxNamingConventionTemplate1;
        }

        public override string GetAudioName(EAC3ToConfiguration eac3toConfiguration, BluRayTitleAudio audio, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            if (_currentMovieRemuxTemplate == null)
                throw new NullReferenceException("Current Movie Template is Null.");

            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux == true && eac3toConfiguration.IfIsExtractForRemuxIsItForAMovie)
            {
                string tag = this.GetFormattedTag(eac3toConfiguration, paddedEpisodeNumber);
                string audioName = string.Format("{0}{1}{2}{3}{4}{5}{6}", 
                    _currentMovieRemuxTemplate.SeriesName, 
                    this.GetFormattedYear(eac3toConfiguration),
                    this.GetFormattedVideoResolution(eac3toConfiguration),
                    this.GetFormattedCountry(eac3toConfiguration),
                    this.GetFormattedMedium(eac3toConfiguration),
                    this.GetFormattedVideoFormat(eac3toConfiguration), 
                    this.GetFormattedAuditoType(eac3toConfiguration));

                sb.Append(string.Format("\"{0}\\{1}{2} {3}{4}-{5}{6}.{7}\"", filesOutputPath, this.AddWordSeparator(eac3toConfiguration.IsExtractForRemux, _currentMovieRemuxTemplate.UsePeriodsInFileName, audioName.Trim().RemoveDoubleSpaces()), tag, audio.Language, paddedEpisodeNumber, audio.Id.RemoveColons(),
                    this.GetAudioCommentary(audio), _audioService.GetAudioExtension(audio.AudioType)));
            }
            return sb.ToString();
        }

        public override string GetChapterName(EAC3ToConfiguration eac3toConfiguration, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            if (_currentMovieRemuxTemplate == null)
                throw new NullReferenceException("Current Movie Template is Null.");

            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux == true && eac3toConfiguration.IfIsExtractForRemuxIsItForAMovie)
            {
                string tag = this.GetFormattedTag(eac3toConfiguration, paddedEpisodeNumber);
                string chapterName = string.Format("{0}{1}{2}{3}{4}{5}{6}", 
                    _currentMovieRemuxTemplate.SeriesName, 
                    this.GetFormattedYear(eac3toConfiguration),
                    this.GetFormattedVideoResolution(eac3toConfiguration),
                    this.GetFormattedCountry(eac3toConfiguration),
                    this.GetFormattedMedium(eac3toConfiguration),
                    this.GetFormattedVideoFormat(eac3toConfiguration), 
                    this.GetFormattedAuditoType(eac3toConfiguration));

                sb.Append(string.Format("\"{0}\\{1}{2} chapters.txt\"", filesOutputPath, this.AddWordSeparator(eac3toConfiguration.IsExtractForRemux, _currentMovieRemuxTemplate.UsePeriodsInFileName, chapterName.Trim().RemoveDoubleSpaces()), tag));
            }
            return sb.ToString();
        }

        public override string GetLogName(EAC3ToConfiguration eac3toConfiguration, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            if (_currentMovieRemuxTemplate == null)
                throw new NullReferenceException("Current Movie Template is Null.");

            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux == true)
            {
                string tag = this.GetFormattedTag(eac3toConfiguration, paddedEpisodeNumber);
                string logName = string.Format("{0}{1}{2}{3}{4}{5}{6}", 
                    _currentMovieRemuxTemplate.SeriesName, 
                    this.GetFormattedYear(eac3toConfiguration),
                    this.GetFormattedVideoResolution(eac3toConfiguration),
                    this.GetFormattedCountry(eac3toConfiguration),
                    this.GetFormattedMedium(eac3toConfiguration),
                    this.GetFormattedVideoFormat(eac3toConfiguration), 
                    this.GetFormattedAuditoType(eac3toConfiguration));

                sb.Append(string.Format(" -log=\"{0}\\{1}{2} log.log\"", filesOutputPath, this.AddWordSeparator(eac3toConfiguration.IsExtractForRemux, _currentMovieRemuxTemplate.UsePeriodsInFileName, logName.Trim().RemoveDoubleSpaces()), tag));
            }
            return sb.ToString();
        }

        public override string GetSubtitleName(EAC3ToConfiguration eac3toConfiguration, BluRayTitleSubtitle subtitle, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            if (_currentMovieRemuxTemplate == null)
                throw new NullReferenceException("Current Movie Template is Null.");

            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux == true && eac3toConfiguration.IfIsExtractForRemuxIsItForAMovie)
            {
                string tag = this.GetFormattedTag(eac3toConfiguration, paddedEpisodeNumber);
                string subtitleName = string.Format("{0}{1}{2}{3}{4}{5}{6}", 
                    _currentMovieRemuxTemplate.SeriesName, 
                    this.GetFormattedYear(eac3toConfiguration),
                    this.GetFormattedVideoResolution(eac3toConfiguration),
                    this.GetFormattedCountry(eac3toConfiguration),
                    this.GetFormattedMedium(eac3toConfiguration),
                    this.GetFormattedVideoFormat(eac3toConfiguration), 
                    this.GetFormattedAuditoType(eac3toConfiguration));

                sb.Append(string.Format("\"{0}\\{1}{2} {3}{4}-{5}{6}.sup\"", filesOutputPath, this.AddWordSeparator(eac3toConfiguration.IsExtractForRemux, _currentMovieRemuxTemplate.UsePeriodsInFileName, subtitleName.Trim().RemoveDoubleSpaces()), tag, subtitle.Language, paddedEpisodeNumber, subtitle.Id.RemoveColons(), this.GetSubtitleCommentary(subtitle)));
            }
            return sb.ToString();
        }

        public override string GetVideoName(EAC3ToConfiguration eac3toConfiguration, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            if (_currentMovieRemuxTemplate == null)
                throw new NullReferenceException("Current Movie Template is Null.");

            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux == true && eac3toConfiguration.IfIsExtractForRemuxIsItForAMovie)
            {
                string tag = this.GetFormattedTag(eac3toConfiguration, paddedEpisodeNumber);
                string videoName = string.Format("{0}{1}{2}{3}{4}{5}{6}", 
                    _currentMovieRemuxTemplate.SeriesName, 
                    this.GetFormattedYear(eac3toConfiguration),
                    this.GetFormattedVideoResolution(eac3toConfiguration), 
                    this.GetFormattedCountry(eac3toConfiguration),
                    this.GetFormattedMedium(eac3toConfiguration),
                    this.GetFormattedVideoFormat(eac3toConfiguration), 
                    this.GetFormattedAuditoType(eac3toConfiguration));

                sb.Append(string.Format("\"{0}\\{1}{2}.mkv\"", filesOutputPath, this.AddWordSeparator(eac3toConfiguration.IsExtractForRemux, _currentMovieRemuxTemplate.UsePeriodsInFileName, videoName.Trim().RemoveDoubleSpaces()), tag));
            }
            return sb.ToString();
        }


        private string GetFormattedYear(EAC3ToConfiguration eac3toConfiguration)
        {
            string year = " ";
            if (_currentMovieRemuxTemplate.SeasonYear != null)
                year = string.Format(" {0} ", _currentMovieRemuxTemplate.SeasonYear);
            return year;
        }

        private string GetFormattedVideoResolution(EAC3ToConfiguration eac3toConfiguration)
        {
            string videoResolution = string.Empty;
            if (!string.IsNullOrEmpty(_currentMovieRemuxTemplate.VideoResolution))
                videoResolution = string.Format(" {0} ", _currentMovieRemuxTemplate.VideoResolution);
            return videoResolution;
        }

        private string GetFormattedMedium(EAC3ToConfiguration eac3toConfiguration)
        {
            string medium = string.Empty;
            if (!string.IsNullOrEmpty(_currentMovieRemuxTemplate.Medium))
                medium = string.Format(" {0} ", _currentMovieRemuxTemplate.Medium);
            return medium;
        }

        private string GetFormattedVideoFormat(EAC3ToConfiguration eac3toConfiguration)
        {
            string videoFormat = string.Empty;
            if (!string.IsNullOrEmpty(_currentMovieRemuxTemplate.VideoFormat))
                videoFormat = string.Format(" {0} ", _currentMovieRemuxTemplate.VideoFormat);
            return videoFormat;
        }

        private string GetFormattedAuditoType(EAC3ToConfiguration eac3toConfiguration)
        {
            string audioType = string.Empty;
            if (!string.IsNullOrEmpty(_currentMovieRemuxTemplate.AudioType))
                audioType = string.Format(" {0} ", _currentMovieRemuxTemplate.AudioType);
            return audioType;
        }

        private string GetFormattedTag(EAC3ToConfiguration eac3toConfiguration, string paddedEpisodeNumber)
        {
            string tag = string.Empty;
            if (string.IsNullOrEmpty(_currentMovieRemuxTemplate.Tag))
                return tag;

            if (string.IsNullOrEmpty(this.GetFormattedAuditoType(eac3toConfiguration).Trim()))
            {
                tag = string.Format(" -{0}", _currentMovieRemuxTemplate.Tag);
            }
            else
            {
                tag = string.Format("-{0}", _currentMovieRemuxTemplate.Tag);
            }
            return tag;
        }

        private string GetFormattedCountry(EAC3ToConfiguration eac3toConfiguration)
        {
            string country = string.Empty;
            if (!string.IsNullOrEmpty(_currentMovieRemuxTemplate.Country))
                country = string.Format(" {0} ", _currentMovieRemuxTemplate.Country);
            return country;
        }
    }
}

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
        private EAC3ToRemuxFileNameTemplate _movieRemuxTemplate;
        public MovieRemuxTemplate1EAC3ToOutputNamingService(IAudioService audioService, EAC3ToRemuxFileNameTemplate movieRemuxTemplate) : base(audioService)
        {
            _enumEAC3ToNamingConventionType = Enums.EnumEAC3ToNamingConventionType.MovieRemuxNamingConventionTemplate1;
            _movieRemuxTemplate = movieRemuxTemplate;
        }

        public override string GetAudioName(EAC3ToConfiguration eac3toConfiguration, BluRayTitleAudio audio, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            throw new NotImplementedException();
        }

        public override string GetChapterName(EAC3ToConfiguration eac3toConfiguration, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux == true && eac3toConfiguration.IfIsExtractForRemuxIsItForAMovie)
            {
                string tag = this.GetFormattedTag(eac3toConfiguration, paddedEpisodeNumber, episodeName);
                string chapterName = string.Format("{0}{1}{2}{3}{4}{5}", _movieRemuxTemplate.SeriesName, this.GetFormattedYear(eac3toConfiguration),
                    this.GetFormattedVideoResolution(eac3toConfiguration), this.GetFormattedMedium(eac3toConfiguration),
                    this.GetFormattedVideoFormat(eac3toConfiguration), this.GetFormattedAuditoType(eac3toConfiguration));

                sb.Append(string.Format("\"{0}\\{1}{2} chapters.txt\"", filesOutputPath, this.AddWordSeparator(eac3toConfiguration.IsExtractForRemux, _movieRemuxTemplate.UsePeriodsInFileName, chapterName.Trim().RemoveDoubleSpaces()), tag));
            }
            return sb.ToString();
        }

        public override string GetLogName(EAC3ToConfiguration eac3toConfiguration, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            throw new NotImplementedException();
        }

        public override string GetSubtitleName(EAC3ToConfiguration eac3toConfiguration, BluRayTitleSubtitle subtitle, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            throw new NotImplementedException();
        }

        public override string GetVideoName(EAC3ToConfiguration eac3toConfiguration, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux == true && eac3toConfiguration.IfIsExtractForRemuxIsItForAMovie)
            {
                string tag = this.GetFormattedTag(eac3toConfiguration, paddedEpisodeNumber, episodeName);
                string videoName = string.Format("{0}{1}{2}{3}{4}{5}", _movieRemuxTemplate.SeriesName, this.GetFormattedYear(eac3toConfiguration),
                    this.GetFormattedVideoResolution(eac3toConfiguration), this.GetFormattedMedium(eac3toConfiguration),
                    this.GetFormattedVideoFormat(eac3toConfiguration), this.GetFormattedAuditoType(eac3toConfiguration));

                sb.Append(string.Format("\"{0}\\{1}{2}.mkv\"", filesOutputPath, this.AddWordSeparator(eac3toConfiguration.IsExtractForRemux, _movieRemuxTemplate.UsePeriodsInFileName, videoName.Trim().RemoveDoubleSpaces()), tag));
            }
            return sb.ToString();
        }


        private string GetFormattedYear(EAC3ToConfiguration eac3toConfiguration)
        {
            string year = " ";
            if (_movieRemuxTemplate.SeasonYear != null)
                year = string.Format(" {0} ", _movieRemuxTemplate.SeasonYear);
            return year;
        }

        private string GetFormattedVideoResolution(EAC3ToConfiguration eac3toConfiguration)
        {
            string videoResolution = string.Empty;
            if (!string.IsNullOrEmpty(_movieRemuxTemplate.VideoResolution))
                videoResolution = string.Format(" {0} ", _movieRemuxTemplate.VideoResolution);
            return videoResolution;
        }

        private string GetFormattedMedium(EAC3ToConfiguration eac3toConfiguration)
        {
            string medium = string.Empty;
            if (!string.IsNullOrEmpty(_movieRemuxTemplate.Medium))
                medium = string.Format(" {0} ", _movieRemuxTemplate.Medium);
            return medium;
        }

        private string GetFormattedVideoFormat(EAC3ToConfiguration eac3toConfiguration)
        {
            string videoFormat = string.Empty;
            if (!string.IsNullOrEmpty(_movieRemuxTemplate.VideoFormat))
                videoFormat = string.Format(" {0} ", _movieRemuxTemplate.VideoFormat);
            return videoFormat;
        }

        private string GetFormattedAuditoType(EAC3ToConfiguration eac3toConfiguration)
        {
            string audioType = string.Empty;
            if (!string.IsNullOrEmpty(_movieRemuxTemplate.AudioType))
                audioType = string.Format(" {0} ", _movieRemuxTemplate.AudioType);
            return audioType;
        }

        private string GetFormattedTag(EAC3ToConfiguration eac3toConfiguration, string paddedEpisodeNumber, string episodeName)
        {
            string tag = string.Empty;
            if (string.IsNullOrEmpty(_movieRemuxTemplate.Tag))
                return tag;

            if (string.IsNullOrEmpty(this.GetFormattedAuditoType(eac3toConfiguration).Trim()))
            {
                tag = string.Format(" -{0}", _movieRemuxTemplate.Tag);
            }
            else
            {
                tag = string.Format("-{0}", _movieRemuxTemplate.Tag);
            }
            return tag;
        }
    }
}

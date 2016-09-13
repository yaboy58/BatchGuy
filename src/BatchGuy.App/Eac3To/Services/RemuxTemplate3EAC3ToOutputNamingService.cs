using BatchGuy.App.Eac3To.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Enums;
using BatchGuy.App.Extensions;

namespace BatchGuy.App.Eac3To.Services
{
    public class RemuxTemplate3EAC3ToOutputNamingService : AbstractEAC3ToOutputNamingService
    {
        public RemuxTemplate3EAC3ToOutputNamingService(IAudioService audioService) : base(audioService)
        {
            _enumEAC3ToNamingConventionType = EnumEAC3ToNamingConventionType.RemuxNamingConventionTemplate3;
        }

        public override string GetAudioName(EAC3ToConfiguration eac3toConfiguration, BluRayTitleAudio audio, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux == true)
            {
                string audioName = string.Format("{0}{1}{2}", this.GetFormattedSeasonNumber(eac3toConfiguration),
                    this.GetFormattedPaddedEpisodeNumber(paddedEpisodeNumber), this.GetFormattedEpisodeName(episodeName));

                sb.Append(string.Format("\"{0}\\{1} {2}{3}-{4}{5}.{6}\"", filesOutputPath, this.AddWordSeparator(eac3toConfiguration, audioName.Trim().RemoveDoubleSpaces()), audio.Language, paddedEpisodeNumber, audio.Id.RemoveColons(),
                    this.GetAudioCommentary(audio), _audioService.GetAudioExtension(audio.AudioType)));
            }
            return sb.ToString();
        }

        public override string GetChapterName(EAC3ToConfiguration eac3toConfiguration, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux == true)
            {
                string chapterName = string.Format("{0}{1}{2}", this.GetFormattedSeasonNumber(eac3toConfiguration),
                    this.GetFormattedPaddedEpisodeNumber(paddedEpisodeNumber), this.GetFormattedEpisodeName(episodeName));

                sb.Append(string.Format("\"{0}\\{1} chapters.txt\"", filesOutputPath, this.AddWordSeparator(eac3toConfiguration, chapterName.Trim().RemoveDoubleSpaces())));
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
            if (eac3toConfiguration.IsExtractForRemux == true)
            {
                string videoName = string.Format("{0}{1}{2}", this.GetFormattedSeasonNumber(eac3toConfiguration),
                    this.GetFormattedPaddedEpisodeNumber(paddedEpisodeNumber), this.GetFormattedEpisodeName(episodeName));

                sb.Append(string.Format("\"{0}\\{1}.mkv\"", filesOutputPath, this.AddWordSeparator(eac3toConfiguration, videoName.Trim().RemoveDoubleSpaces())));
            }
            return sb.ToString();
        }

        private string GetFormattedSeasonNumber(EAC3ToConfiguration eac3toConfiguration)
        {
            string formattedSeasonNumber = string.Empty;
            if (!string.IsNullOrEmpty(eac3toConfiguration.RemuxFileNameTemplate.SeasonNumber) && eac3toConfiguration.RemuxFileNameTemplate.SeasonNumber.IsNumeric())
                formattedSeasonNumber = string.Format("{0}x", eac3toConfiguration.RemuxFileNameTemplate.SeasonNumber.StringToInt());

            return formattedSeasonNumber;
        }

        private string GetFormattedPaddedEpisodeNumber(string paddedEpisodeNumber)
        {
            string formmattedpaddedEpisodeNumber = string.Format("{0}", paddedEpisodeNumber.Trim());

            return formmattedpaddedEpisodeNumber;
        }

        private string GetFormattedEpisodeName(string episodeName)
        {
            string formmattedEpisodeName = string.Empty;
            if (!string.IsNullOrEmpty(episodeName))
                formmattedEpisodeName = string.Format(" {0}", episodeName.Trim());

            return formmattedEpisodeName;
        }
    }
}

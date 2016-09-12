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
    public class RemuxTemplate2EAC3ToOutputNamingService : AbstractEAC3ToOutputNamingService
    {
        public RemuxTemplate2EAC3ToOutputNamingService(IAudioService audioService) : base(audioService)
        {
            _enumEAC3ToNamingConventionType = EnumEAC3ToNamingConventionType.RemuxNamingConventionTemplate2;
        }

        public override string GetAudioName(EAC3ToConfiguration eac3toConfiguration, BluRayTitleAudio audio, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            throw new NotImplementedException();
        }

        public override string GetChapterName(EAC3ToConfiguration eac3toConfiguration, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            throw new NotImplementedException();
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
                string videoName = string.Format("{0}, {1}E{2}{3}", eac3toConfiguration.RemuxFileNameTemplate.SeriesName, this.GetFormattedSeasonNumber(eac3toConfiguration), 
                    this.GetFormattedPaddedEpisodeNumber(paddedEpisodeNumber), this.GetFormattedYear(eac3toConfiguration));

                sb.Append(string.Format("\"{0}\\{1}.mkv\"", filesOutputPath, this.AddWordSeparator(eac3toConfiguration, videoName.Trim().RemoveDoubleSpaces())));
            }
            return sb.ToString();
        }

        private string GetFormattedSeasonNumber(EAC3ToConfiguration eac3toConfiguration)
        {
            string formattedSeasonNumber = string.Empty;
            if (!string.IsNullOrEmpty(eac3toConfiguration.RemuxFileNameTemplate.SeasonNumber) && eac3toConfiguration.RemuxFileNameTemplate.SeasonNumber.IsNumeric())
                formattedSeasonNumber = string.Format("S{0}", this.PadNumberWithZeros(eac3toConfiguration.NumberOfEpisodes, eac3toConfiguration.RemuxFileNameTemplate.SeasonNumber.StringToInt()));

            return formattedSeasonNumber;
        }

        private string GetFormattedPaddedEpisodeNumber(string paddedEpisodeNumber)
        {
            string formmattedpaddedEpisodeNumber = string.Format("{0} ", paddedEpisodeNumber.Trim());

            return formmattedpaddedEpisodeNumber;
        }

        private string GetFormattedYear(EAC3ToConfiguration eac3toConfiguration)
        {
            string year = " ";
            if (eac3toConfiguration.RemuxFileNameTemplate.SeasonYear != null && eac3toConfiguration.RemuxFileNameTemplate.SeasonYear != string.Empty)
                year = string.Format(" ({0}) ", eac3toConfiguration.RemuxFileNameTemplate.SeasonYear);
            return year;
        }
    }
}

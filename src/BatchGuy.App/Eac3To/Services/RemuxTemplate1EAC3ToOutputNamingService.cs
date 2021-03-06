﻿using BatchGuy.App.Eac3To.Abstracts;
using System.Text;
using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Extensions;
using BatchGuy.App.Enums;

namespace BatchGuy.App.Eac3To.Services
{
    public class RemuxTemplate1EAC3ToOutputNamingService : AbstractEAC3ToOutputNamingService
    {
        public RemuxTemplate1EAC3ToOutputNamingService(IAudioService audioService) : base(audioService)
        {
            _enumEAC3ToNamingConventionType = EnumEAC3ToNamingConventionType.RemuxNamingConventionTemplate1;
        }

        public override string GetAudioName(EAC3ToConfiguration eac3toConfiguration, BluRayTitleAudio audio, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux == true)
            {
                string tag = this.GetFormattedTag(eac3toConfiguration, paddedEpisodeNumber, episodeName);
                string audioName = string.Format("{0}{1}{2}E{3}{4}{5}{6}{7}{8}{9}", 
                    eac3toConfiguration.RemuxFileNameTemplate.SeriesName, 
                    this.GetFormattedYear(eac3toConfiguration),
                    this.GetFormattedSeasonNumber(eac3toConfiguration),
                    this.GetFormattedPaddedEpisodeNumber(paddedEpisodeNumber), 
                    this.GetFormattedEpisodeName(episodeName), 
                    this.GetFormattedVideoResolution(eac3toConfiguration), 
                    this.GetFormattedCountry(eac3toConfiguration),
                    this.GetFormattedMedium(eac3toConfiguration),
                    this.GetFormattedVideoFormat(eac3toConfiguration), 
                    this.GetFormattedAuditoType(eac3toConfiguration));

                sb.Append(string.Format("\"{0}\\{1}{2} {3}{4}-{5}{6}.{7}\"", filesOutputPath, this.AddWordSeparator(eac3toConfiguration.IsExtractForRemux,eac3toConfiguration.RemuxFileNameTemplate.UsePeriodsInFileName, audioName.Trim().RemoveDoubleSpaces()), tag, audio.Language, paddedEpisodeNumber, audio.Id.RemoveColons(),
                    this.GetAudioCommentary(audio), _audioService.GetAudioExtension(audio.AudioType)));
            }
            return sb.ToString();
        }

        public override string GetChapterName(EAC3ToConfiguration eac3toConfiguration, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux == true)
            {
                string tag = this.GetFormattedTag(eac3toConfiguration, paddedEpisodeNumber, episodeName);
                string chapterName = string.Format("{0}{1}{2}E{3}{4}{5}{6}{7}{8}{9}", 
                    eac3toConfiguration.RemuxFileNameTemplate.SeriesName,
                    this.GetFormattedYear(eac3toConfiguration), 
                    this.GetFormattedSeasonNumber(eac3toConfiguration), 
                    this.GetFormattedPaddedEpisodeNumber(paddedEpisodeNumber),
                    this.GetFormattedEpisodeName(episodeName), 
                    this.GetFormattedVideoResolution(eac3toConfiguration), 
                    this.GetFormattedCountry(eac3toConfiguration),
                    this.GetFormattedMedium(eac3toConfiguration), 
                    this.GetFormattedVideoFormat(eac3toConfiguration),
                    this.GetFormattedAuditoType(eac3toConfiguration));

                sb.Append(string.Format("\"{0}\\{1}{2} chapters.txt\"", filesOutputPath, this.AddWordSeparator(eac3toConfiguration.IsExtractForRemux, eac3toConfiguration.RemuxFileNameTemplate.UsePeriodsInFileName, chapterName.Trim().RemoveDoubleSpaces()), tag));
            }
            return sb.ToString();
        }

        public override string GetLogName(EAC3ToConfiguration eac3toConfiguration, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux == true)
            {
                string tag = this.GetFormattedTag(eac3toConfiguration, paddedEpisodeNumber, episodeName);
                string logName = string.Format("{0}{1}{2}E{3}{4}{5}{6}{7}{8}{9}", 
                    eac3toConfiguration.RemuxFileNameTemplate.SeriesName, 
                    this.GetFormattedYear(eac3toConfiguration),
                    this.GetFormattedSeasonNumber(eac3toConfiguration),
                    paddedEpisodeNumber, 
                    this.GetFormattedEpisodeName(episodeName), 
                    this.GetFormattedVideoResolution(eac3toConfiguration),
                    this.GetFormattedCountry(eac3toConfiguration),
                    this.GetFormattedMedium(eac3toConfiguration),
                    this.GetFormattedVideoFormat(eac3toConfiguration), 
                    this.GetFormattedAuditoType(eac3toConfiguration));

                sb.Append(string.Format(" -log=\"{0}\\{1}{2} log.log\"", filesOutputPath, this.AddWordSeparator(eac3toConfiguration.IsExtractForRemux, eac3toConfiguration.RemuxFileNameTemplate.UsePeriodsInFileName, logName.Trim().RemoveDoubleSpaces()), tag));
            }
            return sb.ToString();
        }

        public override string GetSubtitleName(EAC3ToConfiguration eac3toConfiguration, BluRayTitleSubtitle subtitle, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux == true)
            {
                string tag = this.GetFormattedTag(eac3toConfiguration, paddedEpisodeNumber, episodeName);
                string subtitleName = string.Format("{0}{1}{2}E{3}{4}{5}{6}{7}{8}{9}", 
                    eac3toConfiguration.RemuxFileNameTemplate.SeriesName, 
                    this.GetFormattedYear(eac3toConfiguration),
                    this.GetFormattedSeasonNumber(eac3toConfiguration),
                    this.GetFormattedPaddedEpisodeNumber(paddedEpisodeNumber), 
                    this.GetFormattedEpisodeName(episodeName), 
                    this.GetFormattedVideoResolution(eac3toConfiguration),
                    this.GetFormattedCountry(eac3toConfiguration),
                    this.GetFormattedMedium(eac3toConfiguration),
                    this.GetFormattedVideoFormat(eac3toConfiguration), 
                    this.GetFormattedAuditoType(eac3toConfiguration));

                sb.Append(string.Format("\"{0}\\{1}{2} {3}{4}-{5}{6}.sup\"", filesOutputPath, this.AddWordSeparator(eac3toConfiguration.IsExtractForRemux, eac3toConfiguration.RemuxFileNameTemplate.UsePeriodsInFileName, subtitleName.Trim().RemoveDoubleSpaces()), tag, subtitle.Language, paddedEpisodeNumber, subtitle.Id.RemoveColons(), this.GetSubtitleCommentary(subtitle)));
            }
            return sb.ToString();
        }

        public override string GetVideoName(EAC3ToConfiguration eac3toConfiguration, string filesOutputPath, string paddedEpisodeNumber, string episodeName, string extension)
        {
            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux == true)
            {
                string tag = this.GetFormattedTag(eac3toConfiguration, paddedEpisodeNumber, episodeName);
                string videoName = string.Format("{0}{1}{2}E{3}{4}{5}{6}{7}{8}{9}", 
                    eac3toConfiguration.RemuxFileNameTemplate.SeriesName, 
                    this.GetFormattedYear(eac3toConfiguration),
                    this.GetFormattedSeasonNumber(eac3toConfiguration),
                    this.GetFormattedPaddedEpisodeNumber(paddedEpisodeNumber), 
                    this.GetFormattedEpisodeName(episodeName), 
                    this.GetFormattedVideoResolution(eac3toConfiguration), 
                    this.GetFormattedCountry(eac3toConfiguration),
                    this.GetFormattedMedium(eac3toConfiguration), 
                    this.GetFormattedVideoFormat(eac3toConfiguration), 
                    this.GetFormattedAuditoType(eac3toConfiguration));

                sb.Append(string.Format("\"{0}\\{1}{2}.{3}\"", filesOutputPath, this.AddWordSeparator(eac3toConfiguration.IsExtractForRemux, eac3toConfiguration.RemuxFileNameTemplate.UsePeriodsInFileName, videoName.Trim().RemoveDoubleSpaces()), tag, extension));
            }
            return sb.ToString();
        }

        private string GetFormattedYear(EAC3ToConfiguration eac3toConfiguration)
        {
            string year = " ";
            if (eac3toConfiguration.RemuxFileNameTemplate.SeasonYear != null)
                year = string.Format(" {0} ", eac3toConfiguration.RemuxFileNameTemplate.SeasonYear);
            return year;
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

        private string GetFormattedEpisodeName(string episodeName)
        {
            string formmattedEpisodeName = string.Empty;
            if (!string.IsNullOrEmpty(episodeName))
                formmattedEpisodeName = string.Format(" {0} ", episodeName.Trim());

            return formmattedEpisodeName;
        }

        private string GetFormattedVideoResolution(EAC3ToConfiguration eac3toConfiguration)
        {
            string videoResolution = string.Empty;
            if (!string.IsNullOrEmpty(eac3toConfiguration.RemuxFileNameTemplate.VideoResolution))
                videoResolution = string.Format(" {0} ", eac3toConfiguration.RemuxFileNameTemplate.VideoResolution);
            return videoResolution;
        }

        private string GetFormattedMedium(EAC3ToConfiguration eac3toConfiguration)
        {
            string medium = string.Empty;
            if (!string.IsNullOrEmpty(eac3toConfiguration.RemuxFileNameTemplate.Medium))
                medium = string.Format(" {0} ", eac3toConfiguration.RemuxFileNameTemplate.Medium);
            return medium;
        }

        private string GetFormattedVideoFormat(EAC3ToConfiguration eac3toConfiguration)
        {
            string videoFormat = string.Empty;
            if (!string.IsNullOrEmpty(eac3toConfiguration.RemuxFileNameTemplate.VideoFormat))
                videoFormat = string.Format(" {0} ", eac3toConfiguration.RemuxFileNameTemplate.VideoFormat);
            return videoFormat;
        }

        private string GetFormattedAuditoType(EAC3ToConfiguration eac3toConfiguration)
        {
            string audioType = string.Empty;
            if (!string.IsNullOrEmpty(eac3toConfiguration.RemuxFileNameTemplate.AudioType))
                audioType = string.Format(" {0} ", eac3toConfiguration.RemuxFileNameTemplate.AudioType);
            return audioType;
        }

        private string GetFormattedTag(EAC3ToConfiguration eac3toConfiguration, string paddedEpisodeNumber, string episodeName)
        {
            string tag = string.Empty;
            if (string.IsNullOrEmpty(eac3toConfiguration.RemuxFileNameTemplate.Tag))
                return tag;

            if (string.IsNullOrEmpty(this.GetFormattedAuditoType(eac3toConfiguration).Trim()))
            {
                tag = string.Format(" -{0}", eac3toConfiguration.RemuxFileNameTemplate.Tag);
            }
            else
            {
                tag = string.Format("-{0}", eac3toConfiguration.RemuxFileNameTemplate.Tag);
            }
            return tag;
        }

        private string GetFormattedCountry(EAC3ToConfiguration eac3toConfiguration)
        {
            string country = string.Empty;
            if (!string.IsNullOrEmpty(eac3toConfiguration.RemuxFileNameTemplate.Country))
                country = string.Format(" {0} ", eac3toConfiguration.RemuxFileNameTemplate.Country);
            return country;
        }
    }
}

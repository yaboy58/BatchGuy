using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Enums;
using BatchGuy.App.Helpers;
using BatchGuy.App.Parser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Extensions;

namespace BatchGuy.App.Eac3To.Services
{
    public class EAC3ToOutputNamingService : IEAC3ToOutputNamingService
    {
        public string GetChapterName(EAC3ToConfiguration eac3toConfiguration, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux != true)
            {
                sb.Append(string.Format("\"{0}\\chapters{1}.txt\"", filesOutputPath, paddedEpisodeNumber));
            }
            else
            {
                string tag = this.GetFormattedTag(eac3toConfiguration, paddedEpisodeNumber, episodeName);
                string chapterName = string.Format("{0}\\{1}{2}S{3}E{4}{5}{6}{7}{8}{9}", filesOutputPath, eac3toConfiguration.RemuxFileNameTemplate.SeriesName, this.GetFormattedYear(eac3toConfiguration),
                    this.PadNumberWithZeros(eac3toConfiguration.NumberOfEpisodes, eac3toConfiguration.RemuxFileNameTemplate.SeasonNumber),
                    this.GetFormattedPaddedEpisodeNumber(paddedEpisodeNumber), this.GetFormattedEpisodeName(episodeName), this.GetFormattedVideoResolution(eac3toConfiguration), this.GetFormattedMedium(eac3toConfiguration), this.GetFormattedVideoFormat(eac3toConfiguration), 
                    this.GetFormattedAuditoType(eac3toConfiguration));

                sb.Append(string.Format("\"{0}{1} chapters.txt\"", chapterName.Trim(), tag));
            }
            return sb.ToString().RemoveDoubleSpaces();
        }

        public string GetVideoName(EAC3ToConfiguration eac3toConfiguration, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux != true)
            {
                sb.Append(string.Format("\"{0}\\video{1}.mkv\"", filesOutputPath, paddedEpisodeNumber));                
            }
            else
            {
                string tag = this.GetFormattedTag(eac3toConfiguration, paddedEpisodeNumber, episodeName);
                string videoName = string.Format("{0}\\{1}{2}S{3}E{4}{5}{6}{7}{8}{9}", filesOutputPath, eac3toConfiguration.RemuxFileNameTemplate.SeriesName,this.GetFormattedYear(eac3toConfiguration),
                    this.PadNumberWithZeros(eac3toConfiguration.NumberOfEpisodes, eac3toConfiguration.RemuxFileNameTemplate.SeasonNumber),
                    this.GetFormattedPaddedEpisodeNumber(paddedEpisodeNumber), this.GetFormattedEpisodeName(episodeName), this.GetFormattedVideoResolution(eac3toConfiguration), this.GetFormattedMedium(eac3toConfiguration),
                    this.GetFormattedVideoFormat(eac3toConfiguration), this.GetFormattedAuditoType(eac3toConfiguration));

                sb.Append(string.Format("\"{0}{1}.mkv\"", videoName.Trim(), tag));
            }
            return sb.ToString().RemoveDoubleSpaces();

        }

        public string GetAudioName(EAC3ToConfiguration eac3toConfiguration, Parser.Models.BluRayTitleAudio audio, string filesOutputPath, string paddedEpisodeNumber, string episodeName, int itemNumber)
        {
            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux != true)
            {
                sb.Append(string.Format("\"{0}\\{1}{2}-{3}.{4}\"", filesOutputPath, audio.Language, paddedEpisodeNumber, itemNumber.ToString(), this.GetAudioExtension(audio.AudioType)));
            }
            else
            {
                string tag = this.GetFormattedTag(eac3toConfiguration, paddedEpisodeNumber, episodeName);
                string audioName = string.Format("{0}\\{1}{2}S{3}E{4}{5}{6}{7}{8}{9}", filesOutputPath, eac3toConfiguration.RemuxFileNameTemplate.SeriesName,this.GetFormattedYear(eac3toConfiguration),
                    this.PadNumberWithZeros(eac3toConfiguration.NumberOfEpisodes, eac3toConfiguration.RemuxFileNameTemplate.SeasonNumber),
                    this.GetFormattedPaddedEpisodeNumber(paddedEpisodeNumber), this.GetFormattedEpisodeName(episodeName), this.GetFormattedVideoResolution(eac3toConfiguration), this.GetFormattedMedium(eac3toConfiguration),
                    this.GetFormattedVideoFormat(eac3toConfiguration), this.GetFormattedAuditoType(eac3toConfiguration));

                sb.Append(string.Format("\"{0}{1} {2}{3}-{4}.{5}\"", audioName.Trim(), tag, audio.Language, paddedEpisodeNumber, itemNumber.ToString(),
                    this.GetAudioExtension(audio.AudioType)));
            }
            return sb.ToString().RemoveDoubleSpaces();
        }

        public string GetSubtitleName(EAC3ToConfiguration eac3toConfiguration, BluRayTitleSubtitle subtitle, string filesOutputPath, string paddedEpisodeNumber, string episodeName, int itemNumber)
        {
            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux != true)
            {
                sb.Append(string.Format("\"{0}\\{1}{2}-{3}.sup\"", filesOutputPath, subtitle.Language, paddedEpisodeNumber, itemNumber.ToString()));
            }
            else
            {
                string tag = this.GetFormattedTag(eac3toConfiguration, paddedEpisodeNumber, episodeName);
                string subtitleName = string.Format("{0}\\{1}{2}S{3}E{4}{5}{6}{7}{8}{9}", filesOutputPath, eac3toConfiguration.RemuxFileNameTemplate.SeriesName,this.GetFormattedYear(eac3toConfiguration),
                    this.PadNumberWithZeros(eac3toConfiguration.NumberOfEpisodes, eac3toConfiguration.RemuxFileNameTemplate.SeasonNumber),
                    this.GetFormattedPaddedEpisodeNumber(paddedEpisodeNumber), this.GetFormattedEpisodeName(episodeName), this.GetFormattedVideoResolution(eac3toConfiguration), this.GetFormattedMedium(eac3toConfiguration),
                    this.GetFormattedVideoFormat(eac3toConfiguration), this.GetFormattedAuditoType(eac3toConfiguration));

                sb.Append(string.Format("\"{0}{1} {2}{3}-{4}.sup\"", subtitleName.Trim(), tag, subtitle.Language, paddedEpisodeNumber, itemNumber.ToString()));
            }
            return sb.ToString().RemoveDoubleSpaces();
        }
        public string GetLogName(EAC3ToConfiguration eac3toConfiguration, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux != true)
            {
                sb.Append(string.Format(" -log=\"{0}\\log{1}.txt\"", filesOutputPath, paddedEpisodeNumber));
            }
            else
            {
                string tag = this.GetFormattedTag(eac3toConfiguration, paddedEpisodeNumber, episodeName);
                string logName = string.Format("{0}\\{1}{2}S{3}E{4}{5}{6}{7}{8}{9}", filesOutputPath, eac3toConfiguration.RemuxFileNameTemplate.SeriesName, this.GetFormattedYear(eac3toConfiguration),
                    this.PadNumberWithZeros(eac3toConfiguration.NumberOfEpisodes, eac3toConfiguration.RemuxFileNameTemplate.SeasonNumber),
                    paddedEpisodeNumber, this.GetFormattedEpisodeName(episodeName), this.GetFormattedVideoResolution(eac3toConfiguration),this.GetFormattedMedium(eac3toConfiguration),
                    this.GetFormattedVideoFormat(eac3toConfiguration), this.GetFormattedAuditoType(eac3toConfiguration));

                sb.Append(string.Format(" -log=\"{0}{1} log.txt\"", logName.Trim(), tag));
            }
            return sb.ToString().RemoveDoubleSpaces();
        }

        private string PadNumberWithZeros(int batchCount, int number)
        {
            return HelperFunctions.PadNumberWithZeros(batchCount, number);
        }


        private string GetFormattedYear(EAC3ToConfiguration eac3toConfiguration)
        {
            string year = " ";
            if (eac3toConfiguration.RemuxFileNameTemplate.SeasonYear != null)
                year = string.Format(" {0} ", eac3toConfiguration.RemuxFileNameTemplate.SeasonYear);
            return year;
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

        private string GetAudioExtension(EnumAudioType audioType)
        {
            string audioExtension = string.Empty;

            switch (audioType)
            {
                case EnumAudioType.DTS:
                    audioExtension = "dts";
                    break;
                case EnumAudioType.AC3:
                    audioExtension = "ac3";
                    break;
                case EnumAudioType.FLAC:
                    audioExtension = "flac";
                    break;
                case EnumAudioType.TrueHD:
                    audioExtension = "thd";
                    break;
                case EnumAudioType.MPA:
                    audioExtension = "mpa";
                    break;
                case EnumAudioType.DTSMA:
                    audioExtension = "dtsma";
                    break;
                case EnumAudioType.WAVE:
                    audioExtension = "wav";
                    break;
                default:
                    throw new Exception("Invalid Audio Type");
            }
            return audioExtension;
        }
    }
}

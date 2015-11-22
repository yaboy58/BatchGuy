using BatchGuy.App.Eac3to.Interfaces;
using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Enums;
using BatchGuy.App.Helpers;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Extensions;

namespace BatchGuy.App.Eac3to.Services
{
    public class EAC3ToOutputService : IEAC3ToOutputService
    {
        private EAC3ToConfiguration _config;
        private ErrorCollection _errors = new ErrorCollection();
        private string _filesOutputPath;
        private string _paddedEpisode;
        private BluRayTitleInfo _bluRayTitleInfo;
        private string _bluRaySummaryId;

        public EAC3ToOutputService(EAC3ToConfiguration config, string bluRaySummaryId, BluRayTitleInfo bluRayTitleInfo)
        {
            _config = config;
            _bluRayTitleInfo = bluRayTitleInfo;
            _bluRaySummaryId = bluRaySummaryId;
            this.Init();
        }

        private void Init()
        {
            _paddedEpisode = HelperFunctions.PadNumberWithZeros(99, _bluRayTitleInfo.EpisodeNumber.StringToInt()); //hardcoded count
            if (_config.OutputDirectoryType == EnumDirectoryType.DirectoryPerEpisode)
            {
                string folderName = string.Format("e{0}", _paddedEpisode);
                _filesOutputPath = string.Format("{0}\\{1}", _config.EAC3ToOutputPath, folderName);                
            }
            else
            {
                _filesOutputPath = string.Format("{0}", _config.EAC3ToOutputPath);                
            }
        }

        public string GetEAC3ToPathPart()
        {
            return string.Format("\"{0}\"", _config.EAC3ToPath);
        }

        public string GetBluRayStreamPart()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("\"{0}\"", _config.BluRayPath));
            sb.Append(string.Format(" {0}", _bluRaySummaryId));
            return sb.ToString();
        }

        public string GetChapterStreamPart()
        {
            StringBuilder sb = new StringBuilder();
            if (_bluRayTitleInfo.Chapter != null)
            {
                if (_bluRayTitleInfo.Chapter.IsSelected)
                {
                    sb.Append(string.Format("{0} ", _bluRayTitleInfo.Chapter.Id));
                    sb.Append(string.Format("\"{0}\\chapters{1}.txt\"", _filesOutputPath, _paddedEpisode));
                }                
            }
            return sb.ToString();
        }

        public string GetVideoStreamPart()
        {
            StringBuilder sb = new StringBuilder();
            if (_bluRayTitleInfo.Video != null)
            {
                if (_bluRayTitleInfo.Video.IsSelected)
                {
                    sb.Append(string.Format("{0} ", _bluRayTitleInfo.Video.Id));
                    sb.Append(string.Format("\"{0}\\video{1}.mkv\"", _filesOutputPath, _paddedEpisode));
                }                            
            }
            return sb.ToString();
        }

        public string GetAudioStreamPart()
        {
            StringBuilder sb = new StringBuilder();
            int number = 1;
            foreach (BluRayTitleAudio audio in _bluRayTitleInfo.AudioList)
            {
                if (audio.IsSelected)
                {
                    sb.Append(string.Format(" {0} ", audio.Id));
                    sb.Append(string.Format("\"{0}\\{1}{2}-{3}.{4}\"", _filesOutputPath,audio.Language, _paddedEpisode,number.ToString(),this.GetAudioExtension(audio.AudioType)));
                    sb.Append(string.Format(" {0}", audio.Arguments));
                    sb.Append(" ");
                    number++;
                }
            }
            return sb.ToString();
        }

        public string GetSubtitleStreamPart()
        {
            StringBuilder sb = new StringBuilder();
            int number = 1;
            foreach (BluRayTitleSubtitle subtitle in _bluRayTitleInfo.Subtitles)
            {
                if (subtitle.IsSelected)
                {
                    sb.Append(string.Format(" {0} ", subtitle.Id));
                    sb.Append(string.Format("\"{0}\\{1}{2}-{3}.sup\"", _filesOutputPath, subtitle.Language, _paddedEpisode, number.ToString()));
                    number++;
                }
            }
            return sb.ToString();
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
                default:
                    throw new Exception("Invalid Audio Type");
            }
            return audioExtension;
        }
    }
}

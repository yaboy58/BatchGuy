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
using BatchGuy.App.Eac3To.Interfaces;

namespace BatchGuy.App.Eac3to.Services
{
    public class EAC3ToOutputService : IEAC3ToOutputService
    {
        private EAC3ToConfiguration _config;
        private ErrorCollection _errors = new ErrorCollection();
        private string _filesOutputPath;
        private string _paddedEpisodeNumber;
        private string _bluRayPath;
        private BluRaySummaryInfo _bluRaySummaryInfo;
        private IEAC3ToOutputNamingService _eac3ToOutputNamingService;

        public EAC3ToOutputService(EAC3ToConfiguration config, IEAC3ToOutputNamingService eac3ToOutputNamingService, string bluRayPath, BluRaySummaryInfo bluRaySummaryInfo)
        {
            _config = config;
            _eac3ToOutputNamingService = eac3ToOutputNamingService;
            _bluRayPath = bluRayPath;
            _bluRaySummaryInfo = bluRaySummaryInfo;
            this.Init();
        }

        private void Init()
        {
            _paddedEpisodeNumber = HelperFunctions.PadNumberWithZeros(99, _bluRaySummaryInfo.BluRayTitleInfo.EpisodeNumber.StringToInt()); //hardcoded count
            if (_config.OutputDirectoryType == EnumDirectoryType.DirectoryPerEpisode)
            {
                string folderName = string.Format("e{0}", _paddedEpisodeNumber);
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
            sb.Append(string.Format("\"{0}\"", _bluRayPath));
            sb.Append(string.Format(" {0}", _bluRaySummaryInfo.Id));
            return sb.ToString();
        }

        public string GetChapterStreamPart()
        {
            StringBuilder sb = new StringBuilder();
            if (_bluRaySummaryInfo.BluRayTitleInfo.Chapter != null)
            {
                if (_bluRaySummaryInfo.BluRayTitleInfo.Chapter.IsSelected)
                {
                    sb.Append(string.Format("{0} ",_bluRaySummaryInfo.BluRayTitleInfo.Chapter.Id));
                    sb.Append(_eac3ToOutputNamingService.GetChapterName(_config, _filesOutputPath, _paddedEpisodeNumber));
                }                
            }
            return sb.ToString();
        }

        public string GetVideoStreamPart()
        {
            StringBuilder sb = new StringBuilder();
            if (_bluRaySummaryInfo.BluRayTitleInfo.Video != null)
            {
                if (_bluRaySummaryInfo.BluRayTitleInfo.Video.IsSelected)
                {
                    sb.Append(string.Format("{0} ", _bluRaySummaryInfo.BluRayTitleInfo.Video.Id));
                    sb.Append(_eac3ToOutputNamingService.GetVideoName(_config, _filesOutputPath, _paddedEpisodeNumber));
                }                            
            }
            return sb.ToString();
        }

        public string GetAudioStreamPart()
        {
            StringBuilder sb = new StringBuilder();
            if (_bluRaySummaryInfo.BluRayTitleInfo.AudioList != null)
            {
                int number = 1;
                foreach (BluRayTitleAudio audio in _bluRaySummaryInfo.BluRayTitleInfo.AudioList)
                {
                    if (audio.IsSelected)
                    {
                        sb.Append(string.Format(" {0} ", audio.Id));
                        sb.Append(_eac3ToOutputNamingService.GetAudioName(_config,audio, _filesOutputPath, _paddedEpisodeNumber, number));
                        sb.Append(string.Format(" {0}", audio.Arguments));
                        sb.Append(" ");
                        number++;
                    }
                }                
            }
            return sb.ToString();
        }

        public string GetSubtitleStreamPart()
        {
            StringBuilder sb = new StringBuilder();
            if (_bluRaySummaryInfo.BluRayTitleInfo.Subtitles != null)
            {
                int number = 1;
                foreach (BluRayTitleSubtitle subtitle in _bluRaySummaryInfo.BluRayTitleInfo.Subtitles)
                {
                    if (subtitle.IsSelected)
                    {
                        sb.Append(string.Format(" {0} ", subtitle.Id));
                        sb.Append(_eac3ToOutputNamingService.GetSubtitleName(_config, subtitle,_filesOutputPath, _paddedEpisodeNumber, number));
                        number++;
                    }
                }                
            }
            return sb.ToString();
        }

        public string GetLogPart()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format(" -log=\"{0}\\log{1}.txt\"", _filesOutputPath, _paddedEpisodeNumber));
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

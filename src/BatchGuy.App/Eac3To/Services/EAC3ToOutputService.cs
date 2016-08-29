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
        private EAC3ToConfiguration _eac3ToConfiguration;
        private ErrorCollection _errors = new ErrorCollection();
        private string _filesOutputPath;
        private string _paddedEpisodeNumber;
        private string _bluRayPath;
        private BluRaySummaryInfo _bluRaySummaryInfo;
        private IEAC3ToOutputNamingService _eac3ToOutputNamingService;

        public EAC3ToOutputService(EAC3ToConfiguration config, IEAC3ToOutputNamingService eac3ToOutputNamingService, string bluRayPath, BluRaySummaryInfo bluRaySummaryInfo)
        {
            _eac3ToConfiguration = config;
            _eac3ToOutputNamingService = eac3ToOutputNamingService;
            _bluRayPath = bluRayPath;
            _bluRaySummaryInfo = bluRaySummaryInfo;
            this.Init();
        }

        private void Init()
        {
            _paddedEpisodeNumber = HelperFunctions.PadNumberWithZeros(_eac3ToConfiguration.NumberOfEpisodes, _bluRaySummaryInfo.BluRayTitleInfo.EpisodeNumber.StringToInt()); 
            if (_eac3ToConfiguration.OutputDirectoryType == EnumDirectoryType.DirectoryPerEpisode)
            {
                string folderName = string.Format("e{0}", _paddedEpisodeNumber);
                _filesOutputPath = string.Format("{0}\\{1}", _eac3ToConfiguration.EAC3ToOutputPath, folderName);                
            }
            else
            {
                _filesOutputPath = string.Format("{0}", _eac3ToConfiguration.EAC3ToOutputPath);                
            }
        }

        public string GetEAC3ToPathPart()
        {
            return string.Format("\"{0}\"", _eac3ToConfiguration.EAC3ToPath);
        }

        public string GetBluRayStreamPart()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("\"{0}\"", _bluRayPath));
            sb.Append(string.Format(" {0}", _bluRaySummaryInfo.Eac3ToId));
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
                    sb.Append(_eac3ToOutputNamingService.GetChapterName(_eac3ToConfiguration, _filesOutputPath, _paddedEpisodeNumber, _bluRaySummaryInfo.BluRayTitleInfo.EpisodeName));
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
                    sb.Append(_eac3ToOutputNamingService.GetVideoName(_eac3ToConfiguration, _filesOutputPath, _paddedEpisodeNumber, _bluRaySummaryInfo.BluRayTitleInfo.EpisodeName));
                }                            
            }
            return sb.ToString();
        }

        public string GetAudioStreamPart()
        {
            StringBuilder sb = new StringBuilder();
            if (_bluRaySummaryInfo.BluRayTitleInfo.AudioList != null)
            {
                foreach (BluRayTitleAudio audio in _bluRaySummaryInfo.BluRayTitleInfo.AudioList)
                {
                    if (audio.IsSelected)
                    {
                        sb.Append(string.Format(" {0} ", audio.Id));
                        sb.Append(_eac3ToOutputNamingService.GetAudioName(_eac3ToConfiguration,audio, _filesOutputPath, _paddedEpisodeNumber, _bluRaySummaryInfo.BluRayTitleInfo.EpisodeName));
                        sb.Append(string.Format(" {0}", audio.Arguments));
                        sb.Append(" ");
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
                foreach (BluRayTitleSubtitle subtitle in _bluRaySummaryInfo.BluRayTitleInfo.Subtitles)
                {
                    if (subtitle.IsSelected)
                    {
                        sb.Append(string.Format(" {0} ", subtitle.Id));
                        sb.Append(_eac3ToOutputNamingService.GetSubtitleName(_eac3ToConfiguration, subtitle,_filesOutputPath, _paddedEpisodeNumber, _bluRaySummaryInfo.BluRayTitleInfo.EpisodeName));
                    }
                }                
            }
            return sb.ToString();
        }

        public string GetLogPart()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(_eac3ToOutputNamingService.GetLogName(_eac3ToConfiguration, _filesOutputPath, _paddedEpisodeNumber, _bluRaySummaryInfo.BluRayTitleInfo.EpisodeName));
            return sb.ToString();
        }

        public string GetShowProgressNumbersPart()
        {
            StringBuilder sb = new StringBuilder();
            if (_eac3ToConfiguration.ShowProgressNumbers)
            {
                sb.Append("-progressnumbers");
            }
            return sb.ToString();
        }
    }
}

using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Eac3To.Abstracts;
using BatchGuy.App.Enums;
using BatchGuy.App.Extensions;
using BatchGuy.App.FFMSIndex.Interfaces;
using BatchGuy.App.Helpers;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Models;
using System.Text;

namespace BatchGuy.App.FFMSIndex.Services
{
    public class FFMSIndexOutputService : IFFMSIndexOutputService
    {
        private EAC3ToConfiguration _eac3ToConfiguration;
        private ErrorCollection _errors = new ErrorCollection();
        private string _filesOutputPath;
        private string _paddedEpisodeNumber;
        private string _bluRayPath;
        private BluRaySummaryInfo _bluRaySummaryInfo;
        private AbstractEAC3ToOutputNamingService _eac3ToOutputNamingService;

        public FFMSIndexOutputService(EAC3ToConfiguration config, AbstractEAC3ToOutputNamingService eac3ToOutputNamingService, string bluRayPath, BluRaySummaryInfo bluRaySummaryInfo)
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
                string folderName = string.Format("episode{0}", _paddedEpisodeNumber);
                _filesOutputPath = string.Format("{0}\\{1}", _eac3ToConfiguration.EAC3ToOutputPath, folderName);
            }
            else
            {
                _filesOutputPath = string.Format("{0}", _eac3ToConfiguration.EAC3ToOutputPath);
            }
        }

        public string GetFFMSIndexPathPart()
        {
            return string.Format("\"{0}\" -f -v", _eac3ToConfiguration.FFMSIndexPath);
        }

        public string GetVideoStreamPart()
        {
            StringBuilder sb = new StringBuilder();
            if (_bluRaySummaryInfo.BluRayTitleInfo.Video != null)
            {
                if (_bluRaySummaryInfo.BluRayTitleInfo.Video.IsSelected)
                {
                    sb.Append(_eac3ToOutputNamingService.GetVideoName(_eac3ToConfiguration, _filesOutputPath, _paddedEpisodeNumber, _bluRaySummaryInfo.BluRayTitleInfo.EpisodeName));
                }
            }
            return sb.ToString();
        }
    }
}

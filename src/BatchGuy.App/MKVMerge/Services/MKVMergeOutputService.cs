using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Enums;
using BatchGuy.App.Extensions;
using BatchGuy.App.Helpers;
using BatchGuy.App.MKVMerge.Interfaces;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.MKVMerge.Services
{
    public class MKVMergeOutputService : IMKVMergeOutputService
    {
        private EAC3ToConfiguration _eac3ToConfiguration;
        private ErrorCollection _errors = new ErrorCollection();
        private string _filesOutputPath;
        private string _paddedEpisodeNumber;
        private string _bluRayPath;
        private BluRaySummaryInfo _bluRaySummaryInfo;
        private IEAC3ToOutputNamingService _eac3ToOutputNamingService;

        public MKVMergeOutputService(EAC3ToConfiguration config, IEAC3ToOutputNamingService eac3ToOutputNamingService, string bluRayPath, BluRaySummaryInfo bluRaySummaryInfo)
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

        public string GetAudioStreamPart()
        {
            throw new NotImplementedException();
        }

        public string GetChapterStreamPart()
        {
            throw new NotImplementedException();
        }

        public string GetMKVMergePathPart()
        {
            return string.Format("\"{0}\"", _eac3ToConfiguration.MKVMergePath);
        }

        public string GetOutputPart()
        {
            throw new NotImplementedException();
        }

        public string GetSubtitleStreamPart()
        {
            throw new NotImplementedException();
        }

        public string GetTrackOrderPart()
        {
            throw new NotImplementedException();
        }

        public string GetVideoStreamPart()
        {
            throw new NotImplementedException();
        }
    }
}

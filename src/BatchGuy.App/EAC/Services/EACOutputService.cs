using BatchGuy.App.EAC.Models;
using BatchGuy.App.Helpers;
using BatchGuy.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.EAC.Services
{
    public class EACOutputService : IEACOutputService
    {
        private EAC3ToConfiguration _config;
        private EAC3ToBluRayFile _bluRayFile;
        private List<Error> _errors = new List<Error>();
        private string _filesOutputPath;
        private string _paddedEpisode;

        public EACOutputService(EAC3ToConfiguration config, EAC3ToBluRayFile bluRayFile)
        {
            _config = config;
            _bluRayFile = bluRayFile;
            this.Init();
        }

        private void Init()
        {
            _paddedEpisode = HelperFunctions.PadNumberWithZeros(99, Convert.ToInt32(_bluRayFile.BluRayEpisodeFolder));
            string folderName = string.Format("e{0}", _paddedEpisode); //convert in form
            _filesOutputPath = string.Format("{0}\\{1}", _config.BatFilePath, folderName);
        }

        public string GetEAC3ToPathPart()
        {
            return string.Format("\"{0}\"", _config.EAC3ToPath);
        }

        public string GetBluRayStreamPart()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("\"{0}\"", _config.BluRayPath));
            sb.Append(string.Format(" {0})", _bluRayFile.BluRaySteamNumber));
            return sb.ToString();
        }

        public string GetChapterStreamPart()
        {
            throw new NotImplementedException();
        }

        public string GetMovieStreamPart()
        {
            throw new NotImplementedException();
        }

        public string GetAudioStreamPart()
        {
            throw new NotImplementedException();
        }

        public string GetSubtitleStreamPart()
        {
            throw new NotImplementedException();
        }
    }
}

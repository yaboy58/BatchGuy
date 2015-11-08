using BatchGuy.App.EAC.Interfaces;
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
            StringBuilder sb = new StringBuilder();
            if (_bluRayFile.ChapterStreamNumber != string.Empty)
            {
                sb.Append(string.Format("{0}: ", _bluRayFile.ChapterStreamNumber));
                sb.Append(string.Format("\"{0}\\chapters.txt\"", _filesOutputPath));                
            }
            return sb.ToString();
        }

        public string GetMovieStreamPart()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("{0}: ", _bluRayFile.MovieStreamNumber));
            sb.Append(string.Format("\"{0}\\encode{1}.mkv\"", _filesOutputPath, _paddedEpisode));
            return sb.ToString();
        }

        public string GetAudioStreamPart()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("{0}: ", _bluRayFile.MainAudioStreamNumber));
            sb.Append(string.Format("\"{0}\\{1}{2}.{3}\"", _filesOutputPath,_config.AudioLanguage, _paddedEpisode,this.GetAudioExtension()));
            sb.Append(string.Format(" {0}", _config.AudioSettings));
            return sb.ToString();
        }

        public string GetSubtitleStreamPart()
        {
            StringBuilder sb = new StringBuilder();
            if (_bluRayFile.MainSubtitleStreamNumber != string.Empty)
            {
                sb.Append(string.Format("{0}: ", _bluRayFile.MainSubtitleStreamNumber));
                sb.Append(string.Format("\"{0}\\english{1}.sup\"", _filesOutputPath, _paddedEpisode)); //hardcoded to english/sup                
            }
            return sb.ToString();
        }

        private string GetAudioExtension()
        {
            string audioExtension = string.Empty;

            switch (_config.AudioType)
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
                    audioExtension = "ac3";
                    break;
                default:
                    throw new Exception("Invalid Audio Type");
            }
            return audioExtension;
        }
    }
}

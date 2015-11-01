using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.EAC.Models;
using BatchGuy.App.Models;
using System.IO;
using BatchGuy.App.Helpers;

namespace BatchGuy.App.EAC.Services
{
    public class BatFileWriteService : IBatFileWriteService
    {
        private EAC3ToConfiguration _config;
        private EAC3ToBluRayFile _bluRayFile;
        private IEACOutputService _eacOutputService;
        private List<Error> _errors = new List<Error>();
        private string _filesOutputPath;
        private string _paddedEpisode;

        public BatFileWriteService(EAC3ToConfiguration config, EAC3ToBluRayFile bluRayFile, IEACOutputService eacOutputService)
        {
            _config = config;
            _bluRayFile = bluRayFile;
            _eacOutputService = eacOutputService;
        }

        public List<Error> Write()
        {
            if (IsValid())
            {
                this.Init();

                string eac3ToPathPart = _eacOutputService.GetEAC3ToPathPart();
                string bluRayStreamPart = _eacOutputService.GetBluRayStreamPart();
                string chapterStreamPart = this.GetChapterStreamPart();
                string movieStreamPart = this.GetMovieStreamPart();
                string audioStreamPart = this.GetAudioStreamPart();
                string subtitleStreamPart = this.GetSubtitleStreamPart();

                using (StreamWriter sw = new StreamWriter(string.Format("{0}\\bluray.bat",_config.BatFilePath), true))
                {
                    sw.WriteLine(string.Format("{0} {1} {2} {3} {4} {5} -progressnumbers", eac3ToPathPart, bluRayStreamPart, chapterStreamPart, movieStreamPart, audioStreamPart,
                        subtitleStreamPart));
                    sw.WriteLine();
                    sw.WriteLine();
                }
            }

            return _errors;
        }

        private Boolean IsValid()
        {
            return true;
        }

        private void Init()
        {
            _paddedEpisode = HelperFunctions.PadNumberWithZeros(99, Convert.ToInt32(_bluRayFile.BluRayEpisodeFolder));
            string folderName = string.Format("e{0}", _paddedEpisode); //convert in form
            _filesOutputPath = string.Format("{0}\\{1}",_config.BatFilePath, folderName);
        }

        private string GetChapterStreamPart()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("{0}: ", _bluRayFile.ChapterStreamNumber));
            sb.Append(string.Format("\"{0}\\chapters.txt\"", _filesOutputPath));
            return sb.ToString();
        }

        private string GetMovieStreamPart()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("{0}: ", _bluRayFile.MovieStreamNumber));
            sb.Append(string.Format("\"{0}\\encode{1}.mkv\"", _filesOutputPath,_paddedEpisode));
            return sb.ToString();
        }

        private string GetAudioStreamPart()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("{0}: ", _bluRayFile.MainAudioStreamNumber));
            sb.Append(string.Format("\"{0}\\audio{1}.dts\"", _filesOutputPath, _paddedEpisode)); //hardcoded to dts
            sb.Append(" -core"); //hardcoded to dts
            return sb.ToString();
        }

        private string GetSubtitleStreamPart()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("{0}: ", _bluRayFile.MainSubtitleStreamNumber));
            sb.Append(string.Format("\"{0}\\english{1}.sup\"", _filesOutputPath, _paddedEpisode)); //hardcoded to english/sup
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.EAC.Models;
using BatchGuy.App.Models;
using System.IO;
using BatchGuy.App.Helpers;
using BatchGuy.App.EAC.Interfaces;

namespace BatchGuy.App.EAC.Services
{
    public class BatFileWriteService : IBatFileWriteService
    {
        private EAC3ToConfiguration _config;
        private EAC3ToBluRayFile _bluRayFile;
        private IEACOutputService _eacOutputService;
        private List<Error> _errors = new List<Error>();

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
                string eac3ToPathPart = _eacOutputService.GetEAC3ToPathPart();
                string bluRayStreamPart = _eacOutputService.GetBluRayStreamPart();
                string chapterStreamPart = _eacOutputService.GetChapterStreamPart();
                string movieStreamPart = _eacOutputService.GetMovieStreamPart();
                string audioStreamPart = _eacOutputService.GetAudioStreamPart();
                string subtitleStreamPart = _eacOutputService.GetSubtitleStreamPart();

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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.EAC.Models;
using BatchGuy.App.Models;
using System.IO;

namespace BatchGuy.App.EAC.Services
{
    public class BatWriteService : IBatWriteService
    {
        private EAC3ToConfiguration _config;
        private EAC3ToBluRayFile _bluRayFile;
        private List<Error> _errors = new List<Error>();

        public BatWriteService(EAC3ToConfiguration config, EAC3ToBluRayFile bluRayFile)
        {
            _config = config;
            _bluRayFile = bluRayFile;
        }

        public List<Error> Write()
        {
            if (IsValid())
            {
                string eac3ToPathPart = this.GetEAC3ToPathPart();
                string bluRaySteamPart = this.GetBluRayStreamPart();

                using (StreamWriter sw = new StreamWriter(string.Format("{0}\\bluray.bat",_config.BatFilePath), true, Encoding.UTF8))
                {
                    sw.WriteLine(string.Format("{0} {1}",eac3ToPathPart, bluRaySteamPart));
                    sw.WriteLine();
                    sw.WriteLine();
                }
            }

            return _errors;
        }

        private string GetEAC3ToPathPart()
        {
            return string.Format("\"{0}\"",_config.EAC3ToPath);
        }

        private string GetBluRayStreamPart()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("\"{0}\"", _config.BluRayPath));
            sb.Append(string.Format(" {0})",_bluRayFile.BluRaySteamNumber));
            return sb.ToString();
        }

        private Boolean IsValid()
        {
            return true;
        }

    }
}

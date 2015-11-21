using BatchGuy.App.X264.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BatchGuy.App.X264.Interfaces;

namespace BatchGuy.App.X264.Services
{
    public class X264FileService : IX264FileService
    {
        private X264FileSettings _x264FileSettings;
        private List<X264File> _files;

        public X264FileService(X264FileSettings x264FileSettings)
        {
            _x264FileSettings = x264FileSettings;
            _files = new List<X264File>();
        }

        public List<X264File> GetAVSFiles()
        {
            foreach (string avsFile in Directory.GetFiles(_x264FileSettings.AviSynthFilesPath, _x264FileSettings.AviSynthFileFilter))
            {
              FileInfo fileInfo = new FileInfo(avsFile);
              if (fileInfo.Extension == ".avs")
              {
                  X264File x264File = new X264File()
                  {
                      AviSynthFilePath = avsFile,
                      AviSynthFileNameOnly = fileInfo.Name
                  };
                  _files.Add(x264File);                  
              }
            }

            return _files;
        }
    }
}

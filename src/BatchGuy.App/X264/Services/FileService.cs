using BatchGuy.App.X264.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BatchGuy.App.X264.Services
{
    public class FileService : IFileService
    {
        private X264FileSettings _x264FileSettings;
        private List<X264File> _files;

        public FileService(X264FileSettings x264FileSettings)
        {
            _x264FileSettings = x264FileSettings;
            _files = new List<X264File>();
        }

        public List<X264File> GetAVSFiles()
        {
            foreach (string avsFile in Directory.GetFiles(_x264FileSettings.AVSPath, _x264FileSettings.AVSFileFilter))
            {
              FileInfo fileInfo = new FileInfo(avsFile);
  
                X264File x264File = new X264File()
                {
                     AVSFullPath = avsFile,
                     AVSFileNameOnly = fileInfo.Name
                };
                _files.Add(x264File);
            }

            return _files;
        }
    }
}

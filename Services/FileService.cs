using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviSynthBatchScriptCreator.Models;

namespace AviSynthBatchScriptCreator.Services
{
    public class FileService : IFileService
    {
        private AVSBatchSettings _avsBatchSettings;
        private List<AVSFile> _avsFiles;

        public FileService(AVSBatchSettings avsBatchSettings)
        {
            _avsBatchSettings = avsBatchSettings;
            _avsFiles = new List<AVSFile>();
        }

        public List<AVSFile> CreateAVSFileList()
        {
            return _avsFiles;
        }

        private void CreateList()
        {
            for (int i = 1; i <= _avsBatchSettings.NumberOfFiles; i++)
            {
            }
        }
    }
}

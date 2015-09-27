using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviSynthBatchScriptCreator.Helpers;
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
            CreateList();
            return _avsFiles;
        }

        private void CreateList()
        {
            for (int i = 1; i <= _avsBatchSettings.NumberOfFiles; i++)
            {
                string fileNameOnly = string.Format("{0}{1}.avs", _avsBatchSettings.NamingConvention, HelperFunctions.PadNumberWithZeros(_avsBatchSettings.NumberOfFiles, i));
                string directoryPath = String.Format("{0}{1}", _avsBatchSettings.BatchDirectoryPath, fileNameOnly);
                AVSFile avsFile = new AVSFile() { FileNameOnly =  fileNameOnly, FullPath = directoryPath};
                _avsFiles.Add(avsFile);
            }
        }
    }
}

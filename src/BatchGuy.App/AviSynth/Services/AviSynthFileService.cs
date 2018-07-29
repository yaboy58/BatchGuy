using System;
using System.Collections.Generic;
using System.Text;
using BatchGuy.App.Helpers;
using BatchGuy.App.AviSynth.Models;
using BatchGuy.App.AviSynth.Interfaces;
using BatchGuy.App.Enums;

namespace BatchGuy.App.AviSynth.Services
{
    public class AviSynthFileService : IAviSynthFileService
    {
        private AviSynthBatchSettings _avsBatchSettings;
        private List<AviSynthFile> _avsFiles;
        private AviSynthTemplateScript _avsTemplateScript;

        public AviSynthFileService(AviSynthBatchSettings avsBatchSettings, AviSynthTemplateScript avsTemplateScript)
        {
            _avsBatchSettings = avsBatchSettings;
            _avsTemplateScript = avsTemplateScript;
            _avsFiles = new List<AviSynthFile>();
        }

        public List<AviSynthFile> CreateAVSFileList()
        {
            CreateList();
            CreateAVSScript();
            return _avsFiles;
        }

        private void CreateList()
        {
            for (int i = 1; i <= _avsBatchSettings.NumberOfFiles; i++)
            {
                string fileNameOnly = string.Format("{0}{1}.avs", _avsBatchSettings.NamingConvention, HelperFunctions.PadNumberWithZeros(_avsBatchSettings.NumberOfFiles, i));
                string directoryPath = String.Format("{0}\\{1}", _avsBatchSettings.AviSynthFilesOutputDirectoryPath, fileNameOnly);
                AviSynthFile avsFile = new AviSynthFile() { FileNameOnly =  fileNameOnly, FullPath = directoryPath};
                avsFile.Number = i;
                _avsFiles.Add(avsFile);
            }
        }

        private void CreateAVSScript()
        {
            foreach (AviSynthFile file in _avsFiles)
            {
                StringBuilder sb = new StringBuilder();
                string paddedNumber = HelperFunctions.PadNumberWithZeros(_avsBatchSettings.NumberOfFiles, file.Number);
                string encodeFileFolder = string.Format("episode{0}", paddedNumber);
                string encodeFile = string.Format("video{0}.mkv", paddedNumber); //hardcoded to mkv
                if (_avsBatchSettings.VideoToEncodeDirectoryType ==  EnumDirectoryType.DirectoryPerEpisode)
                {
                    sb.Append(string.Format("{0}(\"{1}\\{2}\\{3}\")", _avsBatchSettings.VideoFilter, _avsBatchSettings.VideoToEncodeDirectory, encodeFileFolder, encodeFile));                    
                }
                else
                {
                    sb.Append(string.Format("{0}(\"{1}\\{2}\")", _avsBatchSettings.VideoFilter, _avsBatchSettings.VideoToEncodeDirectory, encodeFile));                    
                }
                sb.Append(string.Format("{0}{1}",Environment.NewLine,_avsTemplateScript.Script));
                file.AviSynthScript = sb.ToString();
            }
        }
    }
}

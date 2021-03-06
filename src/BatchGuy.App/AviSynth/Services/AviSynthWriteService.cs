﻿using System.Collections.Generic;
using System.IO;
using BatchGuy.App.AviSynth.Models;
using BatchGuy.App.AviSynth.Interfaces;
using BatchGuy.App.Shared.Models;

namespace BatchGuy.App.AviSynth.Services
{
    public class AviSynthWriteService : IAviSynthWriteService
    {
        private ErrorCollection _errors;
        private IAviSynthFileService _fileService;
        private IAviSynthValidationService _validationService;
        private List<AviSynthFile> _avsFiles;
        private AviSynthTemplateScript _avsScript;
        private AviSynthBatchSettings _avsBatchSettings;

        public AviSynthWriteService(IAviSynthFileService fileService, IAviSynthValidationService validationService, AviSynthTemplateScript avsScript, AviSynthBatchSettings avsBatchSettings)
        {
            _fileService = fileService;
            _validationService = validationService;
            _avsScript = avsScript;
            _avsBatchSettings = avsBatchSettings;
        }

        public ErrorCollection CreateAVSFiles()
        {
            _errors = _validationService.Validate();
            if (_errors.Count == 0)
            {
                _avsFiles = _fileService.CreateAVSFileList();
                this.Delete();
                this.WriteAVSStreams();
            }

            return _errors;
        }

        private void WriteAVSStreams()
        {
            foreach (var file in _avsFiles)
            {
                using (StreamWriter sw = new StreamWriter(file.FullPath))
                {
                    sw.WriteLine(file.AviSynthScript);
                }
            }
        }

        public void Delete()
        {
            if (_avsFiles != null)
            {
                foreach (var file in _avsFiles)
                {
                    if (File.Exists(file.FullPath))
                        File.Delete(file.FullPath);
                }
            }
        }
    }
}

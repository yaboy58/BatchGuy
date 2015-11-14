using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.AviSynth;
using System.IO;
using BatchGuy.App.AviSynth.Models;
using BatchGuy.App.AviSynth.Interfaces;
using BatchGuy.App.Shared.Models;

namespace BatchGuy.App.AviSynth.Services
{
    public class AVSService : IAVSService
    {
        private ErrorCollection _errors;
        private IFileService _fileService;
        private IValidationService _validationService;
        private List<AVSFile> _avsFiles;
        private AVSTemplateScript _avsScript;
        private AVSBatchSettings _avsBatchSettings;

        public AVSService(IFileService fileService, IValidationService validationService, AVSTemplateScript avsScript, AVSBatchSettings avsBatchSettings)
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
                WriteAVSStreams();
            }

            return _errors;
        }

        private void WriteAVSStreams()
        {
            foreach (var file in _avsFiles)
            {
                using (StreamWriter sw = new StreamWriter(file.FullPath))
                {
                    sw.WriteLine(file.AVSScript);
                }
            }
        }
    }
}

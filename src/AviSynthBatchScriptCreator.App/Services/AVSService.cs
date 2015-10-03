using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviSynthBatchScriptCreator.App.Models;
using System.IO;

namespace AviSynthBatchScriptCreator.App.Services
{
    public class AVSService : IAVSService
    {
        private List<Error> _errors;
        private IFileService _fileService;
        private IValidationService _validationService;
        private List<AVSFile> _avsFiles;
        private AVSScript _avsScript;

        public AVSService(IFileService fileService, IValidationService validationService, AVSScript avsScript)
        {
            _fileService = fileService;
            _validationService = validationService;
            _avsScript = avsScript;
        }

        public List<Error> CreateAVSFiles()
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
                    sw.WriteLine(_avsScript);
                }
            }
        }
    }
}

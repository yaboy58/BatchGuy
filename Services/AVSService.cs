using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviSynthBatchScriptCreator.Models;

namespace AviSynthBatchScriptCreator.Services
{
    public class AVSService : IAVSService
    {
        private List<Error> _errors;
        private IFileService _fileService;
        private IValidationService _validationService;
        private List<AVSFile> _avsFiles;

        public AVSService(IFileService fileService, IValidationService validationService)
        {
            _fileService = fileService;
            _validationService = validationService;
        }

        public List<Error> CreateAVSFiles()
        {
            _errors = _validationService.Validate();
            if (_errors.Count == 0)
            {
                _avsFiles = _fileService.CreateAVSFileList();
            }

            return _errors;
        }
    }
}

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
    public class AviSynthValidationService : IAviSynthValidationService
    {
        private AviSynthBatchSettings _avsBatchSettings;
        private ErrorCollection _errors;

        public AviSynthValidationService(AviSynthBatchSettings avsBatchSettings)
        {
            _avsBatchSettings = avsBatchSettings;
            _errors = new ErrorCollection();
        }

        public ErrorCollection Validate()
        {
            this.BatchDirectoryIsNotEmpty();
            this.BatchDirectoryIsValid();
            this.NamingConventionIsNotEmpty();
            return _errors;
        }

        private void BatchDirectoryIsNotEmpty() 
        {
            if (_avsBatchSettings.AviSynthFilesOutputDirectoryPath == string.Empty)
            {
                _errors.Add(new Error() { Id = 0, Description = "Batch Directory is required!"});
            }
        }

        private void BatchDirectoryIsValid()
        {
            if (!Directory.Exists(_avsBatchSettings.AviSynthFilesOutputDirectoryPath))
            {
                _errors.Add(new Error() { Id = 0, Description = "Batch Directory does not exist!" });                
            }
        }

        private void NamingConventionIsNotEmpty()
        {
            if (_avsBatchSettings.NamingConvention == string.Empty)
            {
                _errors.Add(new Error() { Id = 0, Description = "Naming Convention is required" });
            }
        }
    }
}

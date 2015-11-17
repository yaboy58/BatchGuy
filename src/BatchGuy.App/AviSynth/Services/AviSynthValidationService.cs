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
        private AVSBatchSettings _avsBatchSettings;
        private ErrorCollection _errors;

        public AviSynthValidationService(AVSBatchSettings avsBatchSettings)
        {
            _avsBatchSettings = avsBatchSettings;
            _errors = new ErrorCollection();
        }

        public ErrorCollection Validate()
        {
            BatchDirectoryIsNotEmpty();
            BatchDirectoryIsValid();
            NamingConventionIsNotEmpty();
            return _errors;
        }

        private void BatchDirectoryIsNotEmpty() 
        {
            if (_avsBatchSettings.BatchDirectoryPath == string.Empty)
            {
                _errors.Add(new Error() { Id = 0, Description = "Batch Directory is required!"});
            }
        }

        private void BatchDirectoryIsValid()
        {
            if (!Directory.Exists(_avsBatchSettings.BatchDirectoryPath))
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

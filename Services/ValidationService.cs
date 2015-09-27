using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviSynthBatchScriptCreator.Models;

namespace AviSynthBatchScriptCreator.Services
{
    public class ValidationService : IValidationService
    {
        private AVSBatchSettings _avsBatchSettings;
        private List<Error> _errors;

        public ValidationService(AVSBatchSettings avsBatchSettings)
        {
            _avsBatchSettings = avsBatchSettings;
            _errors = new List<Error>();
        }

        public List<Error> Validate()
        {
            BatchDirectoryIsNotEmpty();
            return _errors;
        }

        private void BatchDirectoryIsNotEmpty() 
        {
            if (_avsBatchSettings.BatchDirectory == string.Empty)
            {
                _errors.Add(new Error() { Id = 0, Description = "Batch Directory is required!"});
            }
        }
    }
}

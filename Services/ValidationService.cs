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

        public ValidationService(AVSBatchSettings avsBatchSettings)
        {
            _avsBatchSettings = avsBatchSettings;
        }

        public List<Error> Validate()
        {
            throw new NotImplementedException();
        }
    }
}

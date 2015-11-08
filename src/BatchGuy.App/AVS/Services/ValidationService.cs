using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.AVS;
using System.IO;
using BatchGuy.App.AVS.Models;
using BatchGuy.App.Models;
using BatchGuy.App.AVS.Interfaces;

namespace BatchGuy.App.AVS.Services
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

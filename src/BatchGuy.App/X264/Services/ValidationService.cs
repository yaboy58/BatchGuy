using BatchGuy.App.Models;
using BatchGuy.App.X264.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BatchGuy.App.X264.Services
{
    public class ValidationService : IValidationService
    {
        private X264FileSettings _x264FileSettings;
        private List<Error> _errors;

        public ValidationService(X264FileSettings x264FileSettings)
        {
            _x264FileSettings = x264FileSettings;
            _errors = new List<Error>();
        }
        public List<Error> Validate()
        {
            return _errors;
        }

        private void ValidateAVSDirectory()
        {
            if (!Directory.Exists(_x264FileSettings.AVSPath))
            {
                this._errors.Add(new Error() { Description = "The AVS Folder does not exist" });
            }
        }
    }
}

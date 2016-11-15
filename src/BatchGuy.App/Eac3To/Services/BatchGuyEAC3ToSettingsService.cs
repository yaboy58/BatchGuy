using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Eac3To.Models;
using BatchGuy.App.Shared.Interface;
using BatchGuy.App.Shared.Models;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Eac3To.Services
{
    public class BatchGuyEAC3ToSettingsService : IBatchGuyEAC3ToSettingsService
    {
        private ErrorCollection _errors;
        private IJsonSerializationService<BatchGuyEAC3ToSettings> _jsonSerializationService;

        public ErrorCollection Errors
        {
            get { return _errors; }
        }

        public static readonly ILog _log = LogManager.GetLogger(typeof(BatchGuyEAC3ToSettingsService));

        public BatchGuyEAC3ToSettingsService(IJsonSerializationService<BatchGuyEAC3ToSettings> jsonSerializationService)
        {
            _jsonSerializationService = jsonSerializationService;
            _errors = new ErrorCollection();
        }

        public void Save(string settingsFile, BatchGuyEAC3ToSettings batchGuyEAC3ToSettings)
        {
            try
            {
                _jsonSerializationService.WriteToJsonFile(settingsFile, batchGuyEAC3ToSettings, false);
            }
            catch (Exception ex)
            {
                _log.ErrorFormat(Program.GetLogErrorFormat(), ex.Message, ex.StackTrace, MethodBase.GetCurrentMethod().Name);
                _errors.Add(new Error() { Description = "There was a problem saving the BatchGuy eac3to Settings File" });
            }
        }

        public BatchGuyEAC3ToSettings GetBatchGuyEAC3ToSettings(string settingsFile)
        {
            BatchGuyEAC3ToSettings batchGuyEAC3ToSettings = null;
            try
            {
                batchGuyEAC3ToSettings = _jsonSerializationService.ReadFromJsonFile<BatchGuyEAC3ToSettings>(settingsFile);
            }
            catch (Exception ex)
            {
                _log.ErrorFormat(Program.GetLogErrorFormat(), ex.Message, ex.StackTrace, MethodBase.GetCurrentMethod().Name);
                _errors.Add(new Error() { Description = "There was a problem loading the BatchGuy eac3to Settings File" });
            }
            return batchGuyEAC3ToSettings;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Settings.Interface;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.Settings.Models;
using System.IO;

namespace BatchGuy.App.Settings.Services
{
    public class ApplicationSettingsService : IApplicationSettingsService
    {
        private ErrorCollection _errors;
        private IBinarySerializationService<ApplicationSettings> _binarySerializationService;
        private ApplicationSettings _applicationSettings;
        private string _applicationDirectory;


        public ErrorCollection Errors
        {
            get { return _errors; }
        }

        public ApplicationSettings ApplicationSettings
        {
            get { return _applicationSettings; }
        }

        public ApplicationSettingsService(IBinarySerializationService<ApplicationSettings> binarySerializationService)
        {
            _errors = new ErrorCollection();
            _binarySerializationService = binarySerializationService;
            Uri uri = new Uri(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase));
            _applicationDirectory =  uri.LocalPath;
            _applicationSettings = new ApplicationSettings() { ApplicationDirectory = _applicationDirectory };
            if (File.Exists(_applicationSettings.SettingsFile))
            {
                this.LoadSettingsFromConfigFile();
            }
        }

        public ApplicationSettings Get()
        {
            return _applicationSettings;
        }

        public void Save(ApplicationSettings applicationSettings)
        {
            try
            {
                _errors.Clear();
                _binarySerializationService.WriteToBinaryFile(applicationSettings.SettingsFile, applicationSettings, false);
                _applicationSettings = applicationSettings;
            }
            catch (Exception ex)
            {
                _errors.Add(new Error() {Description = ex.Message});
            }
        }

        private void LoadSettingsFromConfigFile()
        {
            try
            {
                _errors.Clear();
                _applicationSettings = _binarySerializationService.ReadFromBinaryFile<ApplicationSettings>(_applicationSettings.SettingsFile);
            }
            catch (Exception ex)
            {
                _errors.Add(new Error() { Description = ex.Message });
            }
        }

    }
}

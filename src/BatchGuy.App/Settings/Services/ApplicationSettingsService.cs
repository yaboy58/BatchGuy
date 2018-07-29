using System;
using System.Linq;
using BatchGuy.App.Shared.Interface;
using BatchGuy.App.Shared.Models;
using System.IO;
using log4net;
using BatchGuy.App.Settings.Interface;
using System.Reflection;
using BatchGuy.App.Shared.Interfaces;

namespace BatchGuy.App.Settings.Services
{
    public class ApplicationSettingsService : IApplicationSettingsService
    {
        private ErrorCollection _errors;
        private IJsonSerializationService<ApplicationSettings> _jsonSerializationService;
        private ApplicationSettings _applicationSettings;
        private string _applicationDirectory;
        private IAudioService _audioService;


        public ErrorCollection Errors
        {
            get { return _errors; }
        }

        public static readonly ILog _log = LogManager.GetLogger(typeof(ApplicationSettingsService));

        public ApplicationSettingsService(IJsonSerializationService<ApplicationSettings> jsonSerializationService, IAudioService audioService)
        {
            _errors = new ErrorCollection();
            _jsonSerializationService = jsonSerializationService;
            _audioService = audioService;
            Uri uri = new Uri(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase));
            _applicationDirectory =  uri.LocalPath;
            _applicationSettings = new ApplicationSettings() { ApplicationDirectory = _applicationDirectory };

            if (File.Exists(_applicationSettings.SettingsFile))
            {
                this.LoadSettingsFromConfigFile();
            }

            new SettingsDefaultSeedDataService(_applicationSettings, _audioService).Create();
        }

        public ApplicationSettings GetApplicationSettings()
        {
            return _applicationSettings;
        }

        public void Save(ApplicationSettings applicationSettings)
        {
            try
            {
                _errors.Clear();
                _jsonSerializationService.WriteToJsonFile(applicationSettings.SettingsFile, applicationSettings, false);
                _applicationSettings = applicationSettings;
            }
            catch (Exception ex)
            {
                _log.ErrorFormat(Program.GetLogErrorFormat(), ex.Message, ex.StackTrace, MethodBase.GetCurrentMethod().Name);
                _errors.Add(new Error() {Description = "There was a problem saving the Application Settings File"});
            }
        }

        private void LoadSettingsFromConfigFile()
        {
            try
            {
                _errors.Clear();
                _applicationSettings = _jsonSerializationService.ReadFromJsonFile<ApplicationSettings>(_applicationSettings.SettingsFile);
            }
            catch (Exception ex)
            {
                _log.ErrorFormat(Program.GetLogErrorFormat(), ex.Message, ex.StackTrace, MethodBase.GetCurrentMethod().Name);
                _errors.Add(new Error() { Description = "There was a problem loading the Application Settings File" });
            }
        }

        public Setting GetSettingByName(string settingName)
        {
            return _applicationSettings.Settings.SingleOrDefault(s => s.Name == settingName);
        }
    }
}

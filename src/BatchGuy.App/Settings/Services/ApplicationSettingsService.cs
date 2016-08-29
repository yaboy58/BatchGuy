using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Shared.Interface;
using BatchGuy.App.Shared.Models;
using System.IO;
using log4net;
using BatchGuy.App.Settings.Interface;
using System.Reflection;
using BatchGuy.App.Enums;
using BatchGuy.App.Settings.Models;
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
            else
            {
                this.LoadBluRayTitleInfoDefaultSettings();
                this.LoadEAC3ToDefaultSettings();
            }
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
                _log.ErrorFormat(Program.GetLogErrorFormat(), ex.Message, MethodBase.GetCurrentMethod().Name);
                _errors.Add(new Error() {Description = "There was a problem saving the Application Settings File"});
            }
        }

        private void LoadSettingsFromConfigFile()
        {
            try
            {
                _errors.Clear();
                _applicationSettings = _jsonSerializationService.ReadFromJsonFile<ApplicationSettings>(_applicationSettings.SettingsFile);
                this.LoadBluRayTitleInfoDefaultSettings();
                this.LoadEAC3ToDefaultSettings();
            }
            catch (Exception ex)
            {
                _log.ErrorFormat(Program.GetLogErrorFormat(), ex.Message, MethodBase.GetCurrentMethod().Name);
                _errors.Add(new Error() { Description = "There was a problem loading the Application Settings File" });
            }
        }

        private void LoadBluRayTitleInfoDefaultSettings()
        {
            if (_applicationSettings.BluRayTitleInfoDefaultSettings == null)
            {
                ResetBluRayTitleInfoDefaultSettings();
            }
        }

        public  void LoadEAC3ToDefaultSettings()
        {
            if (_applicationSettings.EAC3ToDefaultSettings == null)
            {
                this.ResetEAC3ToDefaultSettings();
            }
        }

        public Setting GetSettingByName(string settingName)
        {
            return _applicationSettings.Settings.SingleOrDefault(s => s.Name == settingName);
        }

        public void ResetEAC3ToDefaultSettings()
        {
            _applicationSettings.EAC3ToDefaultSettings = new EAC3ToDefaultSettings() { ShowProgressNumbers = true };
        }


        public void ResetBluRayTitleInfoDefaultSettings()
        {
            _applicationSettings.BluRayTitleInfoDefaultSettings = new BluRayTitleInfoDefaultSettings() { Enabled = true, SelectChapters = true, SelectSubtitles = true };

            var bluRayAudioTypes = _audioService.GetBluRayAudioTypes();

            foreach (EnumAudioType type in bluRayAudioTypes)
            {
                BluRayTitleInfoDefaultSettingsAudio audio = new BluRayTitleInfoDefaultSettingsAudio() { Arguments = "", DefaultType = type.ToString(), Type = type, Name = type.ToString() };
                if (type == EnumAudioType.DTSMA)
                {
                    audio.DefaultType = EnumAudioType.DTS.ToString();
                    audio.Arguments = "-core";
                }
                else if (type == EnumAudioType.LPCM)
                {
                    audio.DefaultType = EnumAudioType.FLAC.ToString();
                }
                else if (type == EnumAudioType.TrueHD)
                {
                    audio.DefaultType = EnumAudioType.AC3.ToString();
                    audio.Arguments = "-640";
                }
                _applicationSettings.BluRayTitleInfoDefaultSettings.Audio.Add(audio);
            }
        }
    }
}

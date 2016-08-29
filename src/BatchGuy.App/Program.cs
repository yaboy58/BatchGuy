using BatchGuy.App.Bootstrap;
using BatchGuy.App.Shared.Interface;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.Shared.Services;
using BatchGuy.App.Shared.Events;
using BatchGuy.App.Shared.Interface;
using BatchGuy.App.Shared.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatchGuy.App.Settings.Interface;
using BatchGuy.App.Settings.Services;
using BatchGuy.App.Shared.Interfaces;

namespace BatchGuy
{
    static class Program
    {
        private static IJsonSerializationService<ApplicationSettings> _jsonSerializationService;
        private static IApplicationSettingsService _applicationSettingsService;
        private static IAudioService _audioService;

        public static IApplicationSettingsService ApplicationSettingsService { get { return Program._applicationSettingsService; } }
        public static ApplicationSettings ApplicationSettings { get { return Program._applicationSettingsService.GetApplicationSettings(); } }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Logging.Register();
            Program.LoadApplicationSettings();
            Application.Run(new MainForm());
        }

        public static void LoadApplicationSettings()
        {
            Program._jsonSerializationService = new JsonSerializationService<ApplicationSettings>();
            Program._audioService = new AudioService();
            Program._applicationSettingsService = new ApplicationSettingsService(_jsonSerializationService, _audioService);
        }

        public static string GetLogErrorFormat()
        {
            return "Error: {0}.  Method: {1}.";
        }

        public static void DialogInitialDirectoryChangedHandler(object sender, DialogInitialDirectoryChangedEventArgs e)
        {
            Setting setting = Program.ApplicationSettingsService.GetSettingByName(e.FeatureName);

            if (setting != null)
            {
                if (setting.Value != e.DirectoryPath)
                {
                    setting.Value = e.DirectoryPath;
                    Program.ApplicationSettingsService.Save(Program.ApplicationSettings);
                }
            }
            else
            {
                Program.ApplicationSettings.Settings.Add(new Setting() { Name = e.FeatureName, Value = e.DirectoryPath });
                Program.ApplicationSettingsService.Save(Program.ApplicationSettings);
            }
        }
    }
}

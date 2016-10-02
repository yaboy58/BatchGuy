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
using BatchGuy.App;
using log4net;
using System.Reflection;

namespace BatchGuy
{
    static class Program
    {
        private static IJsonSerializationService<ApplicationSettings> _jsonSerializationService;
        private static IApplicationSettingsService _applicationSettingsService;
        private static IAudioService _audioService;
        private static IBatchGuyNotificationService _batchGuyNotificationService;
        private static ILoggingService _loggingService;
        public static readonly ILog _log = LogManager.GetLogger(typeof(Program));

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
            Program.LoadLoggingService();
            Program.LoadApplicationSettings();
            Program.LoadNotificationService();
            Application.Run(new MainForm());
        }

        private static void LoadLoggingService()
        {
            _loggingService = new LoggingService(Program.GetLogErrorFormat());
        }

        private static void LoadApplicationSettings()
        {
            try
            {
                Program._jsonSerializationService = new JsonSerializationService<ApplicationSettings>();
                Program._audioService = new AudioService();
                Program._applicationSettingsService = new ApplicationSettingsService(_jsonSerializationService, _audioService);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error trying to load the application", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _loggingService.LogErrorFormat(ex, MethodBase.GetCurrentMethod().Name);
            }
        }

        private static void LoadNotificationService()
        {
            try
            {
                _batchGuyNotificationService = new BatchGuyNotificationService();
                _batchGuyNotificationService.CheckForNewVersion();
            }
            catch (Exception ex)
            {
                _loggingService.LogErrorFormat(ex, MethodBase.GetCurrentMethod().Name);
            }
        }

        public static string GetLogErrorFormat()
        {
            return "Error: {0}.  Stacktrace: {1}. Method: {2}.";
        }

        public static void DialogInitialDirectoryChangedHandler(object sender, DialogInitialDirectoryChangedEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("There was an error trying to set the initial directory", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _loggingService.LogErrorFormat(ex, MethodBase.GetCurrentMethod().Name);
            }
        }

        public static string GetApplicationVersion()
        {
           return string.Format("Version: {0}.{1}.{2}", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major.ToString(), System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString(), System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Build.ToString());
        }
    }
}

using BatchGuy.App.Settings.Interface;
using BatchGuy.App.Settings.Models;
using BatchGuy.App.Settings.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchGuy
{
    static class Program
    {
        private static IBinarySerializationService<ApplicationSettings> _binarySerializationService;
        private static IApplicationSettingsService _applicationSettingsService;

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
            Program.LoadApplicationSettings();
            Application.Run(new MainForm());
        }

        public static void LoadApplicationSettings()
        {
            Program._binarySerializationService = new BinarySerializationService<ApplicationSettings>();
            Program._applicationSettingsService = new ApplicationSettingsService(_binarySerializationService);
        }
    }
}

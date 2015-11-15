using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Settings.Models
{
    [Serializable]
    public class ApplicationSettings
    {
        public string ApplicationDirectory { get; set; }
        public List<Setting> Settings { get; set; }

        public string SettingsFile { get { return string.Format("{0}\\config.batchGuySettings", this.ApplicationDirectory); } }

        public ApplicationSettings()
        {
            Settings = new List<Setting>();
        }
    }
}

using BatchGuy.App.Settings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Shared.Models
{
    [Serializable]
    public class ApplicationSettings
    {
        public string ApplicationDirectory { get; set; }
        public List<Setting> Settings { get; set; }

        public string SettingsFile { get { return string.Format("{0}\\config.batchGuySettings", this.ApplicationDirectory); } }

        public BluRayTitleInfoDefaultSettings BluRayTitleInfoDefaultSettings { get; set; }

        public ApplicationSettings()
        {
            Settings = new List<Setting>();
        }
    }
}

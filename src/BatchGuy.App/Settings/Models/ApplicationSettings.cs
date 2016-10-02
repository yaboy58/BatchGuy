using BatchGuy.App.Enums;
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

        public EAC3ToDefaultSettings EAC3ToDefaultSettings { get; set; }

        public SubtitlesMKVMergeDefaultSettings SubtitlesMKVMergeDefaultSettings { get; set; }

        public bool SubtitleLanguageAlwaysSelectedEnabled { get; set; }

        public bool AudioLanguageAlwaysSelectedEnabled { get; set; }

        public AudioMKVMergeDefaultSettings AudioMKVMergeDefaultSettings { get; set; }

        public EnumEAC3ToNamingConventionType EnumEAC3ToNamingConventionType { get; set; }

        public bool CheckForNewBatchGuyVersions { get; set; }

        public ApplicationSettings()
        {
            Settings = new List<Setting>();
            EnumEAC3ToNamingConventionType = EnumEAC3ToNamingConventionType.RemuxNamingConventionTemplate1;
        }
    }
}

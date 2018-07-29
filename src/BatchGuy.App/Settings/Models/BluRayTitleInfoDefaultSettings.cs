using System;
using System.Collections.Generic;

namespace BatchGuy.App.Settings.Models
{
    [Serializable]
    public class BluRayTitleInfoDefaultSettings
    {
        public BluRayTitleInfoDefaultSettings()
        {
            this.Audio = new List<BluRayTitleInfoDefaultSettingsAudio>();
        }
        public bool Enabled { get; set; }

        public bool SelectChapters { get; set; }

        public bool SelectAllSubtitles { get; set; }

        public List<BluRayTitleInfoDefaultSettingsAudio>  Audio { get; set; }
    }
}

using System;
using BatchGuy.App.Enums;

namespace BatchGuy.App.Settings.Models
{
    [Serializable]
    public class BluRayTitleInfoDefaultSettingsAudio
    {
        public EnumAudioType Type { get; set; }

        public string Name { get; set; }

        public string Arguments { get; set; }

        public string DefaultType { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

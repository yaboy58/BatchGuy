using BatchGuy.App.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.EAC.Models
{
    public class EAC3ToConfiguration
    {
        public string EAC3ToPath { get; set; }
        public string BluRayPath { get; set; }
        public string BatFilePath { get; set; }
        public EnumAudioType AudioType { get; set; }
        public string AudioSettings { get; set; }
        public string AudioLanguage { get; set; }
    }
}

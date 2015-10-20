using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.EAC.Models
{
    public class EAC3ToBluRayFile
    {
        public string BluRayOutputFolder { get; set; }
        public string BluRaySteamNumber { get; set; }
        public string MovieStreamNumber { get; set; }
        public string MainAudioStreamNumber { get; set; }
        public string MainSubtitleStreamNumber { get; set; }
    }
}

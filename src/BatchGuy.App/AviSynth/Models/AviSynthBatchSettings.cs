using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Enums;

namespace BatchGuy.App.AviSynth.Models
{
    public class AviSynthBatchSettings
    {
        public string AviSynthFilesOutputDirectoryPath { get; set; }
        public string NamingConvention { get; set; }
        public int NumberOfFiles { get; set; }
        public string VideoFilter { get; set; }
        public EnumDirectoryType VideoToEncodeDirectoryType { get; set; }

        public string  VideoToEncodeDirectory { get; set; }
    }
}

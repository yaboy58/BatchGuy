using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.AviSynth.Models
{
    public class AviSynthBatchSettings
    {
        public string BatchDirectoryPath { get; set; }
        public string NamingConvention { get; set; }
        public int NumberOfFiles { get; set; }
        public string VideoFilter { get; set; }


    }
}

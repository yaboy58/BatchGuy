using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviSynthBatchScriptCreator.Models
{
    public class AVSBatchSettings
    {
        public string BatchDirectory { get; set; }
        public string NamingConvention { get; set; }
        public int NumberOfFiles { get; set; }
    }
}

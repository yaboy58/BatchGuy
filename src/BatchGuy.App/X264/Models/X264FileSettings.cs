using BatchGuy.App.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.X264.Models
{
    public class X264FileSettings
    {
        public string vfw4x264Exe { get; set; }
        public EnumEncodeType EncodeType { get; set; }
        public string X264Template { get; set; }
        public string X264BatchFileOutputPath { get; set; }
        public string X264EncodeAndLogFileOutputDirectoryPath { get; set; }
        public EnumDirectoryType X264EncodeAndLogFileOutputDirectoryPathType { get; set; }
    }
}

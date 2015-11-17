using BatchGuy.App.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Eac3to.Models
{
    public class EAC3ToConfiguration
    {
        public string EAC3ToPath { get; set; }
        public string BluRayPath { get; set; }
        public string BatchFilePath { get; set; }
        public string EAC3ToOutputPath { get; set; }

        public EnumOutputDirectoryType OutputDirectoryType { get; set; }
    }
}

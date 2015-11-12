using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.AviSynth.Models
{
    public class AVSFile
    {
        public string FileNameOnly { get; set; }
        public string FullPath { get; set; }
        public string AVSScript { get; set; }
        public int Number { get; set; }
    }
}

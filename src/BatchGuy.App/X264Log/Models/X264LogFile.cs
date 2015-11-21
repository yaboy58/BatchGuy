using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.X264Log.Models
{
    public class X264LogFile
    {
        public string FileNameOnly { get; set; }
        public string  FilePath { get; set; }
        public string  IFrameText { get; set; }
        public string PFrameText { get; set; }
        public string BFrameText { get; set; }
        public string ConsecutiveBFramesText { get; set; }
        public string EncodedFramesText { get; set; }
    }
}

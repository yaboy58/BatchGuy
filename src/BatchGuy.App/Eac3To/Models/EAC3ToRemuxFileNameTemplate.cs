using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Eac3To.Models
{
    public class EAC3ToRemuxFileNameTemplate
    {
        public string SeriesName  { get; set; }
        public int SeasonNumber { get; set; }
        public int? SeasonYear { get; set; }
        public string VideoResolution { get; set; }
        public string AudioType { get; set; }
        public string Tag { get; set; }
    }
}

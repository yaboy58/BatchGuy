using BatchGuy.App.Eac3to.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Parser.Models;

namespace BatchGuy.App.Eac3To.Models
{
    public class BatchGuyEAC3ToSettings
    {
        public EAC3ToConfiguration Settings { get; set; }
        public List<BluRayDiscInfo> BluRayDiscs { get; set; }
    }
}

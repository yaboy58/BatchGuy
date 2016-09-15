using BatchGuy.App.Eac3to.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.X264.Models;

namespace BatchGuy.App.Eac3To.Models
{
    public class BatchGuyEAC3ToSettings
    {
        public EAC3ToConfiguration EAC3ToSettings { get; set; }
        public List<BluRayDiscInfo> BluRayDiscs { get; set; }
        public X264FileSettings X264FileSettings { get; set; }
        public List<X264File> X264Files { get; set; }
    }
}

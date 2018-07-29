using BatchGuy.App.Eac3to.Models;
using System.Collections.Generic;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.X264.Models;
using BatchGuy.App.AviSynth.Models;

namespace BatchGuy.App.Eac3To.Models
{
    public class BatchGuyEAC3ToSettings
    {
        public EAC3ToConfiguration EAC3ToSettings { get; set; }
        public List<BluRayDiscInfo> BluRayDiscs { get; set; }
        public X264FileSettings X264FileSettings { get; set; }
        public List<X264File> X264Files { get; set; }
        public AviSynthTemplateScript AVSScript { get; set; }
        public AviSynthBatchSettings AVSBatchSettings { get; set; }
    }
}

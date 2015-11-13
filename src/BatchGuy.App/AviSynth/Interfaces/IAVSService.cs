using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.AviSynth;
using BatchGuy.App.AviSynth.Models;
using BatchGuy.App.Shared.Models;

namespace BatchGuy.App.AviSynth.Interfaces
{
    public interface IAVSService
    {
       ErrorCollection CreateAVSFiles();
    }
}

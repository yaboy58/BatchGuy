using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.AviSynth;
using BatchGuy.App.AviSynth.Models;

namespace BatchGuy.App.AviSynth.Interfaces
{
    public interface IAviSynthFileService
    {
        List<AVSFile> CreateAVSFileList();
    }
}

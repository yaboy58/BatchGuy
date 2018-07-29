using System.Collections.Generic;
using BatchGuy.App.AviSynth.Models;

namespace BatchGuy.App.AviSynth.Interfaces
{
    public interface IAviSynthFileService
    {
        List<AviSynthFile> CreateAVSFileList();
    }
}

using BatchGuy.App.Shared.Models;

namespace BatchGuy.App.AviSynth.Interfaces
{
    public interface IAviSynthWriteService
    {
       ErrorCollection CreateAVSFiles();
        void Delete();
    }
}

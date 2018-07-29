using BatchGuy.App.Shared.Models;

namespace BatchGuy.App.AviSynth.Interfaces
{
    public interface IAviSynthValidationService
    {
        ErrorCollection Validate();
    }
}

using BatchGuy.App.Shared.Models;

namespace BatchGuy.App.Shared.Interfaces
{
    public interface IDisplayErrorMessageService
    {
        void LogAndDisplayError(ErrorMessage message);
        void DisplayError(ErrorMessage message);
    }
}

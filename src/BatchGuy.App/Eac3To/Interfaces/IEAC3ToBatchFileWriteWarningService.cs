using BatchGuy.App.Shared.Models;

namespace BatchGuy.App.Eac3To.Interfaces
{
    public interface IEAC3ToBatchFileWriteWarningService
    {
        WarningCollection GetWarnings();
    }
}

using BatchGuy.App.Shared.Models;

namespace BatchGuy.App.X264Log.Interfaces
{
    public interface IX264LogParserService
    {
        ErrorCollection Errors { get; }
        string Logs { get; }
        string GetLogs();
    }
}

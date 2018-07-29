using BatchGuy.App.Settings.Models;
using System.Threading.Tasks;

namespace BatchGuy.App.Shared.Interfaces
{
    internal interface IBatchGuyNotificationService
    {
        Task<BatchGuyLatestVersionInfo> GetLatestVersionInfo();
    }
}

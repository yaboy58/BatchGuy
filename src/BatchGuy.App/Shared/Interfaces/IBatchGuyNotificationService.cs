using BatchGuy.App.Settings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Shared.Interfaces
{
    internal interface IBatchGuyNotificationService
    {
        Task<BatchGuyLatestVersionInfo> GetLatestVersionInfo();
    }
}

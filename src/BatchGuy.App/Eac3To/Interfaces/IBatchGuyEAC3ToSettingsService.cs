using BatchGuy.App.Eac3To.Models;
using BatchGuy.App.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Eac3To.Interfaces
{
    public interface IBatchGuyEAC3ToSettingsService
    {
        ErrorCollection Errors { get; }

        void Save(string settingsFile, BatchGuyEAC3ToSettings batchGuyEAC3ToSettings);

        BatchGuyEAC3ToSettings GetBatchGuyEAC3ToSettings(string settingsFile);
    }
}

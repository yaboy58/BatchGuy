using BatchGuy.App.Shared.Models;

namespace BatchGuy.App.FFMSIndex.Interfaces
{
    public interface IFFMSIndexBatchFileWriteService
    {
        ErrorCollection Errors { get; }
        ErrorCollection Write();
        bool IsValid();
        void Delete();
    }
}

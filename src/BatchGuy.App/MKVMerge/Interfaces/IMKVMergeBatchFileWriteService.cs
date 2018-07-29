using BatchGuy.App.Shared.Models;

namespace BatchGuy.App.MKVMerge.Interfaces
{
    public interface IMKVMergeBatchFileWriteService
    {
        ErrorCollection Errors { get; }
        ErrorCollection Write();
        bool IsValid();
        void Delete();
    }
}

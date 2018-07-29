using BatchGuy.App.Shared.Models;

namespace BatchGuy.App.Eac3To.Interfaces
{
    public interface IEAC3ToBatchFileWriteService
    {
        ErrorCollection Errors { get;}
        ErrorCollection Write();
        bool IsValid();
        void Delete();
    }
}

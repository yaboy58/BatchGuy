using BatchGuy.App.Shared.Models;

namespace BatchGuy.App.X264.Interfaces
{
    public interface IX264EncodeService
    {
        ErrorCollection CreateX264File(); 
    }
}

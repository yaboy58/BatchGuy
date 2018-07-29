using System.Collections.Generic;

namespace BatchGuy.App.Shared.Interfaces
{
    public interface ISortService<T>
    {
        List<T> Sort();
    }
}

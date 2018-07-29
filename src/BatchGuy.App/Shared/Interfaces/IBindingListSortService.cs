using System.ComponentModel;

namespace BatchGuy.App.Shared.Interfaces
{
    public interface IBindingListSortService<T>
    {
        BindingList<T> Sort();
    }
}

using BatchGuy.App.Enums;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchGuy.App.Shared.Services
{
    public class BindingListSortService<T> : IBindingListSortService<T>
    {
        private List<T> _unsortedList;
        private DataGridView _grid;
        private SortConfiguration _sortConfiguration;
        private ISortService<T> _sortService;

        public BindingListSortService(List<T> unsortedList, DataGridView grid, SortConfiguration sortConfiguration, ISortService<T> sortService)
        {
            _unsortedList = unsortedList;
            _grid = grid;
            _sortConfiguration = sortConfiguration;
            _sortService = sortService;
        }

        public BindingList<T> Sort()
        {
            _grid.CommitEdit(DataGridViewDataErrorContexts.CurrentCellChange);


            if (_sortConfiguration.LastSortByColumnName == _sortConfiguration.SortByColumnName)
                _sortConfiguration.SortDirection = _sortConfiguration.SortDirection == EnumSortDirection.Asc ? EnumSortDirection.Desc : EnumSortDirection.Asc;

            _sortConfiguration.LastSortByColumnName = _sortConfiguration.SortByColumnName;

            ISortService<T> sortService = new SortService<T>(_sortConfiguration, _unsortedList);
            List<T> sortedList = sortService.Sort();

            _unsortedList.Clear();

            BindingList<T> sortedBindingList = new BindingList<T>();
            foreach (T item in sortedList)
            {
                _unsortedList.Add(item);
                sortedBindingList.Add(item);
            }
            return sortedBindingList;
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Shared.Models;
using System.Linq.Dynamic;
using BatchGuy.App.Enums;

namespace BatchGuy.App.Shared.Services
{
    public class SortService<T> : ISortService<T>
    {
        private List<T> _unSortedList;
        private SortConfiguration _sortConfiguration;

        public SortService(SortConfiguration sortConfiguration, List<T> unSortedList)
        {
            _sortConfiguration = sortConfiguration;
            _unSortedList = unSortedList;
        }

        public List<T> Sort()
        {
            List<T> sortedList = new List<T>();

            if (_sortConfiguration.LastSortByColumnName == _sortConfiguration.SortByColumnName)
                _sortConfiguration.SortDirection = _sortConfiguration.SortDirection == EnumSortDirection.Asc ? EnumSortDirection.Desc : EnumSortDirection.Asc;
            else
                _sortConfiguration.SortDirection = EnumSortDirection.Asc;


            string orderBy = this.GetOrderBy();
            _sortConfiguration.LastSortByColumnName = _sortConfiguration.SortByColumnName;

            foreach (T item in _unSortedList.OrderBy(orderBy))
            {
                sortedList.Add(item);
            }

            return sortedList;
        }

        private string GetOrderBy()
        {
            string orderby = string.Empty;

            if (_sortConfiguration.ColumnOverrides != null && _sortConfiguration.ColumnOverrides.Count() > 0 && 
                _sortConfiguration.ColumnOverrides.Where(c => c.SortByColumnName == _sortConfiguration.SortByColumnName).Count() > 0)
            {
                SortConfigurationColumnOverride columnOverride = _sortConfiguration.ColumnOverrides.Where(c => c.SortByColumnName == _sortConfiguration.SortByColumnName).Single();
                orderby = string.Format("{0} {1}", columnOverride.OverrideColumnName, this.GetSortDirectionString());
            }
            else
            {
                orderby = string.Format("{0} {1}", _sortConfiguration.SortByColumnName, this.GetSortDirectionString());
            }
            return orderby;
        }

        private string GetSortDirectionString()
        {
            string sortDirection;
            switch (_sortConfiguration.SortDirection)
            {
                case BatchGuy.App.Enums.EnumSortDirection.Asc:
                    sortDirection = "asc";
                    break;
                case BatchGuy.App.Enums.EnumSortDirection.Desc:
                    sortDirection = "desc";
                    break;
                default:
                    sortDirection = "asc";
                    break;
            }
            return sortDirection;
        }
    }
}

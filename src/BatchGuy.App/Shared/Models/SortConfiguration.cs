using BatchGuy.App.Enums;
using System.Collections.Generic;

namespace BatchGuy.App.Shared.Models
{
    public class SortConfiguration
    {
        private List<SortConfigurationColumnOverride> _columnOverrides;
        public SortConfiguration(List<SortConfigurationColumnOverride> columnOverrides)
        {
            _columnOverrides = columnOverrides;
        }
        public string SortByColumnName { get; set; }
        public EnumSortDirection SortDirection { get; set; }
        public string LastSortByColumnName { get; set; }
        public List<SortConfigurationColumnOverride> ColumnOverrides
        {
            get
            {
                return _columnOverrides;
            }
        }
    }
}

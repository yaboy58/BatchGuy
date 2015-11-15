using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Enums;

namespace BatchGuy.App.Shared.Models
{
    public class SortConfiguration
    {
        public string SortByColumnName { get; set; }
        public EnumSortDirection SortDirection { get; set; }
        public string LastSortByColumnName { get; set; }
    }
}

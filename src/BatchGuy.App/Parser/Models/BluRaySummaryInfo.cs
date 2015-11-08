using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Parser.Models
{
    public class BluRaySummaryInfo
    {
        public string Id { get; set; }
        public string HeaderText { get; set; }
        public string DetailText { get; set; }
        public bool Ignore { get; set; }
        public BluRayTitleInfo BluRayTitleInfo { get; set; }
    }
}

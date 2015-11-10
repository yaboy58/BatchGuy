using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.EAC.Models;
using System.IO;

namespace BatchGuy.App.Parser.Models
{
    public class BluRayDiscInfo
    {
        public int Id { get; set; }
        public bool IsSelected { get; set; }
        public EAC3ToConfiguration EAC3ToConfiguration { get; set; }
        public List<BluRaySummaryInfo>  BluRaySummaryInfoList { get; set; }
        public string DiscName 
        { 
            get 
            {
                if (this.EAC3ToConfiguration != null)
                    return this.EAC3ToConfiguration.BluRayPath; 
                else
                    return string.Empty;
            } 
        }
    }
}

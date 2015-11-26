using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Eac3to.Models;
using System.IO;

namespace BatchGuy.App.Parser.Models
{
    public class BluRayDiscInfo
    {
        public int Id { get; set; }
        public bool IsSelected { get; set; }
        public List<BluRaySummaryInfo>  BluRaySummaryInfoList { get; set; }
        public string BluRayPath { get; set; }
        public string DiscName 
        { 
            get 
            {
                if (this.BluRayPath != null)
                    return this.BluRayPath; 
                else
                    return string.Empty;
            } 
        }
    }
}

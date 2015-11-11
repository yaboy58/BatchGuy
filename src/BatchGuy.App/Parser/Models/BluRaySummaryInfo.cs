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
        public bool IsSelected { get; set; }
        public BluRayTitleInfo BluRayTitleInfo { get; set; }
        public string EpisodeNumber 
        { 
            get
            {
                if (this.BluRayTitleInfo == null)
                    return string.Empty;
                else
                    return this.BluRayTitleInfo.EpisodeNumber;
            }
            set
            {
                if (this.BluRayTitleInfo != null)
                {
                    this.BluRayTitleInfo.EpisodeNumber = value;
                }
            }
 
        }
    }
}

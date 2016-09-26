using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Extensions;
using BatchGuy.App.Eac3To.Models;

namespace BatchGuy.App.Parser.Models
{
    public class BluRaySummaryInfo
    {
        public BluRaySummaryInfo()
        {
            RemuxFileNameForMovieTemplate = new EAC3ToRemuxFileNameTemplate();
        }

        public string Eac3ToId { get; set; }
        public string HeaderText { get; set; }
        public string DetailText { get; set; }
        public bool IsSelected { get; set; }
        public BluRayTitleInfo BluRayTitleInfo { get; set; }
        public int? EpisodeNumber 
        { 
            get
            {
                if (this.BluRayTitleInfo == null)
                    return null;
                else
                    return this.BluRayTitleInfo.EpisodeNumber.StringToNullInt();
            }
        }
        public EAC3ToRemuxFileNameTemplate RemuxFileNameForMovieTemplate { get; set; }
    }
}

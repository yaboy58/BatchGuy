using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Parser.Models
{
    public class BluRayTitleInfo
    {
        public int EpisodeNumber { get; set; }
        public string HeaderText { get; set; }
        public BluRayTitleChapter Chapter { get; set; }
        public BluRayTitleMovie Movie { get; set; }
        public List<BluRayTitleAudio> AudioList { get; set; }
        public List<BluRayTitleSubtitle> Subtitles { get; set; }
    }
}

using BatchGuy.App.MKVMerge.Models;
using System.IO;

namespace BatchGuy.App.Parser.Models
{
    public class BluRayTitleSubtitle
    {
        public string Id { get; set; }
        public string Language { get; set; }
        public bool IsSelected { get; set; }
        public string Text { get; set; }
        public bool IsCommentary { get; set; }
        public MKVMergeItem MKVMergeItem { get; set; }
        public string ExternalSubtitlePath { get; set; }
        public string ExternalSubtitleNameOnly
        {
            get
            {
                if (this.ExternalSubtitlePath != null && this.ExternalSubtitlePath != string.Empty)
                    return Path.GetFileName(this.ExternalSubtitlePath);
                else
                    return string.Empty;
            }
        }
        public bool CanEdit { get; set; }
        public bool IsExternal { get; set; }
    }
}

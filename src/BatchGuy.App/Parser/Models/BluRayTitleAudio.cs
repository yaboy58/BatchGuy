using BatchGuy.App.Enums;
using BatchGuy.App.MKVMerge.Models;

namespace BatchGuy.App.Parser.Models
{
    public class BluRayTitleAudio
    {
        public string Id { get; set; }
        public EnumAudioType AudioType { get; set; }
        public string Language { get; set; }
        public string Arguments { get; set; }
        public bool IsSelected { get; set; }
        public string Text { get; set; }
        public bool IsCommentary { get; set; }
        public MKVMergeItem MKVMergeItem { get; set; }
        public EnumAudioType OriginalAudioType { get; set; }
        public bool IsLossless { get; set; }
    }
}

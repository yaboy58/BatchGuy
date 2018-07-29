namespace BatchGuy.App.MKVMerge.Models
{
    public class MKVMergeItem
    {
        public string TrackName { get; set; }
        public MKVMergeLanguageItem Language { get; set; }
        public string DefaultTrackFlag { get; set; }
        public string ForcedTrackFlag { get; set; }
        public string Compression { get; set; }
    }
}

namespace BatchGuy.App.MKVMerge.Interfaces
{
    public interface IMKVMergeOutputService
    {
        string GetMKVMergePathPart();
        string GetOutputPart();
        string GetChaptersPart();
        string GetVideoPart();
        string GetAudioPart();
        string GetSubtitlePart();
        string GetTrackOrderPart();
    }
}

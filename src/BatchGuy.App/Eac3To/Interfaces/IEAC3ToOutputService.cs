namespace BatchGuy.App.Eac3to.Interfaces
{
    public interface IEAC3ToOutputService
    {
        string GetEAC3ToPathPart();
        string GetBluRayStreamPart();
        string GetChapterStreamPart();
        string GetVideoStreamPart();
        string GetAudioStreamPart();
        string GetSubtitleStreamPart();
        string GetLogPart();
        string GetShowProgressNumbersPart();
    }
}

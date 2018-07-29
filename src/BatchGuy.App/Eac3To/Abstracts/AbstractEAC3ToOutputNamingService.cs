using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Eac3To.Models;
using BatchGuy.App.Enums;
using BatchGuy.App.Extensions;
using BatchGuy.App.Helpers;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Interfaces;

namespace BatchGuy.App.Eac3To.Abstracts
{
    public abstract class AbstractEAC3ToOutputNamingService
    {
        protected IAudioService _audioService;
        protected EnumEAC3ToNamingConventionType _enumEAC3ToNamingConventionType;
        protected BluRaySummaryInfo _currentBluRaySummaryInfo;
        protected EAC3ToRemuxFileNameTemplate _currentMovieRemuxTemplate;

        public EnumEAC3ToNamingConventionType EnumEAC3ToNamingConventionType { get { return _enumEAC3ToNamingConventionType; } }

        public AbstractEAC3ToOutputNamingService(IAudioService audioService)
        {
            _audioService = audioService;
        }

        public void SetCurrentBluRaySummaryInfo(BluRaySummaryInfo currentBluRaySummaryInfo)
        {
            _currentBluRaySummaryInfo = currentBluRaySummaryInfo;
            _currentMovieRemuxTemplate = _currentBluRaySummaryInfo.RemuxFileNameForMovieTemplate;
        }
        protected string GetAudioCommentary(BluRayTitleAudio audio)
        {
            string commentary = string.Empty;
            if (audio.IsCommentary)
                commentary = "-commentary";
            return commentary;
        }
        protected string GetSubtitleCommentary(BluRayTitleSubtitle subtitle)
        {
            string commentary = string.Empty;
            if (subtitle.IsCommentary)
                commentary = "-commentary";
            return commentary;
        }
        protected string AddWordSeparator(bool isExtractForRemux, bool usePeriodsInFileName, string episodeName)
        {
            if (isExtractForRemux && usePeriodsInFileName)
                return episodeName.ReplaceSpacesWithPeriods();
            else
                return episodeName;
        }
        protected string PadNumberWithZeros(int batchCount, int number)
        {
            return HelperFunctions.PadNumberWithZeros(batchCount, number);
        }
        public abstract string GetChapterName(EAC3ToConfiguration eac3toConfiguration, string filesOutputPath, string paddedEpisodeNumber, string episodeName);
        public abstract string GetVideoName(EAC3ToConfiguration eac3toConfiguration, string filesOutputPath, string paddedEpisodeNumber, string episodeName);
        public abstract string GetAudioName(EAC3ToConfiguration eac3toConfiguration, BluRayTitleAudio audio, string filesOutputPath, string paddedEpisodeNumber, string episodeName);
        public abstract string GetSubtitleName(EAC3ToConfiguration eac3toConfiguration, BluRayTitleSubtitle subtitle, string filesOutputPath, string paddedEpisodeNumber, string episodeName);
        public abstract string GetLogName(EAC3ToConfiguration eac3toConfiguration, string filesOutputPath, string paddedEpisodeNumber, string episodeName);
    }
}

using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Extensions;
using BatchGuy.App.Helpers;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Eac3To.Abstracts
{
    public abstract class AbstractEAC3ToOutputNamingService
    {
        protected IAudioService _audioService;
        public AbstractEAC3ToOutputNamingService(IAudioService audioService)
        {
            _audioService = audioService;
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
        protected string AddWordSeparator(EAC3ToConfiguration eac3toConfiguration, string episodeName)
        {
            if (eac3toConfiguration.IsExtractForRemux && eac3toConfiguration.RemuxFileNameTemplate.UsePeriodsInFileName)
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

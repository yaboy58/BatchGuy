using BatchGuy.App.Eac3To.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Extensions;
using BatchGuy.App.Enums;

namespace BatchGuy.App.Eac3To.Services
{
    public class EncodeTemplate1EAC3ToOutputNamingService : AbstractEAC3ToOutputNamingService
    {
        public EncodeTemplate1EAC3ToOutputNamingService(IAudioService audioService) : base(audioService)
        {
            _enumEAC3ToNamingConventionType = EnumEAC3ToNamingConventionType.EncodeNamingConventionTemplate1;
        }

        public override string GetAudioName(EAC3ToConfiguration eac3toConfiguration, BluRayTitleAudio audio, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux != true)
            {
                sb.Append(string.Format("\"{0}\\{1}{2}-{3}{4}.{5}\"", filesOutputPath, audio.Language, paddedEpisodeNumber, audio.Id.RemoveColons(), this.GetAudioCommentary(audio),
                _audioService.GetAudioExtension(audio.AudioType)));
            }
            return sb.ToString();
        }

        public override string GetChapterName(EAC3ToConfiguration eac3toConfiguration, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux != true)
            {
                sb.Append(string.Format("\"{0}\\chapters{1}.txt\"", filesOutputPath, paddedEpisodeNumber));
            }
            return sb.ToString();
        }

        public override string GetLogName(EAC3ToConfiguration eac3toConfiguration, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux != true)
            {
                sb.Append(string.Format(" -log=\"{0}\\log{1}.log\"", filesOutputPath, paddedEpisodeNumber));
            }
            return sb.ToString();
        }

        public override string GetSubtitleName(EAC3ToConfiguration eac3toConfiguration, BluRayTitleSubtitle subtitle, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux != true)
            {
                sb.Append(string.Format("\"{0}\\{1}{2}-{3}{4}.sup\"", filesOutputPath, subtitle.Language, paddedEpisodeNumber, subtitle.Id.RemoveColons(), this.GetSubtitleCommentary(subtitle)));
            }
            return sb.ToString();
        }

        public override string GetVideoName(EAC3ToConfiguration eac3toConfiguration, string filesOutputPath, string paddedEpisodeNumber, string episodeName)
        {
            StringBuilder sb = new StringBuilder();
            if (eac3toConfiguration.IsExtractForRemux != true)
            {
                sb.Append(string.Format("\"{0}\\video{1}.mkv\"", filesOutputPath, paddedEpisodeNumber));
            }
            return sb.ToString();
        }
    }
}

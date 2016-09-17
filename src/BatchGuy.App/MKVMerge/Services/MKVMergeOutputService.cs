using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Eac3To.Abstracts;
using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Enums;
using BatchGuy.App.Extensions;
using BatchGuy.App.Helpers;
using BatchGuy.App.MKVMerge.Interfaces;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.MKVMerge.Services
{
    public class MKVMergeOutputService : IMKVMergeOutputService
    {
        private EAC3ToConfiguration _eac3ToConfiguration;
        private ErrorCollection _errors = new ErrorCollection();
        private string _filesOutputPath;
        private string _paddedEpisodeNumber;
        private string _bluRayPath;
        private BluRaySummaryInfo _bluRaySummaryInfo;
        private AbstractEAC3ToOutputNamingService _eac3ToOutputNamingService;

        public MKVMergeOutputService(EAC3ToConfiguration config, AbstractEAC3ToOutputNamingService eac3ToOutputNamingService, string bluRayPath, BluRaySummaryInfo bluRaySummaryInfo)
        {
            _eac3ToConfiguration = config;
            _eac3ToOutputNamingService = eac3ToOutputNamingService;
            _bluRayPath = bluRayPath;
            _bluRaySummaryInfo = bluRaySummaryInfo;
            this.Init();
        }

        private void Init()
        {
            _paddedEpisodeNumber = HelperFunctions.PadNumberWithZeros(_eac3ToConfiguration.NumberOfEpisodes, _bluRaySummaryInfo.BluRayTitleInfo.EpisodeNumber.StringToInt());
            if (_eac3ToConfiguration.OutputDirectoryType == EnumDirectoryType.DirectoryPerEpisode)
            {
                string folderName = string.Format("e{0}", _paddedEpisodeNumber);
                _filesOutputPath = string.Format("{0}\\{1}", _eac3ToConfiguration.EAC3ToOutputPath, folderName);
            }
            else
            {
                _filesOutputPath = string.Format("{0}", _eac3ToConfiguration.EAC3ToOutputPath);
            }
        }

        public string GetMKVMergePathPart()
        {
            return string.Format("\"{0}\"", _eac3ToConfiguration.MKVMergePath);
        }

        public string GetOutputPart()
        {
            if (_eac3ToConfiguration.IsVideoNameForEncodeMkvMerge == false)
                return string.Format("--ui-language en --output ^\"{0}^\"", _eac3ToOutputNamingService.GetVideoName(_eac3ToConfiguration, _eac3ToConfiguration.MKVMergeOutputPath, _paddedEpisodeNumber, _bluRaySummaryInfo.BluRayTitleInfo.EpisodeName).RemoveDoubleQuotes());
            else
               return string.Format("--ui-language en --output ^\"{0}\\{1}^\"", _eac3ToConfiguration.MKVMergeOutputPath, Path.GetFileName(_bluRaySummaryInfo.BluRayTitleInfo.EpisodeName));
        }

        public string GetVideoPart()
        {
            StringBuilder sb = new StringBuilder();
            if (_bluRaySummaryInfo.BluRayTitleInfo.Video != null)
            {
                if (_bluRaySummaryInfo.BluRayTitleInfo.Video.IsSelected)
                {
                    sb.Append(string.Format("--language 0:und ^\"^(^\" ^\"{0}^\" ^\"^)^\"", _eac3ToOutputNamingService.GetVideoName(_eac3ToConfiguration, _filesOutputPath, _paddedEpisodeNumber, _bluRaySummaryInfo.BluRayTitleInfo.EpisodeName).RemoveDoubleQuotes()));
                }
            }
            return sb.ToString();
        }
        public string GetAudioPart()
        {
            StringBuilder sb = new StringBuilder();
            if (_bluRaySummaryInfo.BluRayTitleInfo.AudioList != null)
            {
                foreach (BluRayTitleAudio audio in _bluRaySummaryInfo.BluRayTitleInfo.AudioList)
                {
                    if (audio.IsSelected)
                    {
                        sb.Append(string.Format("--language 0:{0} {1} {2} {3} {4} ^\"^(^\" ^\"{5}^\" ^\"^)^\"", audio.MKVMergeItem.Language.Value, this.GetTrackName(audio.MKVMergeItem.TrackName), this.GetDefaultTrackFlag(audio.MKVMergeItem.DefaultTrackFlag),
                            this.GetForcedTrackFlag(audio.MKVMergeItem.ForcedTrackFlag),this.GetCompression(audio.MKVMergeItem.Compression), _eac3ToOutputNamingService.GetAudioName(_eac3ToConfiguration, audio, _filesOutputPath, _paddedEpisodeNumber, _bluRaySummaryInfo.BluRayTitleInfo.EpisodeName).RemoveDoubleQuotes()));
                        sb.Append(" ");
                    }
                }
            }
            return sb.ToString();
        }

        public string GetSubtitlePart()
        {
            StringBuilder sb = new StringBuilder();
            if (_bluRaySummaryInfo.BluRayTitleInfo.Subtitles != null)
            {
                if (_eac3ToConfiguration.IgnoreInternalSubtitles == false)
                {
                    foreach (BluRayTitleSubtitle subtitle in _bluRaySummaryInfo.BluRayTitleInfo.Subtitles)
                    {
                        if (subtitle.IsSelected)
                        {
                            string subtitleName = string.Empty;
                            if (subtitle.IsExternal)
                            {
                                subtitleName = subtitle.ExternalSubtitlePath;
                            }
                            else
                            {
                                subtitleName = _eac3ToOutputNamingService.GetSubtitleName(_eac3ToConfiguration, subtitle, _filesOutputPath, _paddedEpisodeNumber, _bluRaySummaryInfo.BluRayTitleInfo.EpisodeName).RemoveDoubleQuotes();
                            }

                            sb.Append(string.Format("--language 0:{0} {1} {2} {3} {4} ^\"^(^\" ^\"{5}^\" ^\"^)^\"", subtitle.MKVMergeItem.Language.Value, this.GetTrackName(subtitle.MKVMergeItem.TrackName), this.GetDefaultTrackFlag(subtitle.MKVMergeItem.DefaultTrackFlag),
                                this.GetForcedTrackFlag(subtitle.MKVMergeItem.ForcedTrackFlag), this.GetCompression(subtitle.MKVMergeItem.Compression), subtitleName));
                            sb.Append(" ");
                        }
                    }
                }
                else
                {
                    foreach (BluRayTitleSubtitle subtitle in _bluRaySummaryInfo.BluRayTitleInfo.Subtitles.Where(s => s.IsExternal))
                    {
                        if (subtitle.IsSelected)
                        {
                            string subtitleName = string.Empty;
                            subtitleName = subtitle.ExternalSubtitlePath;

                            sb.Append(string.Format("--language 0:{0} {1} {2} {3} {4} ^\"^(^\" ^\"{5}^\" ^\"^)^\"", subtitle.MKVMergeItem.Language.Value, this.GetTrackName(subtitle.MKVMergeItem.TrackName), this.GetDefaultTrackFlag(subtitle.MKVMergeItem.DefaultTrackFlag),
                                this.GetForcedTrackFlag(subtitle.MKVMergeItem.ForcedTrackFlag), this.GetCompression(subtitle.MKVMergeItem.Compression), subtitleName));
                            sb.Append(" ");
                        }
                    }
                }
            }
            return sb.ToString();
        }

        public string GetChaptersPart()
        {
            StringBuilder sb = new StringBuilder();
            if (_bluRaySummaryInfo.BluRayTitleInfo.Chapter != null && _bluRaySummaryInfo.BluRayTitleInfo.Chapter.IsSelected)
            {
                sb.Append(string.Format("--chapter-language eng --chapters ^\"{0}^\"", _eac3ToOutputNamingService.GetChapterName(_eac3ToConfiguration, _filesOutputPath, _paddedEpisodeNumber, _bluRaySummaryInfo.BluRayTitleInfo.EpisodeName).RemoveDoubleQuotes()));
            }
            return sb.ToString();
        }

        public string GetTrackOrderPart()
        {
            StringBuilder sb = new StringBuilder();
            int trackCount = 0;

            sb.Append("--track-order ");
            if (_bluRaySummaryInfo.BluRayTitleInfo.Video != null && _bluRaySummaryInfo.BluRayTitleInfo.Video.IsSelected)
            {
                trackCount++;
            }

            if (_bluRaySummaryInfo.BluRayTitleInfo.AudioList != null && _bluRaySummaryInfo.BluRayTitleInfo.AudioList.Where(a => a.IsSelected).Count() > 0)
            {
                trackCount += _bluRaySummaryInfo.BluRayTitleInfo.AudioList.Where(a => a.IsSelected).Count();
            }

            if (_eac3ToConfiguration.IgnoreInternalSubtitles == false)
            {
                if (_bluRaySummaryInfo.BluRayTitleInfo.Subtitles != null && _bluRaySummaryInfo.BluRayTitleInfo.Subtitles.Where(a => a.IsSelected).Count() > 0)
                {
                    trackCount += _bluRaySummaryInfo.BluRayTitleInfo.Subtitles.Where(a => a.IsSelected).Count();
                }
            }
            else
            {
                if (_bluRaySummaryInfo.BluRayTitleInfo.Subtitles != null && _bluRaySummaryInfo.BluRayTitleInfo.Subtitles.Where(a => a.IsSelected && a.IsExternal).Count() > 0)
                {
                    trackCount += _bluRaySummaryInfo.BluRayTitleInfo.Subtitles.Where(a => a.IsSelected && a.IsExternal).Count();
                }
            }


            for (int i = 0; i < trackCount; i++)
            {
                sb.Append(string.Format("{0}:0,", i));
            }

            return sb.ToString().Substring(0, sb.ToString().Length - 1);
        }

        private string GetTrackName(string trackName)
        {
            if (trackName != null && trackName.Trim() != string.Empty)
                return string.Format(" --track-name ^\"0:{0}^\"", trackName.Trim());
            else
                return string.Empty;
        }

        private string GetDefaultTrackFlag(string defaultTrackFlag)
        {
            if (defaultTrackFlag != null && defaultTrackFlag.Trim() != string.Empty && defaultTrackFlag != "determine automatically")
                return string.Format(" --default-track 0:{0}", defaultTrackFlag.Trim());
            else
                return string.Empty;
        }

        private string GetForcedTrackFlag(string forcedTrackFlag)
        {
            if (forcedTrackFlag != null && forcedTrackFlag.Trim() != string.Empty)
                return string.Format(" --forced-track 0:{0}", forcedTrackFlag.Trim());
            else
                return string.Empty;
        }

        private string GetCompression(string compression)
        {
            if (compression != null && compression.Trim() != string.Empty && compression != "determine automatically")
            {
                if (compression != null && compression.Trim() != string.Empty && compression == "no extra compression")
                {
                    return string.Format(" --compression 0:{0}", "none");
                }
                else
                {
                    return string.Format(" --compression 0:{0}", compression.Trim());
                }
            }
            else
            {
                return string.Empty;
            }
        }
    }
}

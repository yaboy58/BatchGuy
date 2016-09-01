using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.MKVMerge.Interfaces;
using BatchGuy.App.MKVMerge.Models;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Settings.Interface;
using BatchGuy.App.Settings.Models;
using BatchGuy.App.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Settings.Services
{
    public class MKVMergeDefaultSettingsService : IMKVMergeDefaultSettingsService
    {
        private ApplicationSettings _applicationSettings;
        private EAC3ToConfiguration _eac3toConfiguration;
        private BluRaySummaryInfo _bluRaySummaryInfo;
        IMKVMergeLanguageService _languageService;

        public MKVMergeDefaultSettingsService(EAC3ToConfiguration eac3toConfiguration, ApplicationSettings applicationSettings, BluRaySummaryInfo bluRaySummaryInfo, IMKVMergeLanguageService languageService)
        {
            _eac3toConfiguration = eac3toConfiguration;
            _applicationSettings = applicationSettings;
            _bluRaySummaryInfo = bluRaySummaryInfo;
            _languageService = languageService;
        }

        public void SetAudioDefaultSettings()
        {
            if (_eac3toConfiguration.IsExtractForRemux)
            {
                if (_bluRaySummaryInfo.BluRayTitleInfo.AudioList != null)
                {
                    foreach (BluRayTitleAudio audio in _bluRaySummaryInfo.BluRayTitleInfo.AudioList)
                    {
                        audio.MKVMergeItem = new MKVMergeItem() { DefaultTrackFlag = "no", ForcedTrackFlag = "no", Language = _languageService.GetLanguageByName(audio.Language), TrackName = "", Compression = "determine automatically" };
                    }
                }
            }
        }

        public void SetSubtitleDefaultSettings()
        {
            if (_bluRaySummaryInfo.BluRayTitleInfo.Subtitles != null)
            {
                foreach (BluRayTitleSubtitle subtitle in _bluRaySummaryInfo.BluRayTitleInfo.Subtitles)
                {
                    subtitle.MKVMergeItem = new MKVMergeItem() { DefaultTrackFlag = "no", ForcedTrackFlag = "no", Language = _languageService.GetLanguageByName(subtitle.Language), TrackName = "", Compression = "determine automatically" };
                }

                if (_applicationSettings.SubtitleLanguageAlwaysSelectedEnabled)
                {
                    foreach (BluRayTitleSubtitle subtitle in _bluRaySummaryInfo.BluRayTitleInfo.Subtitles.Where(a => a.Text.ToLower().Contains("english")))
                    {
                        subtitle.IsSelected = true;
                        subtitle.MKVMergeItem.Compression = _applicationSettings.SubtitlesMKVMergeDefaultSettings.DefaultMKVMergeItem.Compression;
                        subtitle.MKVMergeItem.DefaultTrackFlag = _applicationSettings.SubtitlesMKVMergeDefaultSettings.DefaultMKVMergeItem.DefaultTrackFlag;
                        subtitle.MKVMergeItem.ForcedTrackFlag = _applicationSettings.SubtitlesMKVMergeDefaultSettings.DefaultMKVMergeItem.ForcedTrackFlag;
                        subtitle.MKVMergeItem.Language = _applicationSettings.SubtitlesMKVMergeDefaultSettings.DefaultMKVMergeItem.Language;
                        subtitle.MKVMergeItem.TrackName = _applicationSettings.SubtitlesMKVMergeDefaultSettings.DefaultMKVMergeItem.TrackName;
                    }
                }
            }
        }
    }
}

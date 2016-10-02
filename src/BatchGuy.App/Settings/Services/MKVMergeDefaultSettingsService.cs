using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Enums;
using BatchGuy.App.MKVMerge.Interfaces;
using BatchGuy.App.MKVMerge.Models;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Settings.Interface;
using BatchGuy.App.Settings.Models;
using BatchGuy.App.Shared.Interfaces;
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
        private IMKVMergeLanguageService _languageService;
        private IAudioService _audioService;

        public MKVMergeDefaultSettingsService(EAC3ToConfiguration eac3toConfiguration, ApplicationSettings applicationSettings, BluRaySummaryInfo bluRaySummaryInfo, 
            IMKVMergeLanguageService languageService, IAudioService audioService)
        {
            _eac3toConfiguration = eac3toConfiguration;
            _applicationSettings = applicationSettings;
            _bluRaySummaryInfo = bluRaySummaryInfo;
            _languageService = languageService;
            _audioService = audioService;
        }

        public void SetAudioDefaultSettings()
        {
            if (_bluRaySummaryInfo.BluRayTitleInfo.AudioList != null)
            {
                foreach (BluRayTitleAudio audio in _bluRaySummaryInfo.BluRayTitleInfo.AudioList)
                {
                    audio.MKVMergeItem = new MKVMergeItem() { DefaultTrackFlag = "no", ForcedTrackFlag = "no", Language = _languageService.GetLanguageByName(audio.Language), TrackName = "", Compression = "determine automatically" };
                }

                if (_applicationSettings.AudioLanguageAlwaysSelectedEnabled)
                {
                    foreach (BluRayTitleAudio audio in _bluRaySummaryInfo.BluRayTitleInfo.AudioList.Where(a => a.Text.ToLower().Contains(_applicationSettings.AudioMKVMergeDefaultSettings.DefaultMKVMergeItem.Language.Language.ToLower())))
                    {
                        if (_applicationSettings.AudioMKVMergeDefaultSettings.AudioTypeFilterCriteria == "Any Type")
                        {
                            audio.IsSelected = true;
                            this.SetBluRayMKVMergeItemDefaults(audio.MKVMergeItem, _applicationSettings.AudioMKVMergeDefaultSettings.DefaultMKVMergeItem);
                        }
                        else if (_applicationSettings.AudioMKVMergeDefaultSettings.AudioTypeFilterCriteria == "Lossless")
                        {
                            if (_audioService.IsLosslessBluRayAudio(audio.OriginalAudioType))
                            {
                                audio.IsSelected = true;
                                this.SetBluRayMKVMergeItemDefaults(audio.MKVMergeItem, _applicationSettings.AudioMKVMergeDefaultSettings.DefaultMKVMergeItem);
                            }
                        }
                        else
                        {
                            EnumAudioType audioTypeFilter = _audioService.GetAudioTypeByName(_applicationSettings.AudioMKVMergeDefaultSettings.AudioTypeFilterCriteria);
                            if (audioTypeFilter == audio.OriginalAudioType)
                            {
                                audio.IsSelected = true;
                                this.SetBluRayMKVMergeItemDefaults(audio.MKVMergeItem, _applicationSettings.AudioMKVMergeDefaultSettings.DefaultMKVMergeItem);
                            }
                        }
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
                    foreach (BluRayTitleSubtitle subtitle in _bluRaySummaryInfo.BluRayTitleInfo.Subtitles.Where(a => a.Text.ToLower().Contains(_applicationSettings.SubtitlesMKVMergeDefaultSettings.DefaultMKVMergeItem.Language.Language.ToLower())))
                    {
                        subtitle.IsSelected = true;
                        this.SetBluRayMKVMergeItemDefaults(subtitle.MKVMergeItem, _applicationSettings.SubtitlesMKVMergeDefaultSettings.DefaultMKVMergeItem);
                    }
                }
            }
        }

        private void SetBluRayMKVMergeItemDefaults(MKVMergeItem item, MKVMergeItem defaults)
        {
            item.Compression = defaults.Compression;
            item.DefaultTrackFlag = defaults.DefaultTrackFlag;
            item.ForcedTrackFlag = defaults.ForcedTrackFlag;
            item.Language = defaults.Language;
            item.TrackName = defaults.TrackName;
        }
    }
}

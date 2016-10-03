using BatchGuy.App.Enums;
using BatchGuy.App.MKVMerge.Models;
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
    public class SettingsDefaultSeedDataService
    {
        private ApplicationSettings _applicationSettings;
        private IAudioService _audioService;

        public SettingsDefaultSeedDataService(ApplicationSettings applicationSettings, IAudioService audioService)
        {
            _applicationSettings = applicationSettings;
            _audioService = audioService;
        }

        public void Create()
        {
            this.LoadBluRayTitleInfoDefaultSettings();
            this.LoadEAC3ToDefaultSettings();
            this.LoadSubtitlesMKVMergeDefaultSettings();
            this.LoadAudioMKVMergeDefaultSettings();
            this.LoadNameValuePairDefaultSettings();
            this.LoadDTSExpressAudioDefaultSettings();
        }

        private void LoadBluRayTitleInfoDefaultSettings()
        {
            if (_applicationSettings.BluRayTitleInfoDefaultSettings == null)
            {
                ResetBluRayTitleInfoDefaultSettings();
            }
        }

        private void LoadEAC3ToDefaultSettings()
        {
            if (_applicationSettings.EAC3ToDefaultSettings == null)
            {
                this.ResetEAC3ToDefaultSettings();
            }
        }

        private void LoadSubtitlesMKVMergeDefaultSettings()
        {
            if (_applicationSettings.SubtitlesMKVMergeDefaultSettings == null)
            {
                this.ResetSubtitlesMKVMergeDefaultSettings();
            }
        }

        private void LoadAudioMKVMergeDefaultSettings()
        {
            if (_applicationSettings.AudioMKVMergeDefaultSettings == null)
            {
                this.ResetAudioMKVMergeDefaultSettings();
            }
        }

        private void LoadNameValuePairDefaultSettings()
        {
            if (_applicationSettings.Settings.Where(s => s.Name == "eac3to").Count() == 0)
                _applicationSettings.Settings.Add(new Setting() { Name = "eac3to", Value = string.Empty });
            if (_applicationSettings.Settings.Where(s => s.Name == "mkvmerge").Count() == 0)
                _applicationSettings.Settings.Add(new Setting() { Name = "mkvmerge", Value = string.Empty });
            if (_applicationSettings.Settings.Where(s => s.Name == "vfw4x264").Count() == 0)
                _applicationSettings.Settings.Add(new Setting() { Name = "vfw4x264", Value = string.Empty });
            if (_applicationSettings.Settings.Where(s => s.Name == "ffmsindex").Count() == 0)
                _applicationSettings.Settings.Add(new Setting() { Name = "ffmsindex", Value = string.Empty });


        }

        private void ResetSubtitlesMKVMergeDefaultSettings()
        {
            _applicationSettings.SubtitleLanguageAlwaysSelectedEnabled = true;
            _applicationSettings.SubtitlesMKVMergeDefaultSettings = new SubtitlesMKVMergeDefaultSettings()
            {
                DefaultMKVMergeItem = new MKVMerge.Models.MKVMergeItem()
                {
                    Compression = "determine automatically",
                    DefaultTrackFlag = "yes",
                    ForcedTrackFlag = "no",
                    TrackName = string.Empty,
                    Language = new MKVMergeLanguageItem() { Language = "English", Name = "English (eng)", Value = "eng" }
                }
            };
        }

        private void ResetAudioMKVMergeDefaultSettings()
        {
            _applicationSettings.AudioLanguageAlwaysSelectedEnabled = true;
            _applicationSettings.AudioMKVMergeDefaultSettings = new AudioMKVMergeDefaultSettings()
            {
                DefaultMKVMergeItem = new MKVMerge.Models.MKVMergeItem()
                {
                    Compression = "determine automatically",
                    DefaultTrackFlag = "yes",
                    ForcedTrackFlag = "no",
                    TrackName = string.Empty,
                    Language = new MKVMergeLanguageItem() { Language = "English", Name = "English (eng)", Value = "eng" }
                },
                AudioTypeFilterCriteria = "Any Type"
            };
        }

        private void ResetEAC3ToDefaultSettings()
        {
            _applicationSettings.EAC3ToDefaultSettings = new EAC3ToDefaultSettings() { ShowProgressNumbers = true };
        }


        private void ResetBluRayTitleInfoDefaultSettings()
        {
            _applicationSettings.BluRayTitleInfoDefaultSettings = new BluRayTitleInfoDefaultSettings() { Enabled = true, SelectChapters = true, SelectAllSubtitles = true };

            var bluRayAudioTypes = _audioService.GetBluRayAudioTypes();

            foreach (EnumAudioType type in bluRayAudioTypes)
            {
                BluRayTitleInfoDefaultSettingsAudio audio = new BluRayTitleInfoDefaultSettingsAudio() { Arguments = "", DefaultType = type.ToString(), Type = type, Name = type.ToString() };
                if (type == EnumAudioType.DTSMA)
                {
                    audio.DefaultType = EnumAudioType.DTSMA.ToString();
                    audio.Arguments = "-core";
                }
                else if (type == EnumAudioType.LPCM)
                {
                    audio.DefaultType = EnumAudioType.FLAC.ToString();
                }
                else if (type == EnumAudioType.TrueHD)
                {
                    audio.DefaultType = EnumAudioType.AC3.ToString();
                    audio.Arguments = "-640";
                }
                _applicationSettings.BluRayTitleInfoDefaultSettings.Audio.Add(audio);
            }
        }

        private void LoadDTSExpressAudioDefaultSettings()
        {
            if (_applicationSettings.BluRayTitleInfoDefaultSettings.Audio.Where(a => a.Type == EnumAudioType.DTSEXPRESS).Count() == 0)
            {
                BluRayTitleInfoDefaultSettingsAudio audio = new BluRayTitleInfoDefaultSettingsAudio() { Arguments = "", DefaultType = _audioService.GetAudioTypeName(EnumAudioType.DTSEXPRESS), Type = EnumAudioType.DTSEXPRESS, Name = _audioService.GetAudioTypeName(EnumAudioType.DTSEXPRESS) };
                _applicationSettings.BluRayTitleInfoDefaultSettings.Audio.Add(audio);
            }
        }
    }
}

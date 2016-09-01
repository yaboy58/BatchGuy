using BatchGuy.App.Parser.Models;
using BatchGuy.App.Settings.Interface;
using BatchGuy.App.Settings.Models;
using BatchGuy.App.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Settings.Services
{
    public class BluRayTitleInfoDefaultSettingsService : IBluRayTitleInfoDefaultSettingsService
    {
        private BluRaySummaryInfo _bluRaySummaryInfo;
        private BluRayTitleInfoDefaultSettings _bluRayTitleInfoDefaultSettings;
        private IAudioService _audioService;

        public BluRayTitleInfoDefaultSettingsService(BluRayTitleInfoDefaultSettings bluRayTitleInfoDefaultSettings, BluRaySummaryInfo bluRaySummaryInfo, IAudioService audioService)
        {
            _bluRayTitleInfoDefaultSettings = bluRayTitleInfoDefaultSettings;
            _bluRaySummaryInfo = bluRaySummaryInfo;
            _audioService = audioService;
        }
        public void SetAudioDefaultSettings()
        {
            if (_bluRaySummaryInfo.BluRayTitleInfo.AudioList != null)
            {
                foreach (var audio in _bluRaySummaryInfo.BluRayTitleInfo.AudioList)
                {
                    var defaultSetting = _bluRayTitleInfoDefaultSettings.Audio.First(a => a.Type == audio.AudioType);
                    audio.Arguments = defaultSetting.Arguments;
                    audio.AudioType = _audioService.GetAudioTypeByName(defaultSetting.DefaultType);
                }
            }
        }

        public void SetChaptersDefaultSettings()
        {
            if (_bluRaySummaryInfo.BluRayTitleInfo.Chapter != null)
            {
                _bluRaySummaryInfo.BluRayTitleInfo.Chapter.IsSelected = _bluRayTitleInfoDefaultSettings.SelectChapters;
            }
        }

        public void SetSubtitleDefaultSettings()
        {
            if (_bluRaySummaryInfo.BluRayTitleInfo.Subtitles != null)
            {
                _bluRaySummaryInfo.BluRayTitleInfo.Subtitles.ForEach(s => s.IsSelected = _bluRayTitleInfoDefaultSettings.SelectAllSubtitles);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Settings.Interface
{
    public interface IBluRayTitleInfoDefaultSettingsService
    {
        void SetSubtitleDefaultSettings();
        void SetAudioDefaultSettings();
        void SetChaptersDefaultSettings();
    }
}

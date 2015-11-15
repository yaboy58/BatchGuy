using BatchGuy.App.Settings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Shared.Models;

namespace BatchGuy.App.Settings.Interface
{
    public interface IApplicationSettingsService
    {
        ErrorCollection Errors { get; }

        void Save(ApplicationSettings applicationSettings);

        ApplicationSettings GetApplicationSettings();

        Setting GetSettingByName(string settingName);
    }
}

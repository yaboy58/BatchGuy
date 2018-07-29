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

using BatchGuy.App.Enums;
using System.Collections.Generic;

namespace BatchGuy.App.Shared.Interfaces
{
    public interface IAudioService
    {
        string GetAudioTypeName(EnumAudioType audioType);

        EnumAudioType GetAudioTypeByName(string name);

        string GetAudioExtension(EnumAudioType audioType);

        List<EnumAudioType> GetBluRayAudioTypes();
    }
}

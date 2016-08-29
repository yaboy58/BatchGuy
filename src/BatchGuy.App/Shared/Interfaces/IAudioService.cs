using BatchGuy.App.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Shared.Interfaces
{
    public interface IAudioService
    {
        string GetAudioTypeName(EnumAudioType audioType);

        EnumAudioType GetAudioTypeByName(string name);

        string GetAudioExtension(EnumAudioType audioType);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.MKVMerge.Interfaces
{
    public interface IMKVMergeOutputService
    {
        string GetMKVMergePathPart();
        string GetOutputPart();
        string GetChapterStreamPart();
        string GetVideoPart();
        string GetAudioStreamPart();
        string GetSubtitleStreamPart();
        string GetTrackOrderPart();
    }
}

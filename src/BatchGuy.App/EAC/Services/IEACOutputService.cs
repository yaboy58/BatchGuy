using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.EAC.Services
{
    public interface IEACOutputService
    {
        string GetEAC3ToPathPart();
        string GetBluRayStreamPart();
        string GetChapterStreamPart();
        string GetMovieStreamPart();
        string GetAudioStreamPart();
        string GetSubtitleStreamPart();
    }
}

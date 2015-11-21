using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Enums
{
    public enum EnumEncodeType
    {
        CRF = 1,
        TwoPass = 2
    }

    public enum EnumAudioType
    {
        DTS = 1,
        AC3 = 2,
        FLAC = 3,
        TrueHD = 4,
        MPA = 5,
        DTSMA = 6
    }

    public enum EnumBluRayLineItemType
    {
        BluRaySummaryHeaderLine = 1,
        BluRaySummaryDetailLine = 2,
        BluRaySummaryEmptyLine = 3,
        BluRayTitleHeaderLine = 4,
        BluRayTitleEmptyLine = 5,
        BluRayTitleChapterLine = 6,
        BluRayTitleVideoLine = 7,
        BluRayTitleAudioLine = 8,
        BluRayTitleSubtitleLine = 9,
        BluRayError = 10
    }

    public enum EnumSortDirection
    {
        Asc = 1, 
        Desc =2
    }

    public enum EnumDirectoryType
    {
        SingleDirectory = 1,
        DirectoryPerEpisode = 2
    }

    public enum EnumX264LogLineItemType
    {
        IFrame = 1,
        PFrame = 2,
        BFrame = 3,
        ConsecutiveBFrames = 4,
        EncodedFrames = 5,
        None = 6
    }
}

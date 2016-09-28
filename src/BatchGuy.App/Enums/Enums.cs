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
        DTSMA = 6,
        LPCM = 7
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

    public enum EnumEAC3ToNamingConventionType
    {
        EncodeNamingConventionTemplate1 = 1, //video##
        RemuxNamingConventionTemplate1 = 2, //TV Show S01E01 Episode Name 1080p Remux AVC FLAC5.1-Tag.mkv
        RemuxNamingConventionTemplate2 = 3, //TV Show, S01E01 (Year).mkv
        RemuxNamingConventionTemplate3 = 4,  //2x01 Episode Name.mkv
        MovieRemuxNamingConventionTemplate1 = 5 //movie remux
    }
}

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
        TrueHD = 4
    }

    public enum EnumLineItemType
    {
        BluRaySummaryHeaderLine = 1,
        BluRaySummaryDetailLine = 2,
        BluRaySummaryEmptyLine = 3
    }
}

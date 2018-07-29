using BatchGuy.App.Enums;

namespace BatchGuy.App.X264.Models
{
    public class X264FileSettings
    {
        public string vfw4x264Exe { get; set; }
        public EnumEncodeType EncodeType { get; set; }
        public string X264Template { get; set; }
        public string X264BatchFilePath { get; set; }
        public string X264EncodeAndLogFileOutputDirectoryPath { get; set; }
        public EnumDirectoryType X264EncodeAndLogFileOutputDirectoryPathType { get; set; }
        public bool SaveX264LogFileToDifferentDirectory { get; set; }
        public string X264LogFileOutputDirectoryPath { get; set; }

    }
}

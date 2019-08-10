using BatchGuy.App.Enums;
using BatchGuy.App.MKVMerge.Models;
using BatchGuy.App.Extensions;

namespace BatchGuy.App.Parser.Models
{
    public class BluRayTitleAudio
    {
        private int _idNumber;
        public string Id { get; set; }
        public EnumAudioType AudioType { get; set; }
        public string Language { get; set; }
        public string Arguments { get; set; }
        public bool IsSelected { get; set; }
        public string Text { get; set; }
        public bool IsCommentary { get; set; }
        public MKVMergeItem MKVMergeItem { get; set; }
        public EnumAudioType OriginalAudioType { get; set; }
        public bool IsLossless { get; set; }
        public int IdNumber
        {
            get
            {
                if (_idNumber > 0)
                    return _idNumber;
                if (string.IsNullOrEmpty(Id) == true)
                    return _idNumber;

                _idNumber = Id.RemoveColons().StringToInt();
                return _idNumber;
            }
        }
    }
}

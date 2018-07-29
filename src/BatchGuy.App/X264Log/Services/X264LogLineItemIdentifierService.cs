using BatchGuy.App.Enums;
using BatchGuy.App.X264Log.Interfaces;

namespace BatchGuy.App.X264Log.Services
{
    public class X264LogLineItemIdentifierService : IX264LogLineItemIdentifierService
    {
        public EnumX264LogLineItemType GetLineItemType(string lineItem)
        {
            if (this.IsIFrame(lineItem))
                return EnumX264LogLineItemType.IFrame;
            if (this.IsPFrame(lineItem))
                return EnumX264LogLineItemType.PFrame;
            if (this.IsBFrame(lineItem))
                return EnumX264LogLineItemType.BFrame;
            if (this.IsConsecutiveBFrames(lineItem))
                return EnumX264LogLineItemType.ConsecutiveBFrames;
            if (this.IsEncodeFrames(lineItem))
                return EnumX264LogLineItemType.EncodedFrames;

            return EnumX264LogLineItemType.None;
        }

        private bool IsIFrame(string lineItem)
        {
            if (lineItem.Contains("frame I"))
                return true;
            else
                return false;
        }

        private bool IsPFrame(string lineItem)
        {
            if (lineItem.Contains("frame P"))
                return true;
            else
                return false;
        }

        private bool IsBFrame(string lineItem)
        {
            if (lineItem.Contains("frame B"))
                return true;
            else
                return false;
        }

        private bool IsConsecutiveBFrames(string lineItem)
        {
            if (lineItem.Contains("consecutive B-frames"))
                return true;
            else
                return false;
        }

        private bool IsEncodeFrames(string lineItem)
        {
            if (lineItem.Contains("encoded"))
                return true;
            else
                return false;
        }
    }
}

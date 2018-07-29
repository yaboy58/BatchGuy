using BatchGuy.App.Enums;

namespace BatchGuy.App.X264Log.Interfaces
{
    public interface IX264LogLineItemIdentifierService
    {
        EnumX264LogLineItemType GetLineItemType(string lineItem);
    }
}

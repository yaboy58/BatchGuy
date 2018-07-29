using BatchGuy.App.Enums;
using BatchGuy.App.Parser.Models;

namespace BatchGuy.App.Parser.Interfaces
{
    public interface ILineItemIdentifierService
    {
        EnumBluRayLineItemType GetLineItemType(ProcessOutputLineItem processOutputLineItem);
    }
}

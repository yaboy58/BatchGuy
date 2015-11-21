using BatchGuy.App.Enums;
using BatchGuy.App.Parser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Parser.Interfaces
{
    public interface ILineItemIdentifierService
    {
        EnumBluRayLineItemType GetLineItemType(ProcessOutputLineItem processOutputLineItem);
    }
}

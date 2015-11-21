using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Enums;

namespace BatchGuy.App.X264Log.Interfaces
{
    public interface IX264LogLineItemIdentifierService
    {
        EnumX264LogLineItemType GetLineItemType(string lineItem);
    }
}

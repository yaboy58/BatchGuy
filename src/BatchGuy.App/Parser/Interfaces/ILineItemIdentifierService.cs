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
        EnumLineItemType GetLineItemType(ProcessOutputLineItem processOutputLineItem);
    }
}

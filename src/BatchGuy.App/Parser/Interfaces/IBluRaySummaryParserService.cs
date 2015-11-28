using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Parser.Interfaces
{
    public interface IBluRaySummaryParserService
    {
        ErrorCollection Errors { get; }
        List<BluRaySummaryInfo> GetSummaryList();
        string GetId(ProcessOutputLineItem lineItem);
        string RemoveEac3ToIdFromHeaderLineItem(ProcessOutputLineItem lineItem);
    }
}

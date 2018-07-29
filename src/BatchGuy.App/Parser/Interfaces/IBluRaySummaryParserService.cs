using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Models;
using System.Collections.Generic;

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

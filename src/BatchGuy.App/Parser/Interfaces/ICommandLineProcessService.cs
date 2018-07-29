using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Models;
using System.Collections.Generic;

namespace BatchGuy.App.Parser.Interfaces
{
    public interface ICommandLineProcessService
    {
        ErrorCollection Errors { get;}
        List<ProcessOutputLineItem> GetProcessOutputLineItems();
    }
}

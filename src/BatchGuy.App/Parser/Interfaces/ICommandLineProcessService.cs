using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Parser.Interfaces
{
    public interface ICommandLineProcessService
    {
        List<Error> Errors { get;}
        List<ProcessOutputLineItem> GetProcessOutputLineItems();
    }
}

using BatchGuy.App.Models;
using BatchGuy.App.Parser.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Parser.Services
{
    public interface ICommandLineProcessService
    {
        List<Error> Errors { get;}
        List<ProcessOutputLineItem> GetProcessOutputLineItems();
    }
}

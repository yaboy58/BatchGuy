using BatchGuy.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Parser.Services
{
    public interface ICommandLineProcessService
    {
        List<Error> CheckErrors();
    }
}

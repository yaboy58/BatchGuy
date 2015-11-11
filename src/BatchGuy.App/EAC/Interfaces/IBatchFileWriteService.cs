using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.EAC.Models;
using BatchGuy.App.Shared.Models;

namespace BatchGuy.App.EAC.Interfaces
{
    public interface IBatchFileWriteService
    {
        List<Error> Errors { get;}
        List<Error> Write();
        bool IsValid();
    }
}

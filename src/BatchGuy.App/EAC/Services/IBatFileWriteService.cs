using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.EAC.Models;
using BatchGuy.App.Models;

namespace BatchGuy.App.EAC.Services
{
    public interface IBatFileWriteService
    {
        List<Error> Write();
    }
}

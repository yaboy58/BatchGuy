using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Eac3To.Interfaces
{
    public interface IEAC3ToBatchFileWriteWarningService
    {
        WarningCollection GetWarnings();
    }
}

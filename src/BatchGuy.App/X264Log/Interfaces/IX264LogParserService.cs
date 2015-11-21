using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Shared;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.X264Log.Models;

namespace BatchGuy.App.X264Log.Interfaces
{
    public interface IX264LogParserService
    {
        ErrorCollection Errors { get; }
        string Logs { get; }
        string GetLogs();
    }
}

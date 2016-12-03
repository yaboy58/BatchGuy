using BatchGuy.App.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Shared.Interfaces
{
    public interface IDisplayErrorMessageService
    {
        void LogAndDisplayError(ErrorMessage message);
        void DisplayError(ErrorMessage message);
    }
}

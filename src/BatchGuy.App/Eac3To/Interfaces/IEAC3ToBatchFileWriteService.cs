using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Shared.Models;

namespace BatchGuy.App.Eac3To.Interfaces
{
    public interface IEAC3ToBatchFileWriteService
    {
        ErrorCollection Errors { get;}
        ErrorCollection Write();
        bool IsValid();
        void Delete();
    }
}

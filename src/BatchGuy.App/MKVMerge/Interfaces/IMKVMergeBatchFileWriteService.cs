using BatchGuy.App.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.MKVMerge.Interfaces
{
    public interface IMKVMergeBatchFileWriteService
    {
        ErrorCollection Errors { get; }
        ErrorCollection Write();
        bool IsValid();
        void Delete();
    }
}

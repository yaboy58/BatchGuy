using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.AVS;
using BatchGuy.App.AVS.Models;

namespace BatchGuy.App.AVS.Services
{
    public interface IFileService
    {
        List<AVSFile> CreateAVSFileList();
    }
}

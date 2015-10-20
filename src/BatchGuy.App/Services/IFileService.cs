using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Models;

namespace BatchGuy.App.Services
{
    public interface IFileService
    {
        List<AVSFile> CreateAVSFileList();
    }
}

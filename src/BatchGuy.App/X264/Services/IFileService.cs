using BatchGuy.App.X264.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.X264.Services
{
    public interface IFileService
    {
        List<X264File> GetAVSFiles();
    }
}

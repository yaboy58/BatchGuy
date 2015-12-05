using BatchGuy.App.Eac3To.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Eac3To.Services
{
    public class DirectorySystemService : IDirectorySystemService
    {
        public bool Exists(string path)
        {
            return Directory.Exists(path);
        }
    }
}

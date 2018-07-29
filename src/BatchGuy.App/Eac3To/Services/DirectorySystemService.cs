using BatchGuy.App.Eac3To.Interfaces;
using System.IO;

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

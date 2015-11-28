using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Shared.Events
{
    public class DialogInitialDirectoryChangedEventArgs : EventArgs
    {
        public string  FeatureName { get; set; }
        public string DirectoryPath { get; set; }
    }
}

using System;

namespace BatchGuy.App.Shared.Events
{
    public class DialogInitialDirectoryChangedEventArgs : EventArgs
    {
        public string  FeatureName { get; set; }
        public string DirectoryPath { get; set; }
    }
}

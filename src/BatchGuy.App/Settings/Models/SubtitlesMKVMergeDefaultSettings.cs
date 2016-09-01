using BatchGuy.App.MKVMerge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Settings.Models
{
    public class SubtitlesMKVMergeDefaultSettings
    {
        public bool SubtitleLanguageAlwaysSelectedEnabled { get; set; }
        public MKVMergeItem DefaultMKVMergeItem { get; set; }
    }
}

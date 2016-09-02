using BatchGuy.App.MKVMerge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Settings.Models
{
    public class AudioMKVMergeDefaultSettings
    {
        public MKVMergeItem DefaultMKVMergeItem { get; set; }

        public string AudioTypeFilterCriteria { get; set; }
    }
}

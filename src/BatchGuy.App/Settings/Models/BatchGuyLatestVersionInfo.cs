using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Settings.Models
{
    public class BatchGuyLatestVersionInfo
    {
        public string TagName { get; set; }
        public bool IsNewVersion { get; set; }
        public string LatestGithubUrl { get; set; }
    }
}

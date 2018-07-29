namespace BatchGuy.App.Settings.Models
{
    public class BatchGuyLatestVersionInfo
    {
        public string TagName { get; set; }
        public bool IsNewVersion { get; set; }
        public string LatestGithubUrl { get; set; }
        public string Name { get; set; }
    }
}

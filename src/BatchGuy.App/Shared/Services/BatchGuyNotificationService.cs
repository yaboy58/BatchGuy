using BatchGuy.App.Settings.Models;
using BatchGuy.App.Shared.Interfaces;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Shared.Services
{
    internal class BatchGuyNotificationService : IBatchGuyNotificationService
    {
        private string _currentTagName = string.Empty;
        private BatchGuyLatestVersionInfo _batchGuyLatestVersionSettings;

        public BatchGuyNotificationService(string currentTagName)
        {
            _currentTagName = currentTagName;
            _batchGuyLatestVersionSettings = null;
        }
        public BatchGuyLatestVersionInfo GetLatestVersionInfo()
        {
            this.ContactGithubLatestReleaseApi().Wait();
            return _batchGuyLatestVersionSettings;
        }

        private async Task ContactGithubLatestReleaseApi()
        {
            string latestTag = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("User-Agent","BatchGuy");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("https://api.github.com/repos/yaboy58/batchguy/releases/latest");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    JObject token = JObject.Parse(json);
                    var tagName = token.SelectToken("tag_name");
                    var url = token.SelectToken("url");

                    _batchGuyLatestVersionSettings = new BatchGuyLatestVersionInfo() { LatestGithubUrl = url == null ? string.Empty : url.ToString(),
                     TagName = tagName == null ? string.Empty : tagName.ToString()};

                    if (tagName != null && string.IsNullOrEmpty(tagName.ToString()) == false)
                    {
                        if (tagName.ToString() != _currentTagName)
                            _batchGuyLatestVersionSettings.IsNewVersion = true;
                        else
                            _batchGuyLatestVersionSettings.IsNewVersion = false;
                    }
                    else
                        _batchGuyLatestVersionSettings.IsNewVersion = false;
                }
            }
        }
    }
}

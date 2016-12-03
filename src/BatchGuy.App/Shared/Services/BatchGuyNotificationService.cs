using BatchGuy.App.Settings.Models;
using BatchGuy.App.Shared.Interfaces;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Shared.Services
{
    internal class BatchGuyNotificationService : IBatchGuyNotificationService
    {
        private string _currentTagName = string.Empty;
        private ILoggingService _loggingService;

        public BatchGuyNotificationService(string currentTagName, ILoggingService loggingService)
        {
            _currentTagName = currentTagName;
            _loggingService = loggingService;
        }
        public async Task<BatchGuyLatestVersionInfo> GetLatestVersionInfo()
        {
            var task = await this.ContactGithubLatestReleaseApi();
            

            return task;
        }

        private async Task<BatchGuyLatestVersionInfo> ContactGithubLatestReleaseApi()
        {
            BatchGuyLatestVersionInfo batchGuyLatestVersionSettings = null;
            string latestTag = string.Empty;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Add("User-Agent", "BatchGuy");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync("https://api.github.com/repos/yaboy58/batchguy/releases/latest");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        JObject token = JObject.Parse(json);
                        var tagName = token.SelectToken("tag_name");
                        var htmlUrl = token.SelectToken("html_url");
                        var name = token.SelectToken("name");

                        batchGuyLatestVersionSettings = new BatchGuyLatestVersionInfo()
                        {
                            LatestGithubUrl = htmlUrl == null ? string.Empty : htmlUrl.ToString(),
                            TagName = tagName == null ? string.Empty : tagName.ToString(),
                            Name = name == null ? string.Empty : name.ToString()
                        };

                        if (tagName != null && string.IsNullOrEmpty(tagName.ToString()) == false)
                        {
                            if (tagName.ToString() != _currentTagName)
                                batchGuyLatestVersionSettings.IsNewVersion = true;
                            else
                                batchGuyLatestVersionSettings.IsNewVersion = false;
                        }
                        else
                            batchGuyLatestVersionSettings.IsNewVersion = false;
                    }
                }
            }
            catch (Exception ex)
            {
                _loggingService.LogErrorFormat(ex, MethodBase.GetCurrentMethod().Name);
            }
            return batchGuyLatestVersionSettings;
        }
    }
}

using BatchGuy.App.Shared.Interfaces;
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
        public void CheckForNewVersion()
        {
            this.ContactGithubLatestReleaseApi(); //asynchronous call
        }

        private async Task ContactGithubLatestReleaseApi()
        {
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
                }
            }
        }
    }
}

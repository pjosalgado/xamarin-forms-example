using System;

using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace GitHubApiAppCore
{
    public class GitHubApi
    {
        
        public async Task<List<string>> GetAsync(string user)
        {
            string url = "https://api.github.com/users/" + user + "/repos";

            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Other");

            var respose = await client.GetAsync(url);
            var content = await respose.Content.ReadAsStringAsync();

            var json = JArray.Parse(content);

            var repositories = new List<string>();
            foreach (var item in json) {
                var repository = item.Value<string>("full_name");
                repositories.Add(repository);
            }

            return repositories;
        }

    }
}

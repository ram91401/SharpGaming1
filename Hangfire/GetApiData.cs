using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Hangfire
{
    public class GetApiData
    {
        public async Task<string> GetApiAsync(string url)
        {
            string result = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55587/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method
                HttpResponseMessage response = await client.GetAsync("http://affiliate-feed.petfre.sgp.bet/1/sports?languageCode=en");
                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();                  
                }
                return result;
            }
        }
    }
}
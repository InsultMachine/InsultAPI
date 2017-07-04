using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class ApiProxy
    {
        public static string GetAllUrl = "http://insultmachineapi.azurewebsites.net/insult/getall";
        private HttpClient client;
        
        public ApiProxy()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

        public async Task<string> SendGetAllRequest()
        {
            var result = await SendGetRequest(GetAllUrl);
            return result;
        }

        private async Task<string> SendGetRequest(string url)
        {
            var uri = new Uri(string.Format(GetAllUrl, string.Empty));
            var response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return content;
            }
            return null;
        }
    }
}

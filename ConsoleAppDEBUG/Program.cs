using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

using Data.Models;
using Newtonsoft.Json.Linq;

namespace ConsoleAppDEBUG
{
    public class Program
    {
        //  https://docs.microsoft.com/en-us/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client
        private static HttpClient _httpClient = new HttpClient();            // only create one (!)
        private static string _apiURL = @"http://insultmachineapi.azurewebsites.net/insult/getall/";

        public static void Main()
        {

            RunAsync().Wait();
        }

        static async Task RunAsync()
        {
            _httpClient.BaseAddress = new Uri(_apiURL);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await _httpClient.GetAsync(_apiURL);
            if (response.IsSuccessStatusCode)
            {
                string temp = await response.Content.ReadAsStringAsync();
            }

            Console.ReadLine();
            
        }
    }
}
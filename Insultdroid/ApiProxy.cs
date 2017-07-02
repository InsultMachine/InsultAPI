using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Insultdroid
{

    //  used to generate http request to api
    //  returns results as strings
    //  result handling should be kept out of this class
    public class ApiProxy
    {
        public static string GetAll = "http://insultmachineapi.azurewebsites.net/insult/getall";

        public static async Task<string> SendGetAllRequest()
        {
            var result = await SendGetRequest(GetAll);
            return result;
        }

        private static async Task<string> SendGetRequest(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";

            // Send the request to the server and wait for the response:
            using (var response = await request.GetResponseAsync())
            {
                var encoding = Encoding.ASCII;
                using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
                {
                    string responseText = reader.ReadToEnd();

                    Console.WriteLine("DEBUG:");
                    Console.WriteLine("URL:      " + url);
                    Console.WriteLine("RESULT:   " + responseText);

                    return responseText;
                }

            }
        }


    }
}
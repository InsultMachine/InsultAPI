using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Insultdroid
{
    //  used to maniuplate insult objects recieved from ApiProxy (or to send them via ApiProxy)
    //  parses strings into jsons, etc
    public class InsultHandler
    {
        public static async Task<string> GetAll()
        {
            var allInsultsString = await ApiProxy.SendGetAllRequest();
            // TODO

            JObject json = JObject.Parse(allInsultsString);


            return allInsultsString;
        }
    }
}
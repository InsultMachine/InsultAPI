using System.Threading.Tasks;
using Org.Json;

namespace Insultdroid
{
    //  used to maniuplate insult objects recieved from ApiProxy (or to send them via ApiProxy)
    //  parses strings into jsons, etc
    public class InsultHandler
    {
        public static async Task<JSONArray> GetAll()
        {
            var allInsultsString = await ApiProxy.SendGetAllRequest();
            
            var json = new JSONArray(allInsultsString);

            return json;
        }
    }
}
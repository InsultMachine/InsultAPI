using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace App1
{
    //  used to maniuplate insult objects recieved from ApiProxy (or to send them via ApiProxy)
    //  parses strings into jsons, etc
    public class InsultHandler
    {
        private ApiProxy _apiProxy;

        public InsultHandler(ApiProxy apiProxy)
        {
            _apiProxy = apiProxy;
        }

        public async Task<JObject> GetAll()
        {
            var jsonString = Task.Run(async () => await _apiProxy.SendGetAllRequest()).Result;
            var responceObj = jsonString;
            var resultObj = responceObj;
            var jsonObj = JObject.Parse(resultObj);
            return jsonObj;
        }
    }
}
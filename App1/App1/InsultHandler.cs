using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

using Mobile.Models;
using Newtonsoft.Json;

namespace App1
{
    //  used to maniuplate insult objects recieved from ApiProxy (or to send them via ApiProxy)
    //  parses strings into jsons, etc
    public class InsultHandler
    {
        private readonly ApiProxy _apiProxy;

        public InsultHandler(ApiProxy apiProxy)
        {
            _apiProxy = apiProxy;
        }

        public List<Insult> GetAll()
        {
            var jsonString = Task.Run(async () => await _apiProxy.SendGetAllRequest()).Result;
            var res = JsonConvert.DeserializeObject<List<Insult>>(jsonString);
            return res;
        }
    }
}
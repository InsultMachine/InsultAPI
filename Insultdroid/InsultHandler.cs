using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Org.Json;

namespace Insultdroid
{
    //  used to maniuplate insult objects recieved from ApiProxy (or to send them via ApiProxy)
    //  parses strings into jsons, etc
    public class InsultHandler
    {
        public static async Task<JSONObject> GetAll()
        {
            var allInsultsString = await ApiProxy.SendGetAllRequest();
            // TODO
            return null;
        }
    }
}
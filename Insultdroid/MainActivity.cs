using System;
using System.Threading.Tasks;
using Android.App;
using Android.Widget;
using Android.OS;
using Org.Json;

namespace Insultdroid
{
    [Activity(Label = "Insultdroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            var btnGetAll = FindViewById<Button>(Resource.Id.btnGetAll);
            var txtResult = FindViewById<TextView>(Resource.Id.txtTempView);

            //  get all insults from api for init
            var initialResult = Task.Run(async () => await InsultHandler.GetAll()).Result;
            JSONArray temp = initialResult;
            var first = temp.GetJSONObject(5);
            var insultId = first.GetInt("InsultId");
            var insultText = first.GetString("Text");
            var insultRating = first.GetInt("Rating");

            txtResult.Text = insultText;

            btnGetAll.Click += async (sender, e) =>
            {
                var result = await InsultHandler.GetAll();
                txtResult.Text = result.ToString();
            };
        }
    }
}


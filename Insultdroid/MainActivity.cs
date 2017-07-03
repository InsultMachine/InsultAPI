using System.Threading.Tasks;
using Android.App;
using Android.Widget;
using Android.OS;

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
            txtResult.Text = initialResult;

            btnGetAll.Click += async (sender, e) =>
            {
                var result = await InsultHandler.GetAll();
                txtResult.Text = result.ToString();
            };
        }
    }
}


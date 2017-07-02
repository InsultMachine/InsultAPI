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
            
            btnGetAll.Click += async (sender, e) =>
            {
                var result = await InsultHandler.GetAll();
                txtResult.Text = result.ToString();
            };
        }
    }
}


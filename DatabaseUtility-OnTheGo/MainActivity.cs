using Android.App;
using Android.Widget;
using Android.OS;
using System.Json;
using System.Net.Http;

namespace DatabaseUtility_OnTheGo
{
    [Activity(Label = "DatabaseUtility_OnTheGo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
            SetContentView(Resource.Layout.Home);
            //
            Button scriptGenerator = FindViewById<Button>(Resource.Id.button1);
            //
            scriptGenerator.Click += delegate { StartActivity(typeof(ScriptGeneratorActivity)); };
        }
    }
}


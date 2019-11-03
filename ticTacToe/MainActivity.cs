using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace ticTacToe
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource 
            SetContentView(Resource.Layout.activity_main);
            var btnPlay = FindViewById<Button>(Resource.Id.btnPlay);
            btnPlay.Click += (sender, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(layout1));
                StartActivity(nextActivity);
            };

            var btnExit = FindViewById<Button>(Resource.Id.btnExit);
            btnExit.Click += (sender, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(layout3));
                StartActivity(nextActivity);
            };
        }
    }
}
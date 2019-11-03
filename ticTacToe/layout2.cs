using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ticTacToe
{
    [Activity(Label = "layout2")]
    public class layout2 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout2);
            // Create your application here
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
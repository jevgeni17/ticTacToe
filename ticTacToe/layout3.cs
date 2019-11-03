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
    [Activity(Label = "layout3")]
    public class layout3 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.layout3);
            var btnPlay = FindViewById<Button>(Resource.Id.btnPlay);
            btnPlay.Click += (sender, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(layout1));
                StartActivity(nextActivity);
            };
        }
    }
}
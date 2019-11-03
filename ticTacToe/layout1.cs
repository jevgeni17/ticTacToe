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
    [Activity(Label = "layout1")]
    public class layout1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.layout1);
            var buttons = new[] { Resource.Id.button1,
                                  Resource.Id.button2,
                                  Resource.Id.button3,
                                  Resource.Id.button4,
                                  Resource.Id.button5,
                                  Resource.Id.button6,
                                  Resource.Id.button7,
                                  Resource.Id.button8,
                                  Resource.Id.button9}.Select(b => FindViewById<Button>(b)).ToList();


            bool hod = true;
            int hod_count = 0;
            void buttonHandler(object sender, EventArgs e)
            {

                Button clicked = sender as Button;
                if (hod)
                {
                    clicked.Text = "X";
                }
                else
                {
                    clicked.Text = "O";
                }
                hod = !hod;
                hod_count++;
                clicked.Enabled = false;
                checkWin();
            }


            for (var i = 0; i < 9; i++)
            {
                buttons[i].Click += new EventHandler(buttonHandler);
            }

            void checkWin()
            {
                bool winner = false;
                if ((buttons[0].Text == buttons[1].Text) && (buttons[1].Text == buttons[2].Text) && (!buttons[0].Enabled))
                {
                    winner = true;
                }
                if ((buttons[3].Text == buttons[4].Text) && (buttons[4].Text == buttons[5].Text) && (!buttons[3].Enabled))
                {
                    winner = true;
                }
                if ((buttons[6].Text == buttons[7].Text) && (buttons[7].Text == buttons[8].Text) && (!buttons[6].Enabled))
                {
                    winner = true;
                }
                if ((buttons[0].Text == buttons[3].Text) && (buttons[3].Text == buttons[6].Text) && (!buttons[0].Enabled))
                {
                    winner = true;
                }
                if ((buttons[1].Text == buttons[4].Text) && (buttons[4].Text == buttons[7].Text) && (!buttons[1].Enabled))
                {
                    winner = true;
                }
                if ((buttons[2].Text == buttons[5].Text) && (buttons[5].Text == buttons[8].Text) && (!buttons[2].Enabled))
                {
                    winner = true;
                }
                if ((buttons[0].Text == buttons[4].Text) && (buttons[4].Text == buttons[8].Text) && (!buttons[0].Enabled))
                {
                    winner = true;
                }
                if ((buttons[2].Text == buttons[4].Text) && (buttons[4].Text == buttons[6].Text) && (!buttons[2].Enabled))
                {
                    winner = true;
                }
                if (winner == true)
                {
                    Intent nextActivity = new Intent(this, typeof(layout2));
                    StartActivity(nextActivity);
                    string win = "";
                    if (hod)
                        win = "O";
                    else
                        win = "X";
                    var txt = FindViewById<TextView>(Resource.Id.winnerLabel);
                    txt.Text = "Победил" + win;
                    hod_count = 0;
                    hod = true;
                }
                else
                {
                    if (hod_count == 9)
                    {
                        hod = true;
                        hod_count = 0;
                        Intent nextActivity = new Intent(this, typeof(layout2));
                        StartActivity(nextActivity);
                        var txt = FindViewById<TextView>(Resource.Id.winnerLabel);
                        txt.Text = "Ничья";
                    }
                }
            }




            var btnExit = FindViewById<Button>(Resource.Id.btnExit);
            btnExit.Click += (sender, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(layout3));
                StartActivity(nextActivity);
            };


            

        }
    }
}
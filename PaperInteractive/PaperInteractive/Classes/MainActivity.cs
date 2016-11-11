using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;
using PaperInteractive.Fragments;

namespace PaperInteractive
{
    [Activity(Label = "PaperInteractive", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            Button btn1 = FindViewById<Button>(Resource.Id.btnLibrary);
            Button btn2 = FindViewById<Button>(Resource.Id.btnMeeting);
            Button btnNewChild = FindViewById<Button>(Resource.Id.btnNewChild);

            TextView header = FindViewById<TextView>(Resource.Id.textHeader);

            header.Text = "Välkommen!";
            header.Gravity = Android.Views.GravityFlags.Center;

            btn2.Click += delegate
            {
                StartActivity(typeof(Activity1));
            };

            btnNewChild.Click += delegate
            {
                Fragment createChildFragment = new Fragment1();
                var fm = FragmentManager.BeginTransaction();
                fm.Add(Resource.Id.fragment_container, createChildFragment);
                fm.Commit();
            };
        }
    }
}


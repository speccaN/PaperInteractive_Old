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

            FragmentManager fm = FragmentManager;

            TextView header = FindViewById<TextView>(Resource.Id.textHeader);

            header.Text = "Välkommen Din Apa!";
            header.Gravity = Android.Views.GravityFlags.Center;

            btn2.Click += delegate
            {
                StartActivity(typeof(Activity1));
            };

            btnNewChild.Click += delegate
            {
                
                if (fm.BackStackEntryCount == 0)
                {
                    Fragment createChildFragment = new Fragment1();
                    FragmentTransaction ft = fm.BeginTransaction();
                    ft.Add(Resource.Id.fragment_container, createChildFragment);
                    ft.AddToBackStack("createChildFragment");
                    ft.Commit();
                }
            };
        }
    }
}


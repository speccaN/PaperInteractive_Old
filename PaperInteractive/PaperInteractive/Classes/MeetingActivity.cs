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

namespace PaperInteractive
{
    [Activity(Label = "Meeting")]
    public class MeetingActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.MeetingLayout);

            string[] goat = new string[] { "1", "2", "3" };

            Spinner spn = FindViewById<Spinner>(Resource.Id.spinner1);

            ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleSpinnerDropDownItem, goat);

            spn.Adapter = adapter;
        }
    }
}
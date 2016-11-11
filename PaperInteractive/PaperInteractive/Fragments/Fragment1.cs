using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace PaperInteractive.Fragments
{
    public class Fragment1 : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            var textToDisplay = new StringBuilder().Insert(0, "The quick brown fox jumps over the lazy dog. ", 450).ToString();
            var view = inflater.Inflate(Resource.Layout.ChildFragment, container, false);
            var textView = view.FindViewById<TextView>(Resource.Id.textView1);
            textView.Text = textToDisplay;

            return view;
            //return base.OnCreateView(inflater, container, savedInstanceState);
        }
    }
}
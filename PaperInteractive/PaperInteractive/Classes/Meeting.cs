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

namespace PaperInteractive.Classes
{
    public class Meeting
    {
        private int _ID;

        private DateTime _timeOfMeeting;

        private Parent _parent;
        private Child _child;
        private List<Exercise> _givenExercises;


        public Meeting()
        {
            _timeOfMeeting = DateTime.Now;
        }
        
    }
}
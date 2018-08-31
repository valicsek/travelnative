
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

namespace TravelNative.Droid
{
    [Activity(Label = "HomeActivity")]
    public class HomeActivity : Activity
    {
        string username;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.username = Intent.GetStringExtra("username");
            SetContentView(Resource.Layout.Home);
        }
    }
}

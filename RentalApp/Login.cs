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

namespace RentalApp
{
    [Activity(Label = "RentalApp")]
    class Login : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            TextView signup;
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Login);
            signup = FindViewById<TextView>(Resource.Id.textView3);
            signup.Click += delegate
            {
                var goToLogin = new Intent(this, typeof(Signup));

                StartActivity(goToLogin);
            };
        }
    }
}
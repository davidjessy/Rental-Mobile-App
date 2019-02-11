using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

using Android.Runtime;
using Android.Views;

namespace RentalApp
{
    [Activity(Label = "RentalApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            TextView renter;
            TextView user;
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            renter = FindViewById<TextView>(Resource.Id.textView3);
            user = FindViewById<TextView>(Resource.Id.textView4);
            renter.Click += delegate
            {
                var goToLogin = new Intent(this, typeof(Login));

                StartActivity(goToLogin);
            };
            user.Click += delegate
            {
                var goToLogin = new Intent(this, typeof(Login));

                StartActivity(goToLogin);
            };
        }
    }
    
}


using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Realms;
using Android.Runtime;
using Android.Views;

namespace RentalApp
{
    [Activity(Label = "RentalApp")]
    public class Signup : Activity
    {
        string[] myarray = { "Select Profile", "I am a Renter", "I am a User"};
        Realm myRealm;
        Button registerBtn;
        EditText email;
        EditText password;
        EditText firstname;
        EditText lastname;
        Spinner profile;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            myRealm = Realm.GetInstance();
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Register);
            var myspinner = FindViewById<Spinner>(Resource.Id.spinner1);
            var myadapter = new ArrayAdapter(this,Android.Resource.Layout.SimpleListItem1, myarray);
            myadapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            myspinner.Adapter = myadapter;

            //get the contents of the fields
            firstname = FindViewById<EditText>(Resource.Id.firstName_text);
            lastname = FindViewById<EditText>(Resource.Id.lastName_text);
            email = FindViewById<EditText>(Resource.Id.email_text);
            password = FindViewById<EditText>(Resource.Id.password_text);
            profile = FindViewById<Spinner>(Resource.Id.spinner1);
            registerBtn = FindViewById<Button>(Resource.Id.registerBtn);

            registerBtn.Click += delegate {

                var userModelOBj = new UserModel();
                userModelOBj.firstName = firstname.Text;
                userModelOBj.lastName = lastname.Text;
                userModelOBj.email = email.Text;
                userModelOBj.password = password.Text;
                userModelOBj.profile = profile.SelectedItem.ToString();

                myRealm.Write(() => {
                    myRealm.Add(userModelOBj);
                });

                var goToLogin = new Intent(this, typeof(Login));

                StartActivity(goToLogin);

            };
        }
    }
    
}


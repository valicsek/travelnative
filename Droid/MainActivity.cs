﻿using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace TravelNative.Droid
{
    [Activity(Label = "TravelNative", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        EditText usernameEditText, passwordEditText;
        Button loginButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            this.SetupViews();
        }

        void SetupViews()
        {
            this.usernameEditText = FindViewById<EditText>(Resource.Id.usernameEditText);
            this.passwordEditText = FindViewById<EditText>(Resource.Id.passwordEditText);
            this.loginButton = FindViewById<Button>(Resource.Id.loginButton);

            this.loginButton.Click += OnLoginButtonClicked;
        }

        void OnLoginButtonClicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(this.usernameEditText.Text) || string.IsNullOrEmpty(this.passwordEditText.Text))
            {
                Toast.MakeText(this, "Username or password is missing!", ToastLength.Long).Show();
            }
            else
            {
                if(this.usernameEditText.Text.ToLower() != "test")
                {
                    Toast.MakeText(this, "Username or password is not correct!", ToastLength.Long).Show();
                }
                else
                {
                    var intent = new Intent(this, typeof(HomeActivity));
                    // Send the username as well to the Activity
                    intent.PutExtra("username", this.usernameEditText.Text.ToLower());
                    StartActivity(intent);
                }

            }
        }

    }
}


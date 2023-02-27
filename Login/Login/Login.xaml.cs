using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Login
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        //Login
        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text.ToString()))
            {
                DisplayAlert("Alert", "Please enter username","OK");
                return;
            }
            if (string.IsNullOrEmpty(password.Text.ToString()))
            {
                DisplayAlert("Alert", "Please enter password", "OK");
                return;
            }
            if(username.Text.Equals("admin") && password.Text.Equals("admin"))
            {
                await Navigation.PushAsync(new Home());
            }
            else
            {
                await DisplayAlert("Alert", "Please check your credentials", "OK");
                return;

            }
        }
        //Register
        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }

        void Button_Clicked_2(System.Object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text))
            {
                DisplayAlert("Alert", "Please enter email", "OK");
                return;
            }
            else
            {
                DisplayAlert("Alert", "Password is sent to your email successfully", "OK");
            }
        }
    }
}


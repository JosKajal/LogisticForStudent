﻿using LogisticForStudent.ViewModels;
using LogisticForStudent.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LogisticForStudent.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            this.BindingContext = new LoginViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtPassword.Text == "123")
            {
                Navigation.PushAsync(new AboutPage());
            }
            else
            {
                DisplayAlert("Error", "Usuario o contraseña incorrecto", "Ok");

            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}
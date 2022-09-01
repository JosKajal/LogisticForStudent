using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LogisticForStudent.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync($"//{nameof(VistaReproductor)}");
        }
    }
}
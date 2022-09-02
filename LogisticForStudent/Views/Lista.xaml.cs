using LogisticForStudent.Models;
using LogisticForStudent.ViewModels;
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
    public partial class Lista : ContentPage
    {
        public Lista()
        {
            InitializeComponent();
            BindingContext = new ListaVista();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var mydetail = e.Item as VistaModelo;
            await Navigation.PushAsync(new Listadetalles(mydetail.Name, mydetail.Horarios, mydetail.Imagen, mydetail.Detail));
        }
    }
}
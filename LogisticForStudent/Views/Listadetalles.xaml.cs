using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LogisticForStudent.Views;
namespace LogisticForStudent.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listadetalles : ContentPage
    {
        public Listadetalles(string Name, string turnos, string source)
        {
            InitializeComponent();

            Item.Text = Name;
            HorariosShow.Text = turnos;
            MyImagencall.Source = new UriImageSource()
            {

                Uri = new Uri(source)
            };

        }
    }
}
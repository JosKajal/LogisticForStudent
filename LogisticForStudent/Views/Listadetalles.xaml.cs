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
        public Listadetalles(string Name, string turnos, string source, string detalles)
        {
            InitializeComponent();
            Title = Name;
            Detalles.Text = detalles;
            HorariosShow.Text = turnos;
            MyImagencall.Source = source;

        }
    }
}
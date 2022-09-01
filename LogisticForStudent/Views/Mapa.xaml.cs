using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

namespace LogisticForStudent.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mapa : ContentPage
    {
        public Mapa()
        {
            InitializeComponent();
            ListaTecs.ItemsSource = new List<String> { "Instituto Tecnologico de Nogales", "Instituto Tecnologico de Hermosillo" };
            MapView.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    new Position(31.291890, -110.952625), Distance.FromMiles(0.2)));            
            MapView.IsShowingUser = true;
        }
        private void Street_OnClicked(object sender, EventArgs e)
        {
            MapView.MapType = MapType.Street;
        }


        private void Hybrid_OnClicked(object sender, EventArgs e)
        {
            MapView.MapType = MapType.Hybrid;
        }

        private void Satellite_OnClicked(object sender, EventArgs e)
        {
            MapView.MapType = MapType.Satellite;
        }

        private void ListaTecs_ItemTapped(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void ListaTecs_SelectedIndexChanged(object sender, EventArgs e)
        {
            MapView.Pins.Clear();
            if (ListaTecs.SelectedIndex == 0)
            {
                Pin pin;
                MapView.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    new Position(31.291890, -110.952625), Distance.FromMiles(0.2)));
                pin = new Pin { Label = "Vinculacion", Position = new Position(31.290899, -110.951311) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio A", Position = new Position(31.292728, -110.955808) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio B", Position = new Position(31.29255, -110.95612) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio C", Position = new Position(31.292207984092002, -110.95608320223188) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio D", Position = new Position(31.292102550808668, -110.95555212484683) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio E", Position = new Position(31.292391346042976, -110.95554139601076) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio F", Position = new Position(31.29255637149392, -110.95529463278133) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio G", Position = new Position(31.29217131165899, -110.95509078489616) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio H", Position = new Position(31.291946692695575, -110.95469381796187) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio I", Position = new Position(31.292244656510718, -110.95465090261762) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio J", Position = new Position(31.29187793168139, -110.95499422537159) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio K", Position = new Position(31.29174957765408, -110.95466163145367) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio L", Position = new Position(31.292120887040337, -110.95427539335545) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio M", Position = new Position(31.291428691821135, -110.95393207060147) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio N", Position = new Position(31.29232716940072, -110.95378186689659) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio O", Position = new Position(31.29259304377012, -110.9531971453315) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio P", Position = new Position(31.292249240555098, -110.95288600908569) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio Q", Position = new Position(31.291978781144707, -110.95282163606933) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio R", Position = new Position(31.291767913947403, -110.95290746675782) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio S", Position = new Position(31.29163039160808, -110.95320787416756) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio T", Position = new Position(31.29125449619028, -110.95295038210207) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio U", Position = new Position(31.291098636675017, -110.95303621279055) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio V", Position = new Position(31.29101153859835, -110.95348682390517) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio W", Position = new Position(31.291034459152666, -110.95253732191368) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio X", Position = new Position(31.290507284981853, -110.95224227892237) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio Y", Position = new Position(31.291469948613127, -110.95197942243884) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio Z", Position = new Position(31.291630391595916, -110.95096018301295) };
                MapView.Pins.Add(pin);
                MapView.IsShowingUser = true;
            }
            if (ListaTecs.SelectedIndex == 1)
            {
                Pin pin;
                MapView.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    new Position(29.09930, -110.99725), Distance.FromMiles(0.2)));
                pin = new Pin { Label = "B2", Position = new Position(29.09768, -110.99844) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "L5", Position = new Position(29.09822, -110.99833) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "A8", Position = new Position(29.09865, -110.99836) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "A7", Position = new Position(29.09867, -110.99763) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "M1", Position = new Position(29.09829, -110.99769) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "B4", Position = new Position(29.09844, -110.99733) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "M2", Position = new Position(29.09814, -110.99757) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "A3", Position = new Position(29.09794, -110.99750) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "A4", Position = new Position(29.09774, -110.99750) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "A5", Position = new Position(29.09752, -110.99749) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "AG", Position = new Position(29.09868, -110.99711) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "G", Position = new Position(29.09867, -110.99683) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "A2", Position = new Position(29.09818, -110.99718) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "B1", Position = new Position(29.09785, -110.99696) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "C1", Position = new Position(29.09829, -110.99664) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "L3", Position = new Position(29.09862, -110.99600) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "D", Position = new Position(29.09811, -110.99598) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "J", Position = new Position(29.09788, -110.99629) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "A1", Position = new Position(29.09791, -110.99583) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "E", Position = new Position(29.09766, -110.99580) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "K", Position = new Position(29.09739, -110.99627) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "L2", Position = new Position(29.09831, -110.99545) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "L1", Position = new Position(29.09775, -110.99527) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "H", Position = new Position(29.09806, -110.99504) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "I", Position = new Position(29.09808, -110.99474) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "P1", Position = new Position(29.09904, -110.99514) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Gimnasio", Position = new Position(29.09953, -110.99722) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Alberca", Position = new Position(29.09967, -110.99677) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "C2", Position = new Position(29.09968, -110.99614) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "B5", Position = new Position(29.09990, -110.99579) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "B3", Position = new Position(29.09998, -110.99500) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "L6", Position = new Position(29.10039, -110.99498) };
                MapView.Pins.Add(pin);
            }
        }
    }
}
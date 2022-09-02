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
                ListaAulas.ItemsSource = new List<String> { "Vinculacion", "Edificio A", "Edificio B", "Edificio C", "Edificio D", "Edificio E", "Edificio F", "Edificio G", "Edificio H", "Edificio I", "Edificio J", "Edificio K", "Edificio L", "Edificio M", "Edificio N", "Edificio O", "Edificio P", "Edificio Q", "Edificio R", "Edificio S", "Edificio T", "Edificio U", "Edificio V", "Edificio W", "Edificio X", "Edificio Y", "Edificio Z" };
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
                ListaAulas.ItemsSource = new List<String> { "Edificio B2", "Edificio L5", "Edificio A8", "Edificio A7", "Edificio M1", "Edificio B4", "Edificio M2", "Edificio A3", "Edificio A4", "Edificio A5", "Edificio AG", "Edificio G", "Edificio A2", "Edificio B1", "Edificio C1", "Edificio L3", "Edificio D", "Edificio J", "Edificio A1", "Edificio E", "Edificio K", "Edificio L2", "Edificio L1", "Edificio H", "Edificio I", "Edificio P1", "Gimnasio", "Alberca", "Edificio C2", "Edificio B5", "Edificio B3", "Edificio L6" };
                Pin pin;
                MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09930, -110.99725), Distance.FromMiles(0.2)));
                pin = new Pin { Label = "Edificio B2", Position = new Position(29.09768, -110.99844) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio L5", Position = new Position(29.09822, -110.99833) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio A8", Position = new Position(29.09865, -110.99836) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio A7", Position = new Position(29.09867, -110.99763) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio M1", Position = new Position(29.09829, -110.99769) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio B4", Position = new Position(29.09844, -110.99733) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio M2", Position = new Position(29.09814, -110.99757) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio A3", Position = new Position(29.09794, -110.99750) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio A4", Position = new Position(29.09774, -110.99750) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio A5", Position = new Position(29.09752, -110.99749) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio AG", Position = new Position(29.09868, -110.99711) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio G", Position = new Position(29.09867, -110.99683) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio A2", Position = new Position(29.09818, -110.99718) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio B1", Position = new Position(29.09785, -110.99696) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio C1", Position = new Position(29.09829, -110.99664) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio L3", Position = new Position(29.09862, -110.99600) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio D", Position = new Position(29.09811, -110.99598) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio J", Position = new Position(29.09788, -110.99629) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio A1", Position = new Position(29.09791, -110.99583) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio E", Position = new Position(29.09766, -110.99580) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio K", Position = new Position(29.09739, -110.99627) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio L2", Position = new Position(29.09831, -110.99545) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio L1", Position = new Position(29.09775, -110.99527) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio H", Position = new Position(29.09806, -110.99504) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio I", Position = new Position(29.09808, -110.99474) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio P1", Position = new Position(29.09904, -110.99514) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Gimnasio", Position = new Position(29.09953, -110.99722) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Alberca", Position = new Position(29.09967, -110.99677) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio C2", Position = new Position(29.09968, -110.99614) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio B5", Position = new Position(29.09990, -110.99579) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio B3", Position = new Position(29.09998, -110.99500) };
                MapView.Pins.Add(pin);
                pin = new Pin { Label = "Edificio L6", Position = new Position(29.10039, -110.99498) };
                MapView.Pins.Add(pin);

            }
        }

        private void ListaAulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaTecs.SelectedIndex == 0)
            {
                MapView.Pins.Clear();
                Pin pin;
                if (ListaAulas.SelectedIndex == 0)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.290899, -110.951311), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Vinculacion", Position = new Position(31.290899, -110.951311) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 1)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.292728, -110.955808), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio A", Position = new Position(31.292728, -110.955808) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 2)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.29255, -110.95612), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio B", Position = new Position(31.29255, -110.95612) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 3)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.292207984092002, -110.95608320223188), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio C", Position = new Position(31.292207984092002, -110.95608320223188) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 4)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.292102550808668, -110.95555212484683), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio D", Position = new Position(31.292102550808668, -110.95555212484683) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 5)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.292391346042976, -110.95554139601076), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio E", Position = new Position(31.292391346042976, -110.95554139601076) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 6)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.29255637149392, -110.95529463278133), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio F", Position = new Position(31.29255637149392, -110.95529463278133) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 7)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.29255637149392, -110.95529463278133), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio F", Position = new Position(31.29255637149392, -110.95529463278133) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 8)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.29217131165899, -110.95509078489616), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio G", Position = new Position(31.29217131165899, -110.95509078489616) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 9)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.291946692695575, -110.95469381796187), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio H", Position = new Position(31.291946692695575, -110.95469381796187) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 10)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.292244656510718, -110.95465090261762), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio I", Position = new Position(31.292244656510718, -110.95465090261762) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 11)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.29187793168139, -110.95499422537159), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio J", Position = new Position(31.29187793168139, -110.95499422537159) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 12)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.29174957765408, -110.95466163145367), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio K", Position = new Position(31.29174957765408, -110.95466163145367) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 13)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.292120887040337, -110.95427539335545), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio L", Position = new Position(31.292120887040337, -110.95427539335545) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 14)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.291428691821135, -110.95393207060147), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio M", Position = new Position(31.291428691821135, -110.95393207060147) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 15)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.29232716940072, -110.95378186689659), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio N", Position = new Position(31.29232716940072, -110.95378186689659) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 16)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.29259304377012, -110.9531971453315), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio O", Position = new Position(31.29259304377012, -110.9531971453315) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 17)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.292249240555098, -110.95288600908569), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio P", Position = new Position(31.292249240555098, -110.95288600908569) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 18)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.291978781144707, -110.95282163606933), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio Q", Position = new Position(31.291978781144707, -110.95282163606933) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 19)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.291767913947403, -110.95290746675782), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio R", Position = new Position(31.291767913947403, -110.95290746675782) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 20)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.29163039160808, -110.95320787416756), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio S", Position = new Position(31.29163039160808, -110.95320787416756) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 21)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.29125449619028, -110.95295038210207), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio T", Position = new Position(31.29125449619028, -110.95295038210207) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 22)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.291098636675017, -110.95303621279055), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio U", Position = new Position(31.291098636675017, -110.95303621279055) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 23)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.29101153859835, -110.95348682390517), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio V", Position = new Position(31.29101153859835, -110.95348682390517) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 24)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.291034459152666, -110.95253732191368), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio W", Position = new Position(31.291034459152666, -110.95253732191368) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 25)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.290507284981853, -110.95224227892237), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio X", Position = new Position(31.290507284981853, -110.95224227892237) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 26)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.291469948613127, -110.95197942243884), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio Y", Position = new Position(31.291469948613127, -110.95197942243884) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 27)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.291630391595916, -110.95096018301295), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio Z", Position = new Position(31.291630391595916, -110.95096018301295) };
                    MapView.Pins.Add(pin);
                }
            }
            if (ListaTecs.SelectedIndex == 1)
            {
                MapView.Pins.Clear();
                Pin pin;
                if (ListaAulas.SelectedIndex == 0)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09768, -110.99844), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio B2", Position = new Position(29.09768, -110.99844) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 1)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09822, -110.99833), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio L5", Position = new Position(29.09822, -110.99833) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 2)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09865, -110.99836), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio A8", Position = new Position(29.09865, -110.99836) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 3)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09867, -110.99763), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio A7", Position = new Position(29.09867, -110.99763) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 4)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09829, -110.99769), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio M1", Position = new Position(29.09829, -110.99769) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 5)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09844, -110.99733), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio B4", Position = new Position(29.09844, -110.99733) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 6)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09814, -110.99757), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio M2", Position = new Position(29.09814, -110.99757) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 7)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09794, -110.99750), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio A3", Position = new Position(29.09794, -110.99750) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 8)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09774, -110.99750), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio A4", Position = new Position(29.09774, -110.99750) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 9)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09752, -110.99749), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio A5", Position = new Position(29.09752, -110.99749) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 10)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09868, -110.99711), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio AG", Position = new Position(29.09868, -110.99711) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 11)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09867, -110.99683), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio G", Position = new Position(29.09867, -110.99683) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 12)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09818, -110.99718), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio A2", Position = new Position(29.09818, -110.99718) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 13)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09785, -110.99696), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio B1", Position = new Position(29.09785, -110.99696) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 14)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09829, -110.99664), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio C1", Position = new Position(29.09829, -110.99664) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 15)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09862, -110.99600), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio L3", Position = new Position(29.09862, -110.99600) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 16)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09811, -110.99598), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio D", Position = new Position(29.09811, -110.99598) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 17)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09788, -110.99629), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio J", Position = new Position(29.09788, -110.99629) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 18)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09791, -110.99583), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio A1", Position = new Position(29.09791, -110.99583) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 19)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09766, -110.99580), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio E", Position = new Position(29.09766, -110.99580) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 20)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09739, -110.99627), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio K", Position = new Position(29.09739, -110.99627) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 21)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09831, -110.99545), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio L2", Position = new Position(29.09831, -110.99545) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 22)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09775, -110.99527), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio L1", Position = new Position(29.09775, -110.99527) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 23)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09806, -110.99504), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio H", Position = new Position(29.09806, -110.99504) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 24)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09808, -110.99474), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio I", Position = new Position(29.09808, -110.99474) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 25)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09904, -110.99514), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio P1", Position = new Position(29.09904, -110.99514) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 26)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09953, -110.99722), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Gimnasio", Position = new Position(29.09953, -110.99722) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 27)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09967, -110.99677), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Alberca", Position = new Position(29.09967, -110.99677) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 28)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09968, -110.99614), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio C2", Position = new Position(29.09968, -110.99614) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 29)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09990, -110.99579), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio B5", Position = new Position(29.09990, -110.99579) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 30)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.09998, -110.99500), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio B3", Position = new Position(29.09998, -110.99500) };
                    MapView.Pins.Add(pin);
                }
                if (ListaAulas.SelectedIndex == 31)
                {
                    MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.10039, -110.99498), Distance.FromMiles(0.2)));
                    pin = new Pin { Label = "Edificio L6", Position = new Position(29.10039, -110.99498) };
                    MapView.Pins.Add(pin);
                }
            }
            else
            {

            }
        }
    }
}
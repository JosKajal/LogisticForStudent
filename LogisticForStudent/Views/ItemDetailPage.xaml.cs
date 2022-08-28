using LogisticForStudent.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LogisticForStudent.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
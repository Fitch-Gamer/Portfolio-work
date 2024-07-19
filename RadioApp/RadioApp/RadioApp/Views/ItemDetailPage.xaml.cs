using RadioApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace RadioApp.Views
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
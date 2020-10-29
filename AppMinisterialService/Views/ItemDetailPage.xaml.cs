using System.ComponentModel;
using Xamarin.Forms;
using AppMinisterialService.ViewModels;

namespace AppMinisterialService.Views
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
using System.ComponentModel;
using Xamarin.Forms;
using Proba.ViewModels;

namespace Proba.Views
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
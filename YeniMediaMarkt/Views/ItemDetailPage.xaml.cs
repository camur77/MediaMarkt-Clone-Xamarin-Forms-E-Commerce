using System.ComponentModel;
using Xamarin.Forms;
using YeniMediaMarkt.ViewModels;

namespace YeniMediaMarkt.Views
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
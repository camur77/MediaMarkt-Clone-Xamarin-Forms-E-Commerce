using YeniMediaMarkt.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

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
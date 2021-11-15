using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iPodMobileTerminals.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemListPage : ContentPage
    {
        public ItemListPage()
        {
            InitializeComponent();
        }
        private void Button_CategoryListonClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new CategoryListPage();
        }
        private void Button_SubItemListClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new SubItemListPage();
        }
    }
}
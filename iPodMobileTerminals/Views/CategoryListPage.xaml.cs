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
    public partial class CategoryListPage : ContentPage
    {
        public CategoryListPage()
        {
            InitializeComponent();
        }

        private void Button_RoomClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new RoomListPage();
        }
        private void Button_CategoryConfirmationClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new ItemListPage();
        }
    }
}
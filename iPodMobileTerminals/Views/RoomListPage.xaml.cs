using iPodMobileTerminals.Views;
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
    public partial class RoomListPage : ContentPage
    {
        public RoomListPage()
        {
            InitializeComponent();
        }
        public void Button_TopClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new OrderPage();
        }

        public void Button_NextClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new CategoryListPage();
        }

        public void Button_NewCustomer(object sender, EventArgs e)
        {
            App.Current.MainPage = new NewCustomerPage();
        }
    }
}
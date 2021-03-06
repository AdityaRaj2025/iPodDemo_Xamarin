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
    public partial class NewCustomerPage : ContentPage
    {
        public NewCustomerPage()
        {
            InitializeComponent();
            Navigation.PopAsync(true);
        }
        public void Button_TopClicked(object sender, EventArgs e)
        {
            // App.Current.MainPage = new OrderPage();
            Navigation.PushAsync(new OrderPage(), true);
        }

        public void Button_BackClicked(object sender, EventArgs e)
        {
            //App.Current.MainPage = new RoomListPage();
            Navigation.PushAsync(new RoomListPage(), true);
        }
    }
}
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
    public partial class OrderCompletedPage : ContentPage
    {
        public OrderCompletedPage()
        {
            InitializeComponent();
            Navigation.PopAsync(true);
        }

        private void Button_BackClicked(object sender, EventArgs e)
        {
            //App.Current.MainPage = new ClearOrderPage();
            Navigation.PushAsync(new ClearOrderPage(), true);
        }
        private void Button_TopClicked(object sender, EventArgs e)
        {
            //App.Current.MainPage = new NewCategoryPage();
            Navigation.PushAsync(new NewCustomerPage(), true);
        }
    }
}
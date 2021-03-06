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
    public partial class ClearOrderPage : ContentPage
    {
        public ClearOrderPage()
        {
            InitializeComponent();
            Navigation.PopAsync(true);
        }
        private void Button_NextClicked(object sender, EventArgs e)
        {
            //App.Current.MainPage = new OrderCompletedPage();
            Navigation.PushAsync(new OrderCompletedPage(), true);
        }
        private void Button_BackClicked(object sender, EventArgs e)
        {
            //App.Current.MainPage = new SubmitOrderPage();
            Navigation.PushAsync(new SubmitOrderPage(), true);
        }
    }
}
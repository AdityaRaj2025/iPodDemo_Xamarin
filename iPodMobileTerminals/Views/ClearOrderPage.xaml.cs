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
        }
        private void Button_NextClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new OrderCompletedPage();
        }
        private void Button_BackClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new SubmitOrderPage();
        }
    }
}
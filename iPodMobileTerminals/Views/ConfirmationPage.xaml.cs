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
    public partial class ConfirmationPage : ContentPage
    {
       

        public ConfirmationPage()
        {
            InitializeComponent();
        }
        private void ContinueClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new SubmitOrderPage();
        }

        private void BackClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new SubItemListPage();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            
        }
    }
}
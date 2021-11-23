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
            Navigation.PopAsync(true);
        }
        private void ContinueClicked(object sender, EventArgs e)
        {
            //App.Current.MainPage = new SubmitOrderPage();
            Navigation.PushAsync(new SubmitOrderPage(), true);
        }

        private void BackClicked(object sender, EventArgs e)
        {
            //App.Current.MainPage = new SubItemListPage();
            Navigation.PushAsync(new SubItemListPage(), true);
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
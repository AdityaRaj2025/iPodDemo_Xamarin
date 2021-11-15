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
    public partial class SubItemListPage : ContentPage
    {
        public SubItemListPage()
        {
            InitializeComponent();
        }

        private void Button_ConfirmClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new ConfirmationPage();
        }


    }
}
using iPodMobileTerminals.Models;
using iPodMobileTerminals.ViewModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iPodMobileTerminals.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();
            BindingContext = this;
            
        }       
        private void ShowButton_Clicked(object sender, EventArgs e)
        {
           
        }

        private void add(object sender,EventArgs e)
        {
            DisplayAlert("Ok", "Cancle", "Messgae");
        }
    }
}
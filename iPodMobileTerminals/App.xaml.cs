using iPodMobileTerminals.ViewModels;
using iPodMobileTerminals.Views;
using SQLite;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iPodMobileTerminals
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            SQLiteConnection con = DependencyService.Get<ISQLite>().GetConnectionWithDatabase();

            MainPage = new OrderPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

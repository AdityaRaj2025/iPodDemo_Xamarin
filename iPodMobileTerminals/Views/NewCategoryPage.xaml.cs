using iPodMobileTerminals.Models;
using iPodMobileTerminals.ViewModels;
using SQLite;
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
    public partial class NewCategoryPage : ContentPage
    {
      
        public NewCategoryPage()
        {
            InitializeComponent();
            
        }

        private void SaveRoomDetails(object sender, EventArgs e)
        {
            string roomCode =RoomCode.Text;
            string roomStatus =RoomStatus.Text;
           

            bool response= DependencyService.Get<ISQLite>().SaveRoomDetails(roomCode, roomStatus);
            if(response)
            {
                DisplayAlert("Message", "Data Successfully saved", "Ok");
                App.Current.MainPage = new TestPage();
            }
            else
            {
                DisplayAlert("Message", "Data Failed to saved", "Ok");
            }
        }
       

        /*private void SaveButton_Clicked(object sender, EventArgs e)
        {
            mcc = new MajorCategoryData();
            mcc.categoryName = CategoryName.Text;
            mcc.categoryCode = CategoryCode.Text;
            conn.Insert(mcc);
            CategoryName.Text = " ";
            CategoryCode.Text = " ";

        }

        private void ShowButton_Clicked(object sender, EventArgs e)
        {
            var data = from stu in conn.Table<MajorCategoryData>() select stu;
            dataList.ItemsSource = data;
        }*/
    }
}
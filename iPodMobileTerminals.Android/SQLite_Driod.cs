using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using iPodMobileTerminals.Droid;
using iPodMobileTerminals.Models;
using iPodMobileTerminals.ViewModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly:Dependency(typeof(SQLite_Driod))]
namespace iPodMobileTerminals.Droid
{
    public class SQLite_Driod : ISQLite
    {
        SQLiteConnection database;
        public SQLiteConnection GetConnectionWithDatabase()
        {
            string filename = "iPodDb.db";
            string documentpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string path = Path.Combine(documentpath, filename);
            database = new SQLiteConnection(path);
            database.CreateTable<RoomDetails>();
            return database;
        }

        /*  public bool SaveEmployee(string name, string address, string phonenumber, string email, string password)
          {
              bool flag = false;
              try
              {
                  Item employee = new Item();
                  employee.Name = name;
                  employee.Address = address;
                  employee.PhoneNumber = phonenumber;
                  employee.Email = email;
                  employee.Password = password;
                  database.Insert(employee);
                  flag = true;
              }
              catch(Exception)
              {
                  flag = false;
              }
              return flag;
          }*/

        /* public List<Item> GetEmployees()
         {
             string sql = "SELECT * FROM Item";
             List<Item> employees = database.Query<Item>(sql);
             return employees;
         }*/

        public bool SaveRoomDetails(string roomCode, string roomStatus)
        {
            bool flag = false;
            try
            {
                RoomDetails room = new RoomDetails();
                room.RoomCode = roomCode;
                room.RoomStatus = roomStatus;

                database.Insert(room);
                flag = true;
            }
            catch (Exception)
            {
                flag = false;
            }
            return flag;
        }

        public List<RoomDetails> GetRoomDetails()
        {
            string sql = "SELECT * FROM RoomDetails";
            List<RoomDetails> room = database.Query<RoomDetails>(sql);
            return room;
        }        
    }
}
using iPodMobileTerminals.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace iPodMobileTerminals.ViewModels
{
    public interface ISQLite
    {
        SQLiteConnection GetConnectionWithDatabase();
        bool SaveRoomDetails(string roomCode, string roomStatus);

        
    }
}

using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace iPodMobileTerminals.Models
{
    public class RoomDetails
    {
        [PrimaryKey, AutoIncrement]
        public int RoomId { get; set; }
        public string RoomCode { get; set; }
        public string RoomStatus { get; set; }        
    }
}

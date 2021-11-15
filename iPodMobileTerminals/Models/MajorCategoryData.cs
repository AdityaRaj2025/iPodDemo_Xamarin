using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace iPodMobileTerminals.Models
{
    public class MajorCategoryData
    {
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }
        public string categoryCode { get; set; }
        public string categoryName { get; set; }
    }
}

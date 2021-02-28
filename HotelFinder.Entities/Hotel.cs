using System;
using System.Collections.Generic;
using System.Text;

namespace HotelFinder.Entities
{
    public class Hotel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Rooms { get; set; }
        public int DailyPrice { get; set; }
    }
}

using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelFinder.Business.Abstract
{
    interface IHotelService
    {
        List<Hotel> GetAllHotels();
        Hotel GetHotelByID(int id);
        Hotel CreateHotel(Hotel hotel);
        void Delete(int id);
        int Fee(int day);
        bool Register();
    }
}

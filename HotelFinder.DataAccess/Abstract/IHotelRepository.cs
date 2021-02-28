using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelFinder.DataAccess.Abstract
{
    public interface IHotelRepository
    {
        List<Hotel> GetAllHotels();
        Hotel GetHotelByID(int id);
        Hotel CreateHotel(Hotel hotel);
        void Delete(int id);
        //int Fee(int day);
        //bool Register();
    }
}

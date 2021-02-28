using HotelFinder.Business.Abstract;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.DataAccess.Concrete;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelFinder.Business.Concrete
{
    public class HotelManager : IHotelService
    {
        private IHotelRepository _hotelRepository;
        public HotelManager(HotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }
        public Hotel CreateHotel(Hotel hotel)
        {
            return _hotelRepository.CreateHotel(hotel);
        }

        public void Delete(int id)
        {
            _hotelRepository.Delete(id);
        }

        public int Fee(int day)
        {
            //C++ DLL Gelecek...
            throw new NotImplementedException();
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotelRepository.GetAllHotels();
        }

        public Hotel GetHotelByID(int id)
        {
            return _hotelRepository.GetHotelByID(id);
        }

        public bool Register(int id)
        {
            throw new NotImplementedException();
        }
    }
}

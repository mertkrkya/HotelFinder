using HotelFinder.DataAccess.Abstract;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelFinder.DataAccess.Concrete
{
    public class HotelRepository : IHotelRepository
    {
        public readonly HotelDbContext _hotelDbContext;

        public HotelRepository(HotelDbContext hotelDbContext)
        {
            _hotelDbContext = hotelDbContext;
        }
        public Hotel CreateHotel(Hotel hotel)
        {
            _hotelDbContext.Hotels.Add(hotel);
            _hotelDbContext.SaveChanges();
            return hotel;
        }

        public void Delete(int id)
        {
            var deletedhotel = _hotelDbContext.Hotels.FirstOrDefault(x => x.ID == id);
            _hotelDbContext.Hotels.Remove(deletedhotel);
            _hotelDbContext.SaveChanges();
        }


        public List<Hotel> GetAllHotels()
        {
            return _hotelDbContext.Hotels.ToList();
        }

        public Hotel GetHotelByID(int id)
        {
            return _hotelDbContext.Hotels.FirstOrDefault(x => x.ID == id);
        }

    }
}

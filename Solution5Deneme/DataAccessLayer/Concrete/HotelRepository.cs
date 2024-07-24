using DataAccessLayer.Abstract;
using Entities;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class HotelRepository : IHotelRepository
    {
        public Hotels CreateHotel(Hotels hotel)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                hotelDbContext.hotels.Add(hotel);
                hotelDbContext.SaveChanges();
                return hotel;
            }    
        }

        public List<Hotels> GetAllHotels()
        {
            using (var hotelDbContext = new HotelDbContext())
            {
               return hotelDbContext.hotels.ToList();
            }
        }

        public Hotels SearchHotelById(int id)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                return hotelDbContext.hotels.Find(id);
            }
        }

        public void DeleteHotel(int id)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                var deleteHotel = SearchHotelById(id);
                hotelDbContext.Remove(deleteHotel);
                hotelDbContext.SaveChanges();
            }
        }

        public Hotels SearchHotelByName(string name)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                return hotelDbContext.hotels.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
            }
        }

        public Hotels UpdateHotel(Hotels hotel)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                hotelDbContext.hotels.Update(hotel);
                hotelDbContext.SaveChanges();
                return hotel;
            }
        }
    }
}

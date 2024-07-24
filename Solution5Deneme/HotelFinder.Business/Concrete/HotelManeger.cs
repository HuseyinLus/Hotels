using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Entities;
using HotelFinder.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Business.Concrete
{
    public class HotelManeger : IHotelServices
    {
        private IHotelRepository _hotelRepository;

        public HotelManeger()
        {
            _hotelRepository = new HotelRepository();
        }

        public Hotels CreateHotel(Hotels hotel)
        {
            return _hotelRepository.CreateHotel(hotel);
        }

        public void DeleteHotel(int id)
        {
           _hotelRepository.DeleteHotel(id);
        }

        public List<Hotels> GetAllHotels()
        {
            return _hotelRepository.GetAllHotels();
        }

        public Hotels SearchHotelById(int id)
        {
            return _hotelRepository.SearchHotelById(id);
        }

        public Hotels SearchHotelByName(string name)
        {
            return _hotelRepository.SearchHotelByName(name);
        }

        public Hotels UpdateHotel(Hotels hotel)
        {
            return _hotelRepository.UpdateHotel(hotel);
        }
    }
}
      
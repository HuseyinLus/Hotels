using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IHotelRepository
    {
        Hotels CreateHotel(Hotels hotel);
        List<Hotels> GetAllHotels();

        Hotels SearchHotelByName(string name);

        Hotels SearchHotelById(int id);

        Hotels UpdateHotel(Hotels hotel);

        void DeleteHotel (int id);
    }
}

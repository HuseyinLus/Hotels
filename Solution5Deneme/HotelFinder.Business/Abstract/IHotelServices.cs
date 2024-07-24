using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Business.Abstract
{
    public interface IHotelServices
    {
        List<Hotels> GetAllHotels();

        Hotels CreateHotel(Hotels hotel);

        Hotels SearchHotelByName(string name);

        Hotels SearchHotelById(int id);

        Hotels UpdateHotel(Hotels hotel);

        void DeleteHotel(int id);


    }
}

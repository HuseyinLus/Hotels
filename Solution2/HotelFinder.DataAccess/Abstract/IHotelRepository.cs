using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Abstract
{
    public interface IHotelRepository
    {
       List<Hotels> GetAllHotels();

        Hotels GetHotelsById(int id);

        Hotels CreateHotels(int id);

        Hotels UpdateHotels(Hotels hotels);

        void DeleteHotelsById(int id);
    }
}

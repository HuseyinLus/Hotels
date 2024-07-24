using HotelFinder.Business.Abstract;
using HotelFinder.Business.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IHotelServices _hotelServices;

        public HotelController()
        {
            _hotelServices = new HotelManeger();
        }

        [HttpGet]
        public List<Hotels> Get()
        {
            return _hotelServices.GetAllHotels();
        }

        [HttpGet("{id}")]
        public Hotels Get(int id)
        {
            return _hotelServices.SearchHotelById(id);
        }
        [HttpPost]
        public Hotels Post([FromBody] Hotels hotel)
        {
            return _hotelServices.CreateHotel(hotel);
        }

        [HttpPut]
        public Hotels Put([FromBody] Hotels hotel)
        {
            return _hotelServices.UpdateHotel(hotel);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _hotelServices.DeleteHotel(id);
        }

    }
}

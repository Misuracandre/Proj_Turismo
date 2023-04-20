using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{
    public class HotelController
    {
        private HotelService hotelService;

        public HotelController()
        {
            hotelService = new HotelService();
        }

        public bool Insert(Hotel hotel)
        {
            return hotelService.Insert(hotel);
        }

        public List<Hotel> GetAll()
        {
            return hotelService.GetAll();
        }
    }
}

using Models;

namespace Controllers
{
    public class CityController
    {
        private CityService cityService;

        public CityController()
        {
            cityService = new CityService();
        }

        public bool Insert(City city)
        {
            return cityService.Insert(city);
        }

        public List<City> GetAll()
        {
            return cityService.GetAll();
        }
    }
}
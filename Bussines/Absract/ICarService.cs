using Entities.Concrete;
using Entities.DTOs;

namespace Bussines.Absract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        List<Car> GetCarsNameLength();
        List<Car> GetCarsDailyPrice();
        void Add(Car car);
        List<CarDetailDto> GetCarDetails();
    }
}

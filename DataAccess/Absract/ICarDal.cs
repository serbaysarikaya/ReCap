using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Absract
{
    public interface ICarDal : IEntityRepository<Car>
    {

        List<CarDetailDto> GetCarDetails();
        List<CarDetailDto> GetCarDetailsByBrandId(int brandId);
        List<CarDetailDto> GetCarDetailsByCarId(int carId);
        List<CarDetailDto> GetCarDetailsByColorAndByBrand(int colorId, int brandId);
        List<CarDetailDto> GetCarDetailsByColorId(int colorId);
    }
}

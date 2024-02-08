using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Bussines.Absract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}

using Core.Utilities.Results;
using Entities.DTOs;

namespace Bussines.Absract
{
    public interface ICarService
    {
        IDataResult<List<CarDto>> GetAll();
        IResult Add(CarDto carDto);

        IResult Update(CarDto carDto);
        IResult Delete(CarDto carDto);
        IDataResult<CarDto> GetById(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}

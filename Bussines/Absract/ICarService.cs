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
        IDataResult<CarDto> GetByCarId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetailsByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetailsByCarId(int carId);
        IDataResult<List<CarDetailDto>> GetCarDetailsByColorAndByBrand(int colorId, int brandId);
        IDataResult<List<CarDetailDto>> GetCarDetailsByBrandId(int brandId);
    }
}

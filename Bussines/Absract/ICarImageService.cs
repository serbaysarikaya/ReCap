using Core.Utilities.Results;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;

namespace Bussines.Absract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile file, CarImageDto carImageDto);
        IResult Delete(CarImageDto carImageDto);
        IResult Update(IFormFile file, CarImageDto carImageDto);
        IDataResult<List<CarImageDto>> GetAll();
        IDataResult<List<CarImageDto>> GetByCarId(int carId);
        IDataResult<CarImageDto> GetByImageId(int imageId);
    }
}

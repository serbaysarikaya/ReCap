using Core.Utilities.Results;
using Entities.DTOs;

namespace Bussines.Absract
{
    public interface IBrandService
    {
        IDataResult<List<BrandDto>> GetAll();
        IResult Add(BrandDto brandDto);
        IResult Update(BrandDto brandDto);
        IResult Delete(BrandDto brandDto);
        IDataResult<BrandDto> GetById(int id);

    }
}

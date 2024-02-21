using Core.Utilities.Results;
using Entities.DTOs;

namespace Bussines.Absract
{
    public interface IColorService
    {
        IDataResult<List<ColorDto>> GetAll();
        IResult Add(ColorDto color);
        IResult Update(ColorDto color);
        IResult Delete(ColorDto color);
        IDataResult<ColorDto> GetById(int id);
    }
}

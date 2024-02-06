using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Absract
{
    public interface ICarDal : IEntityRepository<Car>
    {

        List<CarDetailDto> GetCarDetails();
    }
}

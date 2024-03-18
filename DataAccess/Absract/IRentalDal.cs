using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Absract
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
        List<RentalDetailDto> GetRentalsDetails();
    }
}

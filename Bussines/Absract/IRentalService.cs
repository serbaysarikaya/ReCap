using Core.Utilities.Results;
using Entities.DTOs;

namespace Bussines.Absract
{
    public interface IRentalService
    {
        public IResult Add(RentalDto rentalDto);
        public IResult Delete(RentalDto rentalDto);
        public IResult Update(RentalDto rentalDto);
        public IDataResult<List<RentalDto>> GetAll();
        public IDataResult<RentalDto> GetById(int id);
    }
}

using Core.Utilities.Results;
using Entities.DTOs;

namespace Bussines.Absract
{
    public interface ICustomerService
    {
        public IResult Add(CustomerDto customerDto);
        public IResult Update(CustomerDto customerDto);
        public IResult Delete(CustomerDto customerDto);
        public IDataResult<CustomerDto> GetById(int id);
        public IDataResult<List<CustomerDto>> GetAll();

    }
}

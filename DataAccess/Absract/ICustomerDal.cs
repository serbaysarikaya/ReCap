using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Absract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
    }
}

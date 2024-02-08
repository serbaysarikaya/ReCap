using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Absract
{
    public interface IUserDal : IEntityRepository<User>
    {
    }
}

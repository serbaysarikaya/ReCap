using Core.DataAccess;
using Core.Entities.Concrete;

namespace DataAccess.Absract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}

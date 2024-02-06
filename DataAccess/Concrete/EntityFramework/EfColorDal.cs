using Core.DataAccess.EntityFramework;
using DataAccess.Absract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, CarRentalDbContext>, IColorDal
    {

    }
}

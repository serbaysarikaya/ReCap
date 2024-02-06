using Core.DataAccess.EntityFramework;
using DataAccess.Absract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, CarRentalDbContext>, IBrandDal
    {

    }
}

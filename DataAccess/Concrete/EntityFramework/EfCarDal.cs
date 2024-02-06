using Core.DataAccess.EntityFramework;
using DataAccess.Absract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalDbContext reCapContext = new CarRentalDbContext())
            {
                var result = from c in reCapContext.Cars
                             join b in reCapContext.Brands
                             on c.BrandId equals b.Id
                             join co in reCapContext.Colors
                             on c.ColorId equals co.Id
                             select new CarDetailDto
                             {
                                 CarName = c.CarName,
                                 ColorName = co.Name,
                                 BrandName = b.Name,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}

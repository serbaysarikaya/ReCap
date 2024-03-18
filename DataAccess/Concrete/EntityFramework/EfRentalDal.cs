using Core.DataAccess.EntityFramework;
using DataAccess.Absract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalDbContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalsDetails()
        {
            using (CarRentalDbContext context = new CarRentalDbContext())
            {
                var result = from ca in context.Cars
                             join b in context.Brands on ca.BrandId equals b.Id
                             join re in context.Rentals on ca.Id equals re.CarId
                             join co in context.Colors on ca.ColorId equals co.Id
                             join cu in context.Customers on re.CustomerId equals cu.Id
                             join u in context.Users on cu.UserId equals u.Id
                             select new RentalDetailDto
                             {
                                 CarId = ca.Id,
                                 BrandId = b.Id,
                                 ColorName = co.Name,
                                 BrandName = b.Name,
                                 ModelName = ca.ModelName,
                                 RentalId = re.Id,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate,
                                 CustomerName = u.FirstName,
                                 CustomerLastname = u.LastName


                             };

                // Sonucu listeye çevir
                return result.ToList();

            }
        }
    }
}

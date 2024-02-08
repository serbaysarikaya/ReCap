﻿using Core.DataAccess.EntityFramework;
using DataAccess.Absract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalDbContext>, IRentalDal
    {
    }
}

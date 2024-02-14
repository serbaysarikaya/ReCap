using AutoMapper;
using Entities.Concrete;
using Entities.DTOs;

namespace Bussines.AutoMappers
{
    public class RentalMapper : Profile
    {
        public RentalMapper()
        {
            CreateMap<Rental, RentalDto>();
            CreateMap<RentalDto, Rental>();
        }
    }
}

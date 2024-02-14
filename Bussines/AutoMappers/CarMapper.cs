using AutoMapper;
using Entities.Concrete;
using Entities.DTOs;

namespace Bussines.AutoMappers
{
    public class CarMapper : Profile
    {
        public CarMapper()
        {
            CreateMap<Car, CarDto>();
            CreateMap<CarDto, Car>();

        }

    }

}

using AutoMapper;
using Entities.Concrete;
using Entities.DTOs;

namespace Bussines.AutoMappers
{
    public class CarImageMapper : Profile
    {
        public CarImageMapper()
        {
            CreateMap<CarImage, CarImageDto>();
            CreateMap<CarImageDto, CarImage>();
        }
    }

}

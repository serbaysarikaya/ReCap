using AutoMapper;
using Entities.Concrete;
using Entities.DTOs;

namespace Bussines.AutoMappers
{
    public class BrandMapper : Profile
    {
        public BrandMapper()
        {
            CreateMap<Brand, BrandDto>();
            CreateMap<BrandDto, Brand>();
        }
    }
}

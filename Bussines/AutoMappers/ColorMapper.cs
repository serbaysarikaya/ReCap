using AutoMapper;
using Entities.Concrete;
using Entities.DTOs;

namespace Bussines.AutoMappers
{
    public class ColorMapper : Profile
    {
        public ColorMapper()
        {
            CreateMap<Color, ColorDto>();
            CreateMap<ColorDto, Color>();
        }
    }
}

using AutoMapper;
using Core.Entities.Concrete;
using Entities.DTOs;

namespace Bussines.AutoMappers
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

        }
    }
}

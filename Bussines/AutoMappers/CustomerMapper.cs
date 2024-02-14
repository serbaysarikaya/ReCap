using AutoMapper;
using Entities.Concrete;
using Entities.DTOs;

namespace Bussines.AutoMappers
{
    public class CustomerMapper : Profile
    {
        public CustomerMapper()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
        }
    }
}

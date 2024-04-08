using AutoMapper;
using Entities.Concrete;
using Entities.DTOs;

namespace Bussines.AutoMappers
{
    public class PaymentMapper : Profile
    {
        public PaymentMapper()
        {
            CreateMap<Payment, PaymentDto>();
            CreateMap<PaymentDto, Payment>();
        }
    }
}

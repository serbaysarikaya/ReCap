using AutoMapper;
using Core.Entities.Concrete;
using Entities.DTOs;

namespace Bussines.AutoMappers
{
    public class UserOperationClaimMapper : Profile
    {
        public UserOperationClaimMapper()
        {
            CreateMap<UserOperationClaim, UserOperationClaimDto>();
            CreateMap<UserOperationClaimDto, UserOperationClaim>();
        }
    }
}

using AutoMapper;
using Core.Entities.Concrete;
using Entities.DTOs;

namespace Bussines.AutoMappers
{
    public class OperationClaimMapper : Profile
    {
        public OperationClaimMapper()
        {
            CreateMap<OperationClaim, OperationClaimDto>();
            CreateMap<OperationClaimDto, OperationClaim>();
        }
    }
}

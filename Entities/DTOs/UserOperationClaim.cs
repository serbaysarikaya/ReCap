using Core.Entities;

namespace Entities.DTOs
{
    public class UserOperationClaimDto : IDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }

    }
}

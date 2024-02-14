using Core.Entities;

namespace Entities.DTOs
{
    public class CustomerDto : IDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}

using Core.Entities;

namespace Entities.DTOs
{
    public class CarImageDto : IDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string? ImagePath { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

using Core.Entities;

namespace Entities.DTOs
{
    public class ColorDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

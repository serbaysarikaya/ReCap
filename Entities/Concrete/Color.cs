using Core.Entities;

namespace Entities.Concrete
{
    public class Color : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
        public Color()
        {
            Cars = new HashSet<Car>();
        }
    }
}

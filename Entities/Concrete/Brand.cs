using Core.Entities;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Car>? Cars { get; }

        public Brand()
        {
            Cars = new HashSet<Car>();
        }
    }
}

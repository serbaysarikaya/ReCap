using Core.Entities;

namespace Entities.Concrete
{
    public class Rental : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public virtual Car Car { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual ICollection<Rental> Rentals { get; }
        public Rental()
        {
            Rentals = new HashSet<Rental>();
        }
    }
}

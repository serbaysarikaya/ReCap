using Core.Entities;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        //Customers-->UserId,CompanyName
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
        public Customer()
        {
            Rentals = new HashSet<Rental>();
        }


    }
}

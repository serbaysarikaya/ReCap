using Core.Entities;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        //Customers-->UserId,CompanyName
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public virtual User User { get; set; }

    }
}

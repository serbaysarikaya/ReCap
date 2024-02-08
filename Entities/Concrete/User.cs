﻿using Core.Entities;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        //>Id,FirstName,LastName,Email,Password
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Customer> Customers { get; }
        public User()
        {
            Customers = new HashSet<Customer>();
        }
    }
}

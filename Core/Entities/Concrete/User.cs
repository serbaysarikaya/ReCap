namespace Core.Entities.Concrete
{
    public class User : IEntity
    {
        //>Id,FirstName,LastName,Email,Password
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }//Veri tabanında güvenlik açısından kullanıcı şifrelerini byte olarak ve has'leyerek koyuyorum
        public byte[] PasswordHash { get; set; }//şifre hash'lerken kendim tuzlama yapıyorum, tekrar şifreyi verify edeceğim zaman bu salt değerine ihtiyacım var.
        public bool Status { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }

        //public virtual ICollection<Customer> Customers { get; }

        //public User()
        //{
        //    Customers = new HashSet<Customer>();
        //}
    }
}

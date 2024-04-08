using Core.Entities;

namespace Entities.DTOs
{
    public class PaymentDto : IDto
    {
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
        public string CreditCardNumber { get; set; }
        public decimal Price { get; set; }
        public string ExpirationDate { get; set; }
        public string SecurityCode { get; set; }
    }
}

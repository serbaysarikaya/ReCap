﻿using Core.Entities;

namespace Entities.DTOs
{
    public class RentalDto : IDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerID { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}

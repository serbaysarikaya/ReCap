﻿using Core.Entities;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string ModelName { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }//DailyPrice
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Color Color { get; set; }

        public virtual ICollection<Rental> Rentals { get; }
        public virtual ICollection<CarImage> CarImages { get; set; }


        public Car()
        {
            Rentals = new HashSet<Rental>();
            CarImages = new HashSet<CarImage>();
        }
    }
}

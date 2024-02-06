using Bussines.Absract;
using DataAccess.Absract;
using Entities.Concrete;
using Entities.DTOs;

namespace Bussines.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else if (car.CarName.Length <= 2)
            {
                Console.WriteLine("Araba ismi 2 karakterden fazla olmalı");
            }
            else if (car.DailyPrice <= 0)
            {
                Console.WriteLine("Günülük üçret 0' dan büyük olmalı");
            }
            else
            {
                Console.WriteLine("Araba ismi 2 karakterden büyük ve günlük ücreti 0'dan büyük olmalıdır.");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public List<Car> GetCarsDailyPrice()
        {
            return _carDal.GetAll(c => c.DailyPrice > 0);
        }

        public List<Car> GetCarsNameLength()
        {
            return _carDal.GetAll(P => P.Description.Length > 2);
        }
    }
}

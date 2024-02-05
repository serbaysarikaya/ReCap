using DataAccess.Absract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                 new Car { Id = 1,BrandId = 1 ,ColorId=1 ,DailyPrice= 1500 ,ModelYear =1986 ,Description="Ford Mustang Kırmızı"},
                 new Car { Id = 2,BrandId = 2 ,ColorId=2 ,DailyPrice= 2500 ,ModelYear =2005 ,Description="Bmw I20 Yeşil"},
                 new Car { Id = 3,BrandId = 1 ,ColorId=3 ,DailyPrice= 750 ,ModelYear =2013 ,Description="Ford Fiesta Mor"},
                 new Car { Id = 4,BrandId = 3 ,ColorId=1 ,DailyPrice= 1500 ,ModelYear =1986 ,Description="AlfaRome Romeo Kırmızı"},
                 new Car { Id = 5,BrandId = 4 ,ColorId=5 ,DailyPrice= 200 ,ModelYear =2015 ,Description="Wolksvagen Golf Blue"},


            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            var carDelte = _car.FirstOrDefault(c => c.Id == car.Id);
            _car.Remove(carDelte);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            var carUpdate = _car.FirstOrDefault(c => c.Id == car.Id);
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.Description = car.Description;
        }
    }
}

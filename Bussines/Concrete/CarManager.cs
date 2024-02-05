using Bussines.Absract;
using DataAccess.Absract;
using Entities.Concrete;

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
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetById(id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}

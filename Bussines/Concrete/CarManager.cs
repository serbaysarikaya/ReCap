using Bussines.Absract;
using Bussines.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {
            if (car.CarName.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.Added);
            }
            else if (car.CarName.Length <= 2)
            {
                Console.WriteLine("Araba ismi 2 karakterden fazla olmalı");
                return new ErrorResult(Messages.Error);
            }
            else if (car.DailyPrice <= 0)
            {
                Console.WriteLine("Günülük üçret 0' dan büyük olmalı");
                return new ErrorResult(Messages.Error);
            }
            else
            {
                Console.WriteLine("Araba ismi 2 karakterden büyük ve günlük ücreti 0'dan büyük olmalıdır.");
                return new ErrorResult(Messages.Error);
            }
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), Messages.Listed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id), Messages.Listed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id), Messages.Listed);
        }

        public IDataResult<List<Car>> GetCarsDailyPrice()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice > 0), Messages.Listed);
        }

        public IDataResult<List<Car>> GetCarsNameLength()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(P => P.Description.Length > 2), Messages.Listed);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.Updated);
        }
    }
}

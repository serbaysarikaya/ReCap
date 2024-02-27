using AutoMapper;
using Bussines.Absract;
using Bussines.BusinessAspects.Autofac;
using Bussines.Constants.Messages;
using Bussines.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Absract;
using Entities.Concrete;
using Entities.DTOs;



namespace Bussines.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IMapper _mapper;

        public CarManager(ICarDal carDal, IMapper mapper)
        {
            _carDal = carDal;
            _mapper = mapper;
        }

        [SecuredOperation("admin,car,moderator")]
        [ValidationAspect(typeof(CarDtoValidator))]
        [CacheRemoveAspect("ICarDal.Get")]
        public IResult Add(CarDto carDto)
        {

            ValidationTool.Validate(new CarDtoValidator(), carDto);
            _carDal.Add(_mapper.Map<Car>(carDto));
            return new SuccessResult(CarMessages.CarAdded);
        }


        [SecuredOperation("admin")]
        public IResult Delete(CarDto carDto)
        {
            _carDal.Delete(_mapper.Map<Car>(carDto));
            return new SuccessResult(CarMessages.CarDeleted);
        }
        [CacheAspect]
        public IDataResult<List<CarDto>> GetAll()
        {
            return new SuccessDataResult<List<CarDto>>(_mapper.Map<List<CarDto>>(_carDal.GetAll()), CarMessages.CarsListed);
        }
        [CacheAspect]
        public IDataResult<CarDto> GetById(int id)
        {
            return new SuccessDataResult<CarDto>(_mapper.Map<CarDto>(_carDal.Get(p => p.Id == id)), CarMessages.CarsListed);
        }
        [CacheAspect]
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), CarMessages.CarsListed);
        }

        [SecuredOperation("admin,car")]
        [ValidationAspect(typeof(CarDtoValidator))]
        [CacheRemoveAspect("ICarDal.Get")]
        public IResult Update(CarDto carDto)
        {
            _carDal.Update(_mapper.Map<Car>(carDto));
            return new SuccessResult(CarMessages.CarUpdated);

        }
    }
}

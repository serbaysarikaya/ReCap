using AutoMapper;
using Bussines.Absract;
using Bussines.Constants;
using Bussines.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Absract;
using Entities.Concrete;
using Entities.DTOs;

namespace Bussines.Concrete
{
    public class BrandManager : IBrandService
    {

        IBrandDal _brandDal;
        IMapper _mapper;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public BrandManager(IBrandDal brandDal, IMapper mapper)
        {
            _brandDal = brandDal;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(BrandDtoValidator))]
        public IResult Add(BrandDto brandDto)
        {
            _brandDal.Add(_mapper.Map<Brand>(brandDto));
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(BrandDto brandDto)
        {
            _brandDal.Delete(_mapper.Map<Brand>(brandDto));
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<BrandDto>> GetAll()
        {
            return new SuccessDataResult<List<BrandDto>>(_mapper.Map<List<BrandDto>>(_brandDal.GetAll()), Messages.BrandsListed);
        }

        public IDataResult<BrandDto> GetById(int id)
        {
            return new SuccessDataResult<BrandDto>(_mapper.Map<BrandDto>(_brandDal.Get(p => p.Id == id)), Messages.BrandsListed);
        }

        [ValidationAspect(typeof(BrandDtoValidator))]

        public IResult Update(BrandDto brandDto)
        {
            _brandDal.Update(_mapper.Map<Brand>(brandDto));
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}

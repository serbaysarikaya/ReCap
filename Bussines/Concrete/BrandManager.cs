using AutoMapper;
using Bussines.Absract;
using Bussines.BusinessAspects.Autofac;
using Bussines.Constants.Messages;
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


        public BrandManager(IBrandDal brandDal, IMapper mapper)
        {
            _brandDal = brandDal;
            _mapper = mapper;
        }
        [SecuredOperation("moderator,brand,admin")]
        [ValidationAspect(typeof(BrandDtoValidator))]
        public IResult Add(BrandDto brandDto)
        {
            _brandDal.Add(_mapper.Map<Brand>(brandDto));
            return new SuccessResult(BrandMessages.BrandAdded);
        }
        [SecuredOperation("admin")]
        public IResult Delete(BrandDto brandDto)
        {
            _brandDal.Delete(_mapper.Map<Brand>(brandDto));
            return new SuccessResult(BrandMessages.BrandDeleted);
        }

        public IDataResult<List<BrandDto>> GetAll()
        {
            return new SuccessDataResult<List<BrandDto>>(_mapper.Map<List<BrandDto>>(_brandDal.GetAll()), BrandMessages.BrandsListed);
        }

        public IDataResult<BrandDto> GetById(int id)
        {
            return new SuccessDataResult<BrandDto>(_mapper.Map<BrandDto>(_brandDal.Get(p => p.Id == id)), BrandMessages.BrandsListed);
        }

        [SecuredOperation("brand,admin")]
        [ValidationAspect(typeof(BrandDtoValidator))]
        public IResult Update(BrandDto brandDto)
        {
            _brandDal.Update(_mapper.Map<Brand>(brandDto));
            return new SuccessResult(BrandMessages.BrandUpdated);
        }
    }
}

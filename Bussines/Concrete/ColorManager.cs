using AutoMapper;
using Bussines.Absract;
using Bussines.BusinessAspects.Autofac;
using Bussines.Constants.Messages;
using Bussines.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Absract;
using Entities.Concrete;
using Entities.DTOs;


namespace Bussines.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        IMapper _mapper;


        public ColorManager(IColorDal colorDal, IMapper mapper)
        {
            _colorDal = colorDal;
            _mapper = mapper;
        }

        [SecuredOperation("admin,color,moderator")]
        [ValidationAspect(typeof(ColorDtoValidator))]
        [CacheRemoveAspect("IColorDal.Get")]
        public IResult Add(ColorDto colorDto)
        {
            _colorDal.Add(_mapper.Map<Color>(colorDto));
            return new SuccessResult(ColorMessages.ColorAdded);
        }

        [SecuredOperation("admin")]
        public IResult Delete(ColorDto colorDto)
        {
            _colorDal.Delete(_mapper.Map<Color>(colorDto));
            return new SuccessResult(ColorMessages.ColorDeleted);
        }

        [CacheAspect]
        public IDataResult<List<ColorDto>> GetAll()
        {
            return new SuccessDataResult<List<ColorDto>>(_mapper.Map<List<ColorDto>>(_colorDal.GetAll()), ColorMessages.ColorsListed);
        }
        [CacheAspect]
        public IDataResult<ColorDto> GetById(int id)
        {
            return new SuccessDataResult<ColorDto>(_mapper.Map<ColorDto>(_colorDal.Get(p => p.Id == id)), ColorMessages.ColorsListed);
        }

        [SecuredOperation("admin,color")]
        [ValidationAspect(typeof(ColorDtoValidator))]
        [CacheRemoveAspect("IColorDal.Get")]
        public IResult Update(ColorDto colorDto)
        {
            _colorDal.Update(_mapper.Map<Color>(colorDto));
            return new SuccessResult(ColorMessages.ColorUpdated);
        }
    }
}

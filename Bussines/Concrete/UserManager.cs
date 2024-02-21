using AutoMapper;
using Bussines.Absract;
using Bussines.Constants.Messages;
using Bussines.ValidationRules.FluentValidation.Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Absract;
using Entities.Concrete;
using Entities.DTOs;

namespace Bussines.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        IMapper _mapper;

        public UserManager(IUserDal userDal, IMapper mapper)
        {
            _userDal = userDal;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(UserDtoValidator))]
        public IResult Add(UserDto userDto)
        {
            _userDal.Add(_mapper.Map<User>(userDto));
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(UserDto userDto)
        {
            _userDal.Delete(_mapper.Map<User>(userDto));
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<UserDto>> GetAll()
        {
            return new SuccessDataResult<List<UserDto>>(_mapper.Map<List<UserDto>>(_userDal.GetAll()), Messages.UsersListed);
        }

        public IDataResult<UserDto> GetById(int id)
        {
            var result = _mapper.Map<UserDto>(_userDal.Get(p => p.Id == id));
            if (result == null)
            {
                return new ErrorDataResult<UserDto>(Messages.Error);

            }
            return new SuccessDataResult<UserDto>(result, Messages.UsersListed);



        }

        [ValidationAspect(typeof(UserDtoValidator))]
        public IResult Update(UserDto userDto)
        {
            _userDal.Update(_mapper.Map<User>(userDto));
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}

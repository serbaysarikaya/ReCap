using Core.Utilities.Results;
using Entities.DTOs;

namespace Bussines.Absract
{
    public interface IUserService
    {
        public IResult Add(UserDto userDto);
        public IResult Delete(UserDto userDto);

        public IResult Update(UserDto userDto);
        public IDataResult<UserDto> GetById(int id);
        public IDataResult<List<UserDto>> GetAll();
    }
}

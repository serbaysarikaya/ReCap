using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.DTOs;

namespace Bussines.Absract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password); //Kayıt operasyonu
        IDataResult<User> Login(UserForLoginDto userForLoginDto);//Giriş operasyonu
        IResult UserExists(string email);//Kullanıcı var mı
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}

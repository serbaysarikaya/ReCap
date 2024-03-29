﻿using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Bussines.Absract
{
    public interface IUserService
    {
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IResult Add(User user);
        IDataResult<User> GetByMail(string email);
    }
}

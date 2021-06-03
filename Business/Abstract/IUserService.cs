using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetByEmail(string email);
        IDataResult<List<OperationClaim>> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}

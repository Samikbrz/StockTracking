using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        private IUserOperationClaimDal _userOperaitonClaimDal;

        public UserOperationClaimManager(IUserOperationClaimDal userOperaitonClaimDal)
        {
            _userOperaitonClaimDal = userOperaitonClaimDal;
        }
        public IResult Add(UserOperationClaim userOperationClaim)
        {
            _userOperaitonClaimDal.Add(userOperationClaim);
            return new SuccessResult(Messages.ListedUserOperationClaims);
        }

        public IResult Delete(UserOperationClaim userOperationClaim)
        {
            _userOperaitonClaimDal.Delete(userOperationClaim);
            return new SuccessResult(Messages.DeletedUserOperationClaims);
        }

        public IDataResult<List<UserOperationClaim>> GetById(int id)
        {
            return new SuccessDataResult<List<UserOperationClaim>>(_userOperaitonClaimDal.GetAll(u => u.Id == id));
        }

        public IDataResult<List<UserOperationClaimDto>> GetDetail()
        {
            return new SuccessDataResult<List<UserOperationClaimDto>>(_userOperaitonClaimDal.GetUserOperaitonClaimDetails());
        }

        public IResult Update(UserOperationClaim userOperationClaim)
        {
            _userOperaitonClaimDal.Add(userOperationClaim);
            return new SuccessResult(Messages.UpdatedUserOperationClaims);
        }
    }
}

﻿using Business.Abstract;
using Business.BusinessAspect.Autofac;
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

        [SecuredOperation("admin")]
        public IResult Add(UserOperationClaim userOperationClaim)
        {
            var result = _userOperaitonClaimDal.GetAll(u => u.UserId == userOperationClaim.UserId && u.OperationClaimId == userOperationClaim.OperationClaimId);
            if (result.Count!=0)
            {
                return new ErrorResult(Messages.UserOperationClaimAlreadyExist);
            }
            _userOperaitonClaimDal.Add(userOperationClaim);
            return new SuccessResult(Messages.ListedUserOperationClaims);
        }

        [SecuredOperation("admin")]
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

        [SecuredOperation("admin")]
        public IResult Update(UserOperationClaim userOperationClaim)
        {
            _userOperaitonClaimDal.Update(userOperationClaim);
            return new SuccessResult(Messages.UpdatedUserOperationClaims);
        }
    }
}

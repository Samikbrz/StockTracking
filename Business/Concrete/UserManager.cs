﻿using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user));
        }

        [SecuredOperation("admin")]
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(); 
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<List<User>> GetByEmail(string email)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(e=>e.Email==email));
        }

        [SecuredOperation("admin")]
        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult();
        }

        [SecuredOperation("admin")]
        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult();
        }

        public IDataResult<List<User>> GetById(int id)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(e => e.Id == id));
        }
    }
}

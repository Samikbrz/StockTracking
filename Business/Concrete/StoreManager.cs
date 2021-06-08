using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class StoreManager : IStoreService
    {
        private IStoreDal _storeDal;
        public StoreManager(IStoreDal storeDal)
        {
            _storeDal = storeDal;
        }

        [SecuredOperation("admin")]
        public IResult Add(Store store)
        {
            var resut = _storeDal.GetAll(s => s.StoreName == store.StoreName);
            if (resut.Count!=0)
            {
                return new ErrorResult(Messages.StoreAlreadyExist);
            }
            _storeDal.Add(store);
            return new SuccessResult(Messages.AddedStore);
        }

        [SecuredOperation("admin")]
        public IResult Delete(Store store)
        {
            _storeDal.Delete(store);
            return new SuccessResult(Messages.DeletedStore);
        }

        public IDataResult<List<Store>> GetAll()
        {
            return new SuccessDataResult<List<Store>>(_storeDal.GetAll(), Messages.ListedStore);
        }

        public IDataResult<List<Store>> GetById(int id)
        {
            return new SuccessDataResult<List<Store>>(_storeDal.GetAll(s => s.Id == id),Messages.ListedStore);
        }

        [SecuredOperation("admin")]
        public IResult Update(Store store)
        {
            _storeDal.Update(store);
            return new SuccessResult(Messages.UpdatedStore);
        }
    }
}

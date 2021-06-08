using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class StoreTransferManager : IStoreTransferService
    {
        private IStoreTransferDal _storeTransferDal;
        public StoreTransferManager(IStoreTransferDal storeTransferDal)
        {
            _storeTransferDal = storeTransferDal;
        }

        [SecuredOperation("admin")]
        public IResult Add(StoreTransfer storeTransfer)
        {
            _storeTransferDal.Add(storeTransfer);
            return new SuccessResult(Messages.AddedStoreTransfer);
        }

        [SecuredOperation("admin")]
        public IResult Delete(StoreTransfer storeTransfer)
        {
            _storeTransferDal.Delete(storeTransfer);
            return new SuccessResult(Messages.DeletedStoreTransfer);
        }

        public IDataResult<List<StoreTransfer>> GetAll()
        {
            return new SuccessDataResult<List<StoreTransfer>>(_storeTransferDal.GetAll(), Messages.ListedStoreTransfer);
        }

        public IDataResult<List<StoreTransfer>> GetById(int id)
        {
            return new SuccessDataResult<List<StoreTransfer>>(_storeTransferDal.GetAll(s=>s.Id==id));
        }

        public IDataResult<List<StoreTransferDto>> GetDetail()
        {
            return new SuccessDataResult<List<StoreTransferDto>>(_storeTransferDal.GetStoreTransferDetails());
        }

        [SecuredOperation("admin,employee")]
        public IResult Update(StoreTransfer storeTransfer)
        {
            _storeTransferDal.Update(storeTransfer);
            return new SuccessResult(Messages.UpdatedStoreTransfer);
        }
    }
}

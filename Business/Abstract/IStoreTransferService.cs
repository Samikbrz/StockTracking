using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IStoreTransferService
    {
        IDataResult<List<StoreTransfer>> GetAll();
        IDataResult<List<StoreTransfer>> GetById(int id);
        IDataResult<List<StoreTransferDto>> GetDetail();
        IResult Add(StoreTransfer storeTransfer);
        IResult Update(StoreTransfer storeTransfer);
        IResult Delete(StoreTransfer storeTransfer);
    }
}

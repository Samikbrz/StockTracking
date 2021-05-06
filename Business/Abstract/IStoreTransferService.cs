using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IStoreTransferService
    {
        IDataResult<List<StoreTransfer>> GetAll();
        IResult Add(StoreTransfer storeTransfer);
        IResult Update(StoreTransfer storeTransfer);
        IResult Delete(StoreTransfer storeTransfer);
    }
}

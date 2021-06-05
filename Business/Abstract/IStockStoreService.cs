using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IStockStoreService
    {
        IDataResult<List<StockStoreDto>> GetDetail();
        IDataResult<List<StockStore>> GetById(int id);
        IResult Add(StockStore stockStore);
        IResult Update(StockStore stockStore);
        IResult Delete(StockStore stockStore);
    }
}

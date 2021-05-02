using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IStockStoreService
    {
        IDataResult<List<StockStore>> GetAll();
        IResult Add(StockStore stockStore);
        IResult Update(StockStore stockStore);
        IResult Delete(StockStore stockStore);
    }
}

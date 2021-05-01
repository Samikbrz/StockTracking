using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IStockKindService
    {
        IDataResult<List<StockKind>> GetAll();
        IResult Add(StockKind stockKind);
        IResult Update(StockKind stockKind);
        IResult Delete(StockKind stockKind);
    }
}

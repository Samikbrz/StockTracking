using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IStockService
    {
        IDataResult<List<Stock>> GetAll();
        IResult Add(Stock stock);
        IResult Update(Stock stock);
        IResult Delete(Stock stock);
    }
}

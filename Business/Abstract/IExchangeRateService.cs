using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IExchangeRateService
    {
        IDataResult<List<ExchangeRate>> GetAll();
        IResult Add(ExchangeRate exchangeRate);
        IResult Update(ExchangeRate exchangeRate);
        IResult Delete(ExchangeRate exchangeRate);
    }
}

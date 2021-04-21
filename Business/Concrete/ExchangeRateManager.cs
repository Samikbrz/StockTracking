using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ExchangeRateManager : IExchangeRateService
    {
        private IExchangeRateDal _exchangeRateDal;
        public ExchangeRateManager(IExchangeRateDal exchangeRateDal)
        {
            _exchangeRateDal = exchangeRateDal;
        }
        public IResult Add(ExchangeRate exchangeRate)
        {
            _exchangeRateDal.Add(exchangeRate);
            return new SuccessResult(Messages.ExchangeRateAdded);
        }

        public IResult Delete(ExchangeRate exchangeRate)
        {
           _exchangeRateDal.Delete(exchangeRate);
           return new SuccessResult(Messages.ExchangeRateDeleted);
        }

        public IDataResult<List<ExchangeRate>> GetAll()
        {
            return new SuccessDataResult<List<ExchangeRate>>(_exchangeRateDal.GetAll(), Messages.ExchangeRateListed);
        }

        public IResult Update(ExchangeRate exchangeRate)
        {
           _exchangeRateDal.Update(exchangeRate);
           return new SuccessResult(Messages.ExchangeRateUpdated);
        }
    }
}

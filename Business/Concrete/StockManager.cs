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
    public class StockManager : IStockService
    {
        private IStockDal _stockDal;
        public StockManager(IStockDal stockDal)
        {
            _stockDal = stockDal;
        }
        public IResult Add(Stock stock)
        {
            _stockDal.Add(stock);
            return new SuccessResult(Messages.AddedStock);
        }

        public IResult Delete(Stock stock)
        {
            _stockDal.Delete(stock);
            return new SuccessResult(Messages.DeletedStock);
        }

        public IDataResult<List<Stock>> GetAll()
        {
            return new SuccessDataResult<List<Stock>>(_stockDal.GetAll(), Messages.ListedStock);
        }

        public IResult Update(Stock stock)
        {
            _stockDal.Update(stock);
            return new SuccessResult(Messages.UpdatedStock);
        }
    }
}

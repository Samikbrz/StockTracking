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
    public class StockKindManager : IStockKindService
    {
        private IStockKindDal _stockKindDal;
        public StockKindManager(IStockKindDal stockKindDal)
        {
            _stockKindDal = stockKindDal;
        }
        public IResult Add(StockKind stockKind)
        {
            _stockKindDal.Add(stockKind);
            return new SuccessResult(Messages.AddedStockKind);
        }

        public IResult Delete(StockKind stockKind)
        {
            _stockKindDal.Delete(stockKind);
            return new SuccessResult(Messages.DeletedStockKind);
        }

        public IDataResult<List<StockKind>> GetAll()
        {
            return new SuccessDataResult<List<StockKind>>(_stockKindDal.GetAll(), Messages.ListedStockKind);
        }

        public IResult Update(StockKind stockKind)
        {
           _stockKindDal.Update(stockKind);
           return new SuccessResult(Messages.UpdatedStockKind);
        }
    }
}

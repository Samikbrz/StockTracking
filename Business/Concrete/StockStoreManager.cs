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
    class StockStoreManager : IStockStoreService
    {
        private IStockStoreDal _stockStoreDal;
        public StockStoreManager(IStockStoreDal stockStoreDal)
        {
            _stockStoreDal = stockStoreDal;
        }
        public IResult Add(StockStore stockStore)
        {
            _stockStoreDal.Add(stockStore);
            return new SuccessResult(Messages.AddedStockStore);
        }

        public IResult Delete(StockStore stockStore)
        {
            _stockStoreDal.Delete(stockStore);
            return new SuccessResult(Messages.DeletedStockStore);
        }

        public IDataResult<List<StockStore>> GetAll()
        {
            return new SuccessDataResult<List<StockStore>>(_stockStoreDal.GetAll(), Messages.ListedStockStores);
        }

        public IResult Update(StockStore stockStore)
        {
            _stockStoreDal.Update(stockStore);
            return new SuccessResult(Messages.UpdatedStockStore);
        }
    }
}

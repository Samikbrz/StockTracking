using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

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
            var result = _stockStoreDal.GetAll(p => p.ProductAcceptanceId == stockStore.ProductAcceptanceId);
            if (result.Count!=0)
            {
                return new ErrorResult(Messages.ProductAlreadyExist);
            }
            _stockStoreDal.Add(stockStore);
            return new SuccessResult(Messages.AddedStockStore);
        }

        public IResult Delete(StockStore stockStore)
        {
            _stockStoreDal.Delete(stockStore);
            return new SuccessResult(Messages.DeletedStockStore);
        }

        public IDataResult<List<StockStore>> GetById(int id)
        {
            return new SuccessDataResult<List<StockStore>>(_stockStoreDal.GetAll(s=>s.Id==id));
        }

        public IDataResult<List<StockStore>> GetByProductAcceptanceId(int id)
        {
            return new SuccessDataResult<List<StockStore>>(_stockStoreDal.GetAll(s => s.ProductAcceptanceId == id));
        }

        public IDataResult<List<StockStoreDto>> GetDetail()
        {
            return new SuccessDataResult<List<StockStoreDto>>(_stockStoreDal.GetStockStoreDetails(), Messages.ListedStockStores);
        }

        public IResult Update(StockStore stockStore)
        {
            _stockStoreDal.Update(stockStore);
            return new SuccessResult(Messages.UpdatedStockStore);
        }
    }
}

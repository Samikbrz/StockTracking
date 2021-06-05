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
    public class ProductOutputManager : IProductOutputService
    {
        private IProductOutputDal _productOutputDal;
        private IProductAcceptanceDal _productAcceptanceDal;
        private IStockStoreDal _stockStoreDal;
        public ProductOutputManager(IProductOutputDal productOutputDal, IProductAcceptanceDal productAcceptanceDal, IStockStoreDal stockStoreDal)
        {
            _productOutputDal = productOutputDal;
            _productAcceptanceDal = productAcceptanceDal;
            _stockStoreDal = stockStoreDal;
        }

        public IResult Add(ProductOutput productOutput)
        {
            List<StockStore> products = _stockStoreDal.GetAll(p => p.Id == productOutput.ProductAcceptanceId);
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Count < productOutput.Count)
                {
                    return new ErrorResult(Messages.CountError);
                }
                else
                {
                    StockStore product = new StockStore
                    {                        
                        Count= products[i].Count - productOutput.Count,
                        Barcode=products[i].Barcode,                       
                        Id=products[i].Id,  
                        UnitPrice=products[i].UnitPrice,
                        Currency=products[i].Currency,
                        DrawerId=products[i].DrawerId,
                        ProductAcceptanceId=products[i].ProductAcceptanceId,
                        ProductUnitId=products[i].ProductUnitId,
                        ShelfId=products[i].ShelfId,
                        StoreId=products[i].StoreId
                    };                    
                    
                    _stockStoreDal.Update(product);
                }
            }
            _productOutputDal.Add(productOutput);
            return new SuccessResult(Messages.AddedProductOutput);
        }

        public IResult Delete(ProductOutput productOutput)
        {
            _productOutputDal.Delete(productOutput);
            return new SuccessResult(Messages.DeletedProductOutput);
        }

        public IDataResult<List<ProductOutput>> GetById(int id)
        {
            return new SuccessDataResult<List<ProductOutput>>(_productOutputDal.GetAll(p => p.Id == id));
        }

        public IDataResult<List<ProductOutputDto>> GetDetail()
        {
            return new SuccessDataResult<List<ProductOutputDto>>(_productOutputDal.GetProductOutputDetails(), Messages.ListedProductOutput);
        }

        public IResult Update(ProductOutput productOutput)
        {
            _productOutputDal.Update(productOutput);
            return new SuccessResult(Messages.UpdatedProductOutput);
        }
    }
}

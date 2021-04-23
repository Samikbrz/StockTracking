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
    public class ProductAcceptanceManager : IProductAcceptanceService
    {
        private IProductAcceptanceDal _productAcceptanceDal;
        public ProductAcceptanceManager(IProductAcceptanceDal productAcceptanceDal)
        {
            _productAcceptanceDal = productAcceptanceDal;
        }
        public IResult Add(ProductAcceptance productAcceptance)
        {
            _productAcceptanceDal.Add(productAcceptance);
            return new SuccessResult(Messages.AddedProductAcceptance);
        }

        public IResult Delete(ProductAcceptance productAcceptance)
        {
            _productAcceptanceDal.Delete(productAcceptance);
            return new SuccessResult(Messages.DeletedProductAcceptance);
        }

        public IDataResult<List<ProductAcceptance>> GetAll()
        {
            return new SuccessDataResult<List<ProductAcceptance>>(_productAcceptanceDal.GetAll(), Messages.ListedProductAcceptance);
        }

        public IResult Update(ProductAcceptance productAcceptance)
        {
            _productAcceptanceDal.Update(productAcceptance);
            return new SuccessResult(Messages.UpdatedProductAcceptance);
        }
    }
}

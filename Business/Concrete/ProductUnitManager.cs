using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductUnitManager : IProductUnitService
    {
        IProductUnitDal _productUnitDal;
        public ProductUnitManager(IProductUnitDal productUnitDal)
        {
            productUnitDal = _productUnitDal;
        }
        public IResult Add(ProductUnit productUnit)
        {
            if (productUnit.ProductUnitName.Length>2)
            {
                _productUnitDal.Add(productUnit);
                return new SuccessResult(Messages.ProductUnitAdded);
            }
            return new ErrorResult(Messages.ProductUnitNameInvalid);
        }

        public IResult Delete(ProductUnit productUnit)
        {
            _productUnitDal.Delete(productUnit);
            return new SuccessResult("Deleted product unit");
        }

        public IDataResult<List<ProductUnit>> GetAll()
        {
            if (DateTime.Now.Hour == 2)
            {
                return new ErrorDataResult<List<ProductUnit>>(Messages.MaintenaceTime);
            }
            return new SuccessDataResult<List<ProductUnit>>(_productUnitDal.GetAll(), Messages.ProductUnitsListed);
        }

        public IResult Update(ProductUnit productUnit)
        {
            _productUnitDal.Update(productUnit);
            return new SuccessResult("Updated product unit");
        }
    }
}

using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductUnitManager : IProductUnitService
    {
        private IProductUnitDal _productUnitDal;
        private IStockStoreDal _stockStoreDal;
        public ProductUnitManager(IProductUnitDal productUnitDal,IStockStoreDal stockStoreDal)
        {
            _productUnitDal = productUnitDal;
            _stockStoreDal = stockStoreDal;
        }
        
        [ValidationAspect(typeof(ProductUnitValidator))]
        [CacheRemoveAspect("IProductUnitService.Get")]
        [SecuredOperation("admin")]
        public IResult Add(ProductUnit productUnit)
        {
            IResult result = BusinessRules.Run(CheckProductUnitNamaExist(productUnit.ProductUnitName));
            if (result != null)
            {
                return result;
            }

            _productUnitDal.Add(productUnit);
            return new SuccessResult(Messages.ProductUnitAdded);
        }        

        [CacheRemoveAspect("IProductUnitService.Get")]
        [SecuredOperation("admin")]
        public IResult Delete(ProductUnit productUnit)
        {
            var result = _stockStoreDal.Get(p => p.ProductUnitId == productUnit.Id);
            if (result.Count!=0)
            {
                return new ErrorResult(Messages.ProductUnitDoesNotDeleted);
            }
            _productUnitDal.Delete(productUnit);
            return new SuccessResult(Messages.DeletedProductUnit);
        }

        [CacheAspect]
        [PerformanceAspect(5)]        
        public IDataResult<List<ProductUnit>> GetAll()
        {
            return new SuccessDataResult<List<ProductUnit>>(_productUnitDal.GetAll(), Messages.ProductUnitsListed);
        }
                
        public IDataResult<List<ProductUnit>> GetById(int id)
        {
            return new SuccessDataResult<List<ProductUnit>>(_productUnitDal.GetAll(x => x.Id == id));
        }

        [CacheRemoveAspect("IProductUnitService.Get")]
        [SecuredOperation("admin,employee")]
        public IResult Update(ProductUnit productUnit)
        {
            _productUnitDal.Update(productUnit);
            return new SuccessResult(Messages.UpdatedProductUnit);
        }

        private IResult CheckProductUnitNamaExist(string productUnitName)
        {
            var result = _productUnitDal.GetAll(p => p.ProductUnitName == productUnitName).Any();
            if (result)
            {
                return new ErrorResult(Messages.ProductUnitNameAlreadyExist);
            }
            return new SuccessResult();
        }
    }
}

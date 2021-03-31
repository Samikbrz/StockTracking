using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidaiton;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
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
		IProductUnitDal _productUnitDal;       
		public ProductUnitManager(IProductUnitDal productUnitDal)
		{
			_productUnitDal = productUnitDal;
		}

		[ValidationAspect(typeof(ProductUnitValidator))]
		public IResult Add(ProductUnit productUnit)
		{			
			_productUnitDal.Add(productUnit);
			return new SuccessResult(Messages.ProductUnitAdded);			
		}

		public IResult Delete(ProductUnit productUnit)
		{
			_productUnitDal.Delete(productUnit);
			return new SuccessResult("Deleted product unit");
		}

		public IDataResult<List<ProductUnit>> GetAll()
		{		
			return new SuccessDataResult<List<ProductUnit>>(_productUnitDal.GetAll(), Messages.ProductUnitsListed);
		}

		public IResult Update(ProductUnit productUnit)
		{
			_productUnitDal.Update(productUnit);
			return new SuccessResult("Updated product unit");
		}
	}
}

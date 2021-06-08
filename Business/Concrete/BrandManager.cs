using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        [SecuredOperation("admin")]
        public IResult Add(Brand brand)
        {
            var result = _brandDal.GetAll(b => b.BrandName == brand.BrandName);
            if (result!=null)
            {
                return new ErrorResult(Messages.BrandAlreadyExist);
            }
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        [SecuredOperation("admin")]
        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {          
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandsListed);
        }

        public IDataResult<List<Brand>> GetById(int id)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(b=>b.Id==id), Messages.BrandsListed);
        }

        [SecuredOperation("admin,employee")]
        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.UpdatedBrand);
        }
    }
}

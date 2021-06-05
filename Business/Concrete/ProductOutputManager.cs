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
        public ProductOutputManager(IProductOutputDal productOutputDal, IProductAcceptanceDal productAcceptanceDal)
        {
            _productOutputDal = productOutputDal;
            _productAcceptanceDal = productAcceptanceDal;
        }

        public IResult Add(ProductOutput productOutput)
        {
            List<ProductAcceptance> products = _productAcceptanceDal.GetAll(p => p.Id == productOutput.ProductAcceptanceId);
            for (int i = 0; i < products.Count; i++)
            {
                if (products.Count<productOutput.Count)
                {
                    return new ErrorResult(Messages.CountError);
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
            return new SuccessDataResult<List<ProductOutput>>(_productOutputDal.GetAll(p=>p.Id==id));
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

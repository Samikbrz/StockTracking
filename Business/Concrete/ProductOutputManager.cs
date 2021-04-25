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
    public class ProductOutputManager : IProductOutputService
    {
        private IProductOutputDal _productOutputDal;
        public ProductOutputManager(IProductOutputDal productOutputDal)
        {
            _productOutputDal = productOutputDal;
        }

        public IResult Add(ProductOutput productOutput)
        {
            _productOutputDal.Add(productOutput);
            return new SuccessResult(Messages.AddedProductOutput);
        }

        public IResult Delete(ProductOutput productOutput)
        {
            _productOutputDal.Delete(productOutput);
            return new SuccessResult(Messages.DeletedProductOutput);
        }

        public IDataResult<IList<ProductOutput>> GetAll()
        {
            return new DataResult<IList<ProductOutput>>(_productOutputDal.GetAll(), Messages.ListedProductOutput);
        }

        public IResult Update(ProductOutput productOutput)
        {
            _productOutputDal.Update(productOutput);
            return new SuccessResult(Messages.UpdatedProductOutput);
        }
    }
}

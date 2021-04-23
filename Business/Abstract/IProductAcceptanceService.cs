using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductAcceptanceService
    {
        IDataResult<List<ProductAcceptance>> GetAll();
        IResult Add(ProductAcceptance productAcceptance);
        IResult Update(ProductAcceptance productAcceptance);
        IResult Delete(ProductAcceptance productAcceptance);
    }
}

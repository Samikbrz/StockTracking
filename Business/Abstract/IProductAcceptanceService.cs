using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductAcceptanceService
    {
        IDataResult<List<ProductAcceptance>> GetAll();
        IDataResult<List<ProductAcceptance>> GetById(int id);
        IDataResult<List<ProductAcceptanceDto>> GetDetail();
        IResult Add(ProductAcceptance productAcceptance);
        IResult Update(ProductAcceptance productAcceptance);
        IResult Delete(ProductAcceptance productAcceptance);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductOutputService
    {
        IDataResult<List<ProductOutputDto>> GetDetail();
        IDataResult<List<ProductOutput>> GetById(int id);
        IResult Add(ProductOutput productOutput);
        IResult Update(ProductOutput productOutput);
        IResult Delete(ProductOutput productOutput);
    }
}

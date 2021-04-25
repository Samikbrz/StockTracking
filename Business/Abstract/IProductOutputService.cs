using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductOutputService
    {
        IDataResult<List<ProductOutput>> GetAll();
        IResult Add(ProductOutput productOutput);
        IResult Update(ProductOutput productOutput);
        IResult Delete(ProductOutput productOutput);
    }
}

using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductUnitService
    {
        IDataResult<List<ProductUnit>> GetAll();
        IResult Add(ProductUnit productUnit);
        IResult Update(ProductUnit productUnit);
        IResult Delete(ProductUnit productUnit);        
        IDataResult<List<ProductUnit>> GetById(int id);
    }
}

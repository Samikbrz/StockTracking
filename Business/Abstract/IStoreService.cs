using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IStoreService
    {
        IDataResult<List<Store>> GetAll();
        IDataResult<List<Store>> GetById(int id);
        IResult Add(Store store);
        IResult Update(Store store);
        IResult Delete(Store store);
    }
}

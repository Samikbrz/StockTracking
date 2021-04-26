using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IShelfService
    {
        IDataResult<List<Shelf>> GetAll();
        IResult Add(Shelf shelf);
        IResult Update(Shelf shelf);
        IResult Delete(Shelf shelf);
    }
}

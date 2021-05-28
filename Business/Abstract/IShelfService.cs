using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IShelfService
    {
        IDataResult<List<Shelf>> GetAll();
        IDataResult<List<Shelf>> GetById(int id);
        IDataResult<List<ShelfDto>> GetDetail();
        IResult Add(Shelf shelf);
        IResult Update(Shelf shelf);
        IResult Delete(Shelf shelf);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IDrawerService
    {
        IDataResult<List<Drawer>> GetAll();
        IResult Add(Drawer drawer);
        IResult Update(Drawer drawer);
        IResult Delete(Drawer drawer);
    }
}

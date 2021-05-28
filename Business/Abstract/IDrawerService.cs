using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IDrawerService
    {
        IDataResult<List<Drawer>> GetAll();
        IDataResult<List<Drawer>> GetById(int id);
        IDataResult<List<DrawerDto>> GetDetail();
        IResult Add(Drawer drawer);
        IResult Update(Drawer drawer);
        IResult Delete(Drawer drawer);
    }
}

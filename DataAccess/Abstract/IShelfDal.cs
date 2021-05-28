using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IShelfDal : IEntityRepository<Shelf>
    {
        List<ShelfDto> GetShelfDetails();
    }
}

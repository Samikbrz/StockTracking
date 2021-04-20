using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDrawerDal : ImEntityRepositoryBase<Drawer,StockTrackingContext>,IDrawerDal
    {
    }
}

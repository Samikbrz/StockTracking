using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDrawerDal : ImEntityRepositoryBase<Drawer, StockTrackingContext>, IDrawerDal
    {
        public List<DrawerDto> GetDrawerDetails()
        {
            using (StockTrackingContext context = new StockTrackingContext())
            {
                var result = from drawer in context.Drawers
                             join shelf in context.Shelves
                             on drawer.ShelfId equals shelf.Id
                             select new DrawerDto
                             {
                                 Id = drawer.Id,
                                 ShelfName = shelf.ShelfName,
                                 DrawerName = drawer.DrawerName
                             };
                return result.ToList();
            }
        }
    }
}

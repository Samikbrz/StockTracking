using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfShelfDal : EfEntityRepositoryBase<Shelf, StockTrackingContext>, IShelfDal
    {
        public List<ShelfDto> GetShelfDetails()
        {
            using (StockTrackingContext context = new StockTrackingContext())
            {
                var result = from shelf in context.Shelves
                             join store in context.Stores
                             on shelf.StoreId equals store.Id
                             select new ShelfDto
                             {
                                Id=shelf.Id,
                                ShelfName=shelf.ShelfName,
                                StoreName=store.StoreName
                             };
                return result.ToList();
            }
        }
    }
}

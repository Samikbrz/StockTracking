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
    public class EfStockStoreDal : EfEntityRepositoryBase<StockStore, StockTrackingContext>, IStockStoreDal
    {
        public List<StockStoreDto> GetStockStoreDetails()
        {
            using (StockTrackingContext context = new StockTrackingContext())
            {
                var result = from stockstore in context.StockStores
                             join store in context.Stores
                             on stockstore.StoreId equals store.Id
                             join shelf in context.Shelves
                             on stockstore.ShelfId equals shelf.Id
                             join drawer in context.Drawers
                             on stockstore.DrawerId equals drawer.Id
                             select new StockStoreDto
                             {
                                 Id = stockstore.Id,
                                 Barcode = stockstore.Barcode,
                                 Count=stockstore.Count,
                                 Currency=stockstore.Currency,
                                 DrawerName=drawer.DrawerName,
                                 ProductName=stockstore.ProductName,
                                 ShelfName=shelf.ShelfName,
                                 StoreName=store.StoreName,
                                 UnitPrice=stockstore.UnitPrice
                             };
                return result.ToList();
            }
        }
    }
}

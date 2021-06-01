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
    public class EfStoreTransferDal : EfEntityRepositoryBase<StoreTransfer, StockTrackingContext>, IStoreTransferDal
    {
        public List<StoreTransferDto> GetStoreTransferDetails()
        {
            using (StockTrackingContext context = new StockTrackingContext())
            {
                var result = from storetransfer in context.StoreTransfers
                             join user in context.Users
                             on storetransfer.UserId equals user.Id
                             join store in context.Stores
                             on storetransfer.SourceStoreId equals store.Id
                             join shelf in context.Shelves
                             on storetransfer.SourceShelfId equals shelf.Id
                             join drawer in context.Drawers
                             on storetransfer.SourceDrawerId equals drawer.Id
                             join targetstore in context.Stores
                             on storetransfer.TargetStoreId equals targetstore.Id
                             join targetshelf in context.Shelves
                             on storetransfer.TargetShelfId equals targetshelf.Id
                             join targetdrawer in context.Drawers
                             on storetransfer.TargetDrawerId equals targetdrawer.Id
                             select new StoreTransferDto
                             {     
                                 Id=storetransfer.Id,
                                 Date=storetransfer.Date,
                                 SourceDrawerName=drawer.DrawerName,
                                 TargetDrawerName=targetdrawer.DrawerName,
                                 SourceShelfName=shelf.ShelfName,
                                 TargetShelfName=targetshelf.ShelfName,
                                 SourceStoreName=store.StoreName,
                                 TergetStoreName=targetstore.StoreName,
                                 TransferNo=storetransfer.TransferNo,
                                 UserName = user.FirstName + " " + user.LastName,                                 
                             };
                return result.ToList();
            }
        }
    }
}

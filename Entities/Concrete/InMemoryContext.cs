using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class InMemoryContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stock>().HasOne<Brand>(s => s.Brand).WithOne(q => q.Stock).HasForeignKey<Brand>(q => q.BrandOfStockId);
            modelBuilder.Entity<Stock>().HasOne<Model>(s => s.Model).WithOne(q => q.Stock).HasForeignKey<Model>(q => q.ModelOfStockId);
            modelBuilder.Entity<StockStore>().HasOne<Drawer>(s => s.Drawer).WithMany(q => q.StockStores).HasForeignKey(q => q.CurrentDrawerId);
            modelBuilder.Entity<StockStore>().HasOne<Shelf>(s => s.Shelf).WithMany(q => q.StockStores).HasForeignKey(q => q.CurrentShelfId);
            modelBuilder.Entity<StockStore>().HasOne<Store>(s => s.Store).WithOne(q => q.StockStore).HasForeignKey<Store>(q => q.StoreOfStockStoreId);
            modelBuilder.Entity<Proposal>().HasOne<Company>(s => s.Company).WithOne(q => q.Proposal).HasForeignKey<Company>(q => q.CompanyOfProposalId);
            modelBuilder.Entity<ProductOutput>().HasOne<Company>(s => s.Company).WithMany(q => q.ProductOutputs).HasForeignKey(q => q.CurrentCompanyId);            
            modelBuilder.Entity<ProductAcceptance>().HasOne<Company>(s => s.Company).WithMany(q => q.ProductAcceptances).HasForeignKey(q => q.CurrrentCompanyId);
            modelBuilder.Entity<Drawer>().HasOne<Shelf>(s => s.Shelf).WithMany(q => q.Drawers).HasForeignKey(q => q.CurrentShelfId);
            modelBuilder.Entity<Shelf>().HasOne<Store>(s => s.Store).WithMany(q => q.Shelves).HasForeignKey(q => q.CurrentStoreId);
            modelBuilder.Entity<StoreTransfer>().HasOne<Store>(s => s.StoreName).WithMany(q => q.StoreTransfers).HasForeignKey(q => q.CurrentStoreId);
            modelBuilder.Entity<StoreTransfer>().HasOne<Drawer>(s => s.DrawerName).WithMany(q => q.StoreTransfers).HasForeignKey(q => q.CurrentDrawerId);
            modelBuilder.Entity<StoreTransfer>().HasOne<Shelf>(s => s.ShelfName).WithMany(q => q.StoreTransfers).HasForeignKey(q => q.CurrentShelfId);
            modelBuilder.Entity<StoreTransfer>().HasOne<Store>(s => s.TargetStore).WithMany(q => q.StoreTransfers).HasForeignKey(q => q.CurrentTargetStoreId);
            modelBuilder.Entity<StoreTransfer>().HasOne<Drawer>(s => s.TargetDrawer).WithMany(q => q.StoreTransfers).HasForeignKey(q => q.CurrentTargetDrawerId);
            modelBuilder.Entity<StoreTransfer>().HasOne<Shelf>(s => s.TargetShelf).WithMany(q => q.StoreTransfers).HasForeignKey(q => q.CurrentTargetShelfId);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class InMemoryContext : DbContext
    {
        List<ProductUnit> _productUnits;
        public InMemoryContext()
        {
            _productUnits = new List<ProductUnit>
            {
                new ProductUnit{ProductUnitId=1, ProductUnitName="Şişe" },
                new ProductUnit{ProductUnitId=1, ProductUnitName="Kutu" },
                new ProductUnit{ProductUnitId=1, ProductUnitName="Kova"}
            };
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().HasOne<Stock>(s => s.Stock).WithMany(q => q.Brands).HasForeignKey(q => q.BrandOfStockId);
            modelBuilder.Entity<Model>().HasOne<Stock>(s => s.Stock).WithMany(q => q.Models).HasForeignKey(q => q.ModelOfStockId);
            modelBuilder.Entity<StockStore>().HasOne<Drawer>(s => s.Drawer).WithMany(q => q.StockStores).HasForeignKey(q => q.CurrentDrawerId);
            modelBuilder.Entity<StockStore>().HasOne<Shelf>(s => s.Shelf).WithMany(q => q.StockStores).HasForeignKey(q => q.CurrentShelfId);
            modelBuilder.Entity<StockStore>().HasOne<Store>(s => s.Store).WithOne(q => q.StockStore).HasForeignKey<Store>(q => q.StoreOfStockStoreId);
            modelBuilder.Entity<Proposal>().HasOne<Company>(s => s.Company).WithOne(q => q.Proposal).HasForeignKey<Company>(q => q.CompanyOfProposalId);
            modelBuilder.Entity<ProductOutput>().HasOne<Company>(s => s.Company).WithMany(q => q.ProductOutputs).HasForeignKey(q => q.CurrentCompanyId);            
            modelBuilder.Entity<ProductAcceptance>().HasOne<Company>(s => s.Company).WithMany(q => q.ProductAcceptances).HasForeignKey(q => q.CurrrentCompanyId);
            modelBuilder.Entity<Drawer>().HasOne<Shelf>(s => s.Shelf).WithMany(q => q.Drawers).HasForeignKey(q => q.CurrentShelfId);
            modelBuilder.Entity<Shelf>().HasOne<Store>(s => s.Store).WithMany(q => q.Shelves).HasForeignKey(q => q.CurrentStoreId);
            modelBuilder.Entity<StoreTransfer>().HasOne<Store>(s => s.Store).WithOne(ad => ad.StoreTransfer).HasForeignKey<Store>(ad => ad.StoreOfStoreTranferId);
            modelBuilder.Entity<StoreTransfer>().HasOne<Store>(s => s.TargetStore).WithOne(ad => ad.TargetStoreTransfer).HasForeignKey<Store>(ad => ad.TargetStoreOfStoreTranferId);
            modelBuilder.Entity<StoreTransferDrawer>().HasKey(sd => new { sd.DrawerId, sd.StockStoreId });
            modelBuilder.Entity<StoreTransferTargetDrawer>().HasKey(sc => new { sc.TargetDrawerId, sc.StockStoreId });
            modelBuilder.Entity<StoreTransferShelf>().HasKey(s => new { s.ShelfId, s.StockStoreId });
            modelBuilder.Entity<StoreTransferTargetShelf>().HasKey(sc => new { sc.TargetShelfId, sc.StockStoreId });
        }       

        public DbSet<ProductUnit> productUnits { get; set; }
    }
}

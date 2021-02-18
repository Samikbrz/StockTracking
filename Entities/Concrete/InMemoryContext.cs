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
            modelBuilder.Entity<Stock>()
                .HasOne<Brand>(s => s.Brand)
                .WithOne(q => q.Stock)
                .HasForeignKey<Brand>(q => q.BrandOfStockId);

            modelBuilder.Entity<Stock>()
                .HasOne<Model>(s => s.Model)
                .WithOne(q => q.Stock)
                .HasForeignKey<Model>(q => q.ModelOfStockId);

            modelBuilder.Entity<StockStore>()
                .HasOne<Store>(s => s.Store)
                .WithOne(q => q.StockStore)
                .HasForeignKey<Store>(q => q.StoreOfStockStoreId);

            modelBuilder.Entity<Proposal>()
               .HasOne<Company>(s => s.Company)
               .WithOne(q => q.Proposal)
               .HasForeignKey<Company>(q => q.CompanyOfProposalId);

            modelBuilder.Entity<ProductOutput>()
              .HasOne<Company>(s => s.Company)
              .WithMany(q => q.ProductOutputs)
              .HasForeignKey(q => q.CurrentCompanyId);

            modelBuilder.Entity<StockStore>()
              .HasOne<Drawer>(s => s.Drawer)
              .WithMany(q => q.StockStores)
              .HasForeignKey(q => q.CurrentDrawerId);

            modelBuilder.Entity<StockStore>()
              .HasOne<Shelf>(s => s.Shelf)
              .WithMany(q => q.StockStores)
              .HasForeignKey(q => q.CurrentShelfId);

        }
    }
}

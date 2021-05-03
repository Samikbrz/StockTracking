using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class StockTrackingContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-PNM2HK3;Database=StockTracking;Trusted_Connection=true");
        }

        public DbSet<ProductUnit> ProductUnits { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Proposal> Proposals { get; set; }
        public DbSet<Drawer> Drawers { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public DbSet<ProductAcceptance> ProductAcceptances { get; set; }
        public DbSet<ProductOutput> ProductOutputs { get; set; }
        public DbSet<ExchangeRate> ExchangeRates { get; set; }
        public DbSet<StockStore> StockStores { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockKind> StockKinds { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}

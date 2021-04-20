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
	
		public DbSet<ProductUnit> ProductUnit{ get; set; }
		public DbSet<Brand> Brand{ get; set; }
		public DbSet<Company> Company{ get; set; }
		public DbSet<Proposal> Proposal{ get; set; }
		public DbSet<Drawer> Drawer{ get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}

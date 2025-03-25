using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W11D1C1.Data
{
    public class ProductContext : DbContext {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) {
            Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; } // table that gets created

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Product>().HasData(GetProducts());
            base.OnModelCreating(modelBuilder);
        }

        private Product[] GetProducts() {
            return new Product[]{
                new Product { Id = 1, Name = "LAPTOP", Description = "MACBOOK PRO", Price = 1600, Units = 1 },
                new Product { Id = 2, Name = "PHONE", Description = "IPHONE 16 PRO", Price = 900, Units = 2 },
                new Product { Id = 3, Name = "CONTROLLER", Description = "XBOX", Price = 60, Units = 6 },
                new Product { Id = 4, Name = "TABLET", Description = "IPAD", Price = 800, Units = 2 },
                new Product { Id = 5, Name = "TV", Description = "SAMSUNG", Price = 2200, Units = 1 },
            };
        }
    }
}

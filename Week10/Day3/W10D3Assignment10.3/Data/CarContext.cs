using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W10D3Assignment10._3.Models;

namespace W10D3Assignment10._3.Data {
    public class CarContext : DbContext {
        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("data source=LAPTOPW;initial catalog=PCAD16Cars;integrated security=True;encrypt=False;trustservercertificate=True;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Car>().HasData(
                new Car { CarID = 1, Make = "Tesla", Model = "3", Price = 32000.00, Vin = 153223211, Year = 2021 },
                new Car { CarID = 2, Make = "Tesla", Model = "S", Price = 80000.00, Vin = 199223212, Year = 2021 },
                new Car { CarID = 3, Make = "Tesla", Model = "X", Price = 90000.00, Vin = 121323213, Year = 2021 },
                new Car { CarID = 4, Make = "Tesla", Model = "Y", Price = 40000.00, Vin = 123423214, Year = 2021 }
                );
        }
    }
}

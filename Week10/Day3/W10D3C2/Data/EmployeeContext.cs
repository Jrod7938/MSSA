using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W10D3C2.Models;

namespace W10D3C2.Data {
    public class EmployeeContext : DbContext { // db
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("data source=LAPTOPW;initial catalog=PCAD16Employees;integrated security=True;encrypt=False;trustservercertificate=True;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Department>().HasData(
                new Department {  DepartmentID = 1, DepartmentName = "HR" },
                new Department { DepartmentID = 2, DepartmentName = "Marketing" },
                new Department { DepartmentID = 3, DepartmentName = "Tech" }
                );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmpId = 101, Name = "Jancarlos", Salary = 145000, DepartmentID = 3 },
                new Employee { EmpId = 102, Name = "Billy", Salary = 100000, DepartmentID = 1 },
                new Employee { EmpId = 103, Name = "Tiffany", Salary = 92000, DepartmentID = 2 }
                );
        }

    }
}

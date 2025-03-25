using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W11D1Assignment11._1.Data {
    public class BookContext : DbContext {
        public DbSet<Book> Books { get; set; }

        public BookContext(DbContextOptions<BookContext> options) : base(options) {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Book>().HasKey(b => b.ISBN);
            modelBuilder.Entity<Book>().HasData(
                new Book { ISBN = "9780134685991", Name = "Effective Java", Author = "Joshua Bloch", Description = "Java programming best practices" },
                new Book { ISBN = "9781492078005", Name = "Learning C#", Author = "Jesse Liberty", Description = "Beginner C# guide" }
                );
        }

    }
}

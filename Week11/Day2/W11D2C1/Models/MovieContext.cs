using Microsoft.EntityFrameworkCore;

namespace W11D2C1.Models {
    public class MovieContext: DbContext {
        public DbSet<Movie> Movies { get; set; }

        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieID = 1, Title = "Sharknado", ReleaseYear = 2007, Rating = 5.8f, SuggestedAudience = "R"},
                new Movie { MovieID = 2, Title = "Inception", ReleaseYear = 2016, Rating = 9.8f, SuggestedAudience = "R"},
                new Movie { MovieID = 3, Title = "Tenet", ReleaseYear = 2020, Rating = 9.4f, SuggestedAudience = "R"}
                );
        }

    }
}

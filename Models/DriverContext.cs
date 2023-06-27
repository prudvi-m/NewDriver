using Microsoft.EntityFrameworkCore;

namespace Drivers.Models
{
    public class DriverContext : DbContext
    {
        public DriverContext(DbContextOptions<DriverContext> options)
            : base(options)
        { }

        public DbSet<Driver> Drivers { get; set; } 
        public DbSet<Genre> Genres { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = "A", FirstName = "Action" },
                new Genre { GenreId = "C", FirstName = "Comedy" },
                new Genre { GenreId = "D", FirstName = "Drama" },
                new Genre { GenreId = "H", FirstName = "Horror" },
                new Genre { GenreId = "M", FirstName = "Musical" },
                new Genre { GenreId = "R", FirstName = "RomCom" },
                new Genre { GenreId = "S", FirstName = "SciFi" }
            );
            
            modelBuilder.Entity<Driver>().HasData(
                new Driver {
                    DriverId = 4,
                    FirstName = "Casablanca",
                    LastName = "ok"
                    Year = 1942,
                    Rating = 5,
                    GenreId = "D"
                },
                new Driver {
                    DriverId = 2,
                    FirstName = "Wonder Woman",
                    LastName = "ok"
                    Year = 2017,
                    Rating = 3,
                    GenreId = "A"
                },
                new Driver {
                    DriverId = 3,
                    FirstName = "Moonstruck",
                    LastName = "ok"
                    Year = 1988,
                    Rating = 4,
                    GenreId = "R"
                }
            );
        }
    }
}
using Microsoft.EntityFrameworkCore;

namespace Drivers.Models
{
    public class DriverContext : DbContext
    {
        public DriverContext(DbContextOptions<DriverContext> options)
            : base(options)
        { }

        public DbSet<Driver> Drivers { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Driver>().HasData(
                new Driver {
                    DriverId = 4,
                    FirstName = "Casablanca",
                    LastName = "ok",
                    SSN = 1942,
                    Phone = "53456435"
                },
                new Driver {
                    DriverId = 2,
                    FirstName = "Wonder Woman",
                    LastName = "ok",
                    SSN = 2017,
                    Phone = "33456435"
                },
                new Driver {
                    DriverId = 3,
                    FirstName = "Moonstruck",
                    LastName = "ok",
                    SSN = 1988,
                    Phone = "43456435"
                }
            );
        }
    }
}
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
                    DriverId = 1,
                    FirstName = "Johnson",
                    LastName = "Mitchel",
                    Address = "NY",
                    SSN = 2353453,
                    Phone = "1221221221",
                    DateOfBirth = DateTime.Parse("1989-12-12")
                },
                new Driver {
                    DriverId = 2,
                    FirstName = "Mitchel",
                    LastName = "Strac",
                    Address = "Sydney",
                    SSN = 456435,
                    Phone = "2121212121",
                    DateOfBirth = DateTime.Parse("1992-10-10")
                },
                new Driver {
                    DriverId = 3,
                    FirstName = "Breet",
                    LastName = "Lee",
                    Address = "Brisbane",
                    SSN = 23123234,
                    Phone = "7676767676",
                    DateOfBirth = DateTime.Parse("1990-11-11")
                }
            );
        }
    }
}
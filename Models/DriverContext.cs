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
                    FirstName = "Vinod",
                    LastName = "Chilaka",
                    Address = "Chicago",
                    SSN = 34532434,
                    Phone = "53456435",
                    Dob = "01/01/1998"
                }
            );
        }
    }
}
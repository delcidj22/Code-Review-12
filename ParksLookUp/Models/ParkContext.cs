using Microsoft.EntityFrameworkCore;

namespace ParksLookUp.Models
{
  public class ParkContext : DbContext
  {
    public ParkContext(DbContextOptions<ParkContext> options)
      : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Discovery Park", State = "Washington" },
          new Park { ParkId = 2, Name = "Yosemite", State = "California" },
          new Park { ParkId = 3, Name = "Grand Canyon National Park", State = "Arizona" },
          new Park { ParkId = 4, Name = "Olympic National Park", State = "Washington" },
          new Park { ParkId = 5, Name = "Fort Stevens", State = "Oregon" },
          new Park { ParkId = 6, Name = "Letchworth State Park", State = "New York" }
        );
    }

    public DbSet<Park> Parks { get; set; }
  }
}
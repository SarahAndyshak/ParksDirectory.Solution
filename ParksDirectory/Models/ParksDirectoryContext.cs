using Microsoft.EntityFrameworkCore;

namespace ParksDirectory.Models
{
  public class ParksDirectoryContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }

    public ParksDirectoryContext(DbContextOptions<ParksDirectoryContext>options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Crater Lake", Classification = "national park", Location = "Oregon", MajorLandmarks = "Crater Lake, Wizard Island", YearFounded = 1902 },
          
          new Park { ParkId = 2, Name = "Newberry National Volcanic Monument", Classification = "national monument", Location = "Oregon", MajorLandmarks = "Lava Butte, Lava River Cave, Lava Cast Forest, Newberry Caldera, Big Obsidian Flow, Paulina Peak, East Lake, Paulina Lake", YearFounded = 1990 },
          
          new Park { ParkId = 3, Name = "Smith Rock State Park", Classification = "state park", Location = "Oregon", MajorLandmarks = "Smith Rock", YearFounded = 1960 },
          
          new Park { ParkId = 4, Name = "Tumalo State Park", Classification = "state park", Location = "Oregon", MajorLandmarks = "Deschutes River Trail", YearFounded = 1954 },

          new Park { ParkId = 5, Name = "Deschutes National Forest", Classification = "national forest", Location = "Oregon", MajorLandmarks = "Mount Jefferson, Mount Washington, the Three Sisters, Lava Lands, Metolius River, Cascade Lakes", YearFounded = 1908 }
        );
    }
  }
}
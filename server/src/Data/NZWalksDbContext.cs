using dotnet_course.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace dotnet_course.Data
{
  public class NZWalksDbContext: DbContext
  {
    public NZWalksDbContext(DbContextOptions options): base(options)
    {
    }

    public DbSet<Difficulty> Difficulties { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Walk> Walks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var difficulties = new List<Difficulty>()
        {
           new Difficulty { Id = Guid.NewGuid(), Name = "Easy" },
           new Difficulty { Id = Guid.NewGuid(), Name = "Medium" },
           new Difficulty { Id = Guid.NewGuid(), Name = "Hard" }
        };

        modelBuilder.Entity<Difficulty>().HasData(difficulties);

        var regions = new List<Region>()
        {
            new Region { Id = Guid.NewGuid(), Name = "Northland", Code = "NL", RegionImageUrl = "https://www.doc.govt.nz/globalassets/images/conservation/parks-and-recreation/places-to-visit/northland/tauranga-bay.jpg" },
            new Region { Id = Guid.NewGuid(), Name = "Auckland", Code = "AK", RegionImageUrl = "https://www.doc.govt.nz/globalassets/images/conservation/parks-and-recreation/places-to-visit/auckland/auckland.jpg" },
            new Region { Id = Guid.NewGuid(), Name = "Waikato", Code = "WK", RegionImageUrl = "https://www.doc.govt.nz/globalassets/images/conservation/parks-and-recreation/places-to-visit/waikato/hamilton.jpg" },
            new Region { Id = Guid.NewGuid(), Name = "Bay of Plenty", Code = "BP", RegionImageUrl = "https://www.doc.govt.nz/globalassets/images/conservation/parks-and-recreation/places-to-visit/bay-of-plenty/mt-maunganui.jpg" },
            new Region { Id = Guid.NewGuid(), Name = "Gisborne", Code = "GB", RegionImageUrl = null },
        };

        modelBuilder.Entity<Region>().HasData(regions);
    }
  }
}

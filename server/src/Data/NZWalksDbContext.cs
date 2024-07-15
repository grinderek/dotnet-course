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
  }
}

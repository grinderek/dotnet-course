using dotnet_course.Data;
using dotnet_course.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace dotnet_course.Repositories
{
    public class PostgresRegionRepository : IRegionRepository
    {
        private readonly NZWalksDbContext dbContext;

        public PostgresRegionRepository(NZWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Region>> GetAllAsync()
        {
            return await dbContext.Regions.ToListAsync();
        }

        public async Task<Region?> GetByIdAsync(Guid id)
        {
            return await dbContext.Regions.FindAsync(id);
        }

        public async Task<Region> CreateAsync(Region region)
        {
            await dbContext.Regions.AddAsync(region);
            await dbContext.SaveChangesAsync();
            return region;
        }

        public async Task<Region?> UpdateAsync(Guid id, Region region)
        {
            var existingRegion = await dbContext.Regions.FindAsync(id);
            if (existingRegion == null)
            {
                return null;
            }

            existingRegion.Name = region.Name;
            existingRegion.Code = region.Code;
            existingRegion.RegionImageUrl = region.RegionImageUrl;

            await dbContext.SaveChangesAsync();
            return existingRegion;
        }

        public async Task<Region?> DeleteAsync(Guid id)
        {
            var region = await dbContext.Regions.FindAsync(id);
            if (region == null)
            {
                return null;
            }

            dbContext.Regions.Remove(region);
            await dbContext.SaveChangesAsync();
            return region;
        }
    }
}

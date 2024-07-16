using AutoMapper;
using dotnet_course.Data;
using dotnet_course.Models.Domain;
using dotnet_course.Models.Dto;
using dotnet_course.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet_course.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly NZWalksDbContext dbContext;
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(NZWalksDbContext dbContext, IRegionRepository regionRepository, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetRegions()
        {
            var regions = await regionRepository.GetAllAsync();

            var regionsDto = mapper.Map<List<RegionDto>>(regions);

            return Ok(regionsDto);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetRegionById(Guid id)
        {
            var region = await regionRepository.GetByIdAsync(id);

            if (region == null)
            {
                return NotFound();
            }

            var regionDto = mapper.Map<RegionDto>(region);

            return Ok(regionDto);
        }

        [HttpPost]
        public async Task<IActionResult> AddRegion([FromBody] AddRegionDto addRegionDto)
        {
            var region = mapper.Map<Region>(addRegionDto);
            await regionRepository.CreateAsync(region);

            var regionDto = mapper.Map<RegionDto>(region);
            return CreatedAtAction(nameof(GetRegionById), new { id = region.Id }, regionDto);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateRegion(Guid id, [FromBody] UpdateRegionDto updateRegionDto)
        {
            var region = mapper.Map<Region>(updateRegionDto);
            region = await regionRepository.UpdateAsync(id, region);
            
            if (region == null)
            {
                return NotFound();
            }

            var regionDto = mapper.Map<RegionDto>(region);
            return Ok(regionDto);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteRegion(Guid id)
        {
            var region = await regionRepository.DeleteAsync(id);

            if (region == null)
            {
                return NotFound();
            }

            var regionDto = mapper.Map<RegionDto>(region);
            return Ok(regionDto);
        }
    }
}

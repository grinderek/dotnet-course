using AutoMapper;
using dotnet_course.Models.Domain;
using dotnet_course.Models.Dto;

namespace dotnet_course.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<AddRegionDto, Region>();
            CreateMap<UpdateRegionDto, Region>();
        }
    }
}

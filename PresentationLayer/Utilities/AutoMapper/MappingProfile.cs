using AutoMapper;
using DtoLayer.Dtos.EnglishStoryDetailsDtos;
using DtoLayer.Dtos.EnglishStoryDtos;
using EntityLayer.Concrete;

namespace PresentationLayer.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EnglishUpdateStoryDto, EnglishStoryDetails>();
            CreateMap<EnglishStoryDetails, EnglishUpdateStoryDto>();

            CreateMap<EnglishStory, EnglishStoryDto>();
            CreateMap<EnglishStoryDto, EnglishStory>();
        
        }
    }
}

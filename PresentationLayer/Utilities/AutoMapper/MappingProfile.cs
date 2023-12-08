using AutoMapper;
using DtoLayer.Dtos.EnglishStoryDetailsDtos;
using EntityLayer.Concrete;

namespace PresentationLayer.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EnglishUpdateStoryDto, EnglishStoryDetails>().ReverseMap();
        
        }
    }
}

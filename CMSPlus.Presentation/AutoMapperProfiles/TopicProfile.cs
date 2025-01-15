using AutoMapper;
using CMSPlus.Domain.Entities;
using CMSPlus.Domain.Models.TopicModels;

namespace CMSPlus.Presentation.AutoMapperProfiles;

public class TopicProfile : Profile
{
    public TopicProfile()
    {
        CreateMap<TopicEntity, TopicModel>();
        CreateMap<TopicModel, TopicEntity>();
        CreateMap<TopicEntity, TopicDetailsModel>();
        CreateMap<TopicEntity, TopicCreateModel>();
        CreateMap<TopicCreateModel, TopicEntity>();
        CreateMap<TopicEntity, TopicEditModel>();
        CreateMap<TopicEditModel, TopicEntity>();
    }
}

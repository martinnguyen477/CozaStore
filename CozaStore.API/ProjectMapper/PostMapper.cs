namespace CozaStore.API.ProjectMapper
{
    using AutoMapper;
    using CozaStore.Model.EntitiesModel;
    using CozaStore.Model.Model;

    public class PostMapper : Profile
    {
        public PostMapper()
        {
            CreateMap<PostEntities, PostModel>();
            CreateMap<PostModel, PostEntities>();
        }
    }
}

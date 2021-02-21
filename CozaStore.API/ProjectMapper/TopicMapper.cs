using AutoMapper;
using CozaStore.Model.EntitiesModel;
using CozaStore.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CozaStore.API.ProjectMapper
{
    public class TopicMapper : Profile
    {
        public TopicMapper()
        {
            CreateMap<TopicEntities, TopicModel>();
            CreateMap<TopicModel, TopicEntities>();
        }
    }
}

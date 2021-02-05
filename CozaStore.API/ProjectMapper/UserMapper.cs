using AutoMapper;
using CozaStore.Model.EntitiesModel;
using CozaStore.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CozaStore.API.ProjectMapper
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<UserEntities, UserModel>();
            CreateMap<UserModel, UserEntities>();
        }
    }
}

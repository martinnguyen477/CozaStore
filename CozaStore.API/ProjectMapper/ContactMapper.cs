using System;
using CozaStore.Model.EntitiesModel;
using CozaStore.Model.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace CozaStore.API.ProjectMapper
{
    public class ContactMapper : Profile
    {
        public ContactMapper()
        {
            CreateMap<CategoryEntities, CategoryModel>();
            CreateMap<CategoryModel, CategoryEntities>();
        }
    }
}

using AutoMapper;
using CozaStore.Model.EntitiesModel;
using CozaStore.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CozaStore.API.ProjectMapper
{
    public class CategoryMapper : Profile
    {
        public CategoryMapper()
        {
            CreateMap<CategoryEntities, CategoryModel>();
            CreateMap<CategoryModel, CategoryEntities>();
        }
    }
}

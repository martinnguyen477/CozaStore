
using CozaStore.Model.Model;
using CozaStore.Model.EntitiesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CozaStore.Model.ResponseModel;

namespace CozaStore.API.ProjectMapper
{
    public class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<ProductEntities, ProductModel>();
            CreateMap<ProductModel,ProductEntities>();
            CreateMap<ProductEntities, ListProducts>();
            CreateMap<ListProducts, ProductEntities>();
        }
    }
}

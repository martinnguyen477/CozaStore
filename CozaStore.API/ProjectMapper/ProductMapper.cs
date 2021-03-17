// <copyright file="ProductMapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.API.ProjectMapper
{
    using AutoMapper;
    using CozaStore.Model.EntitiesModel;
    using CozaStore.Model.Model;
    using CozaStore.Model.ResponseModel;

    public class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<ProductEntities, ProductModel>();
            CreateMap<ProductModel, ProductEntities>();
            CreateMap<ProductEntities, ListProducts>();
            CreateMap<ListProducts, ProductEntities>();
        }
    }
}

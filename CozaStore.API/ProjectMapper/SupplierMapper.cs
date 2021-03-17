// <copyright file="SupplierMapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.API.ProjectMapper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using CozaStore.Model.EntitiesModel;
    using CozaStore.Model.Model;

    public class SupplierMapper : Profile
    {
        public SupplierMapper()
        {
            CreateMap<SupplierEntities, SupplierModel>();
            CreateMap<SupplierModel, SupplierEntities>();
        }
    }
}

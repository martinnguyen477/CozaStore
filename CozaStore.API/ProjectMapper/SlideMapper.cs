// <copyright file="SlideMapper.cs" company="PlaceholderCompany">
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

    public class SlideMapper : Profile
    {
        public SlideMapper()
        {
            CreateMap<SlideEntities, SlideModel>();
            CreateMap<SlideModel, SlideEntities>();
        }
    }
}

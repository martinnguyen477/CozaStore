// <copyright file="ContactMapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.API.ProjectMapper
{
    using AutoMapper;
    using CozaStore.Model.EntitiesModel;
    using CozaStore.Model.Model;

    public class ContactMapper : Profile
    {
        public ContactMapper()
        {
            CreateMap<ContactEntities, ContactModel>();
            CreateMap<ContactModel, ContactEntities>();
        }
    }
}

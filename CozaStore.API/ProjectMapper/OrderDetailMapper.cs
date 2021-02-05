using AutoMapper;
using CozaStore.Model.EntitiesModel;
using CozaStore.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CozaStore.API.ProjectMapper
{
    public class OrderDetailMapper : Profile
    {
        public OrderDetailMapper()
        {
            CreateMap<OrderDetailEntities, OrderDetailModel>();
            CreateMap<OrderDetailModel, OrderDetailEntities>();
        }
    }
}

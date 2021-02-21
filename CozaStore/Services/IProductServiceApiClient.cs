// <copyright file="IProductServiceApiClient.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.WebApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using CozaStore.Model.ResponseModel;

    public interface IProductServiceApiClient
    {
        Task<string> GetProducts();
    }
}

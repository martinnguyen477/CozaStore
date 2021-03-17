// <copyright file="ApplicationServicesExtensions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.API.StartUp
{
    using CozaStore.Services.Admin.ContactServices;
    using CozaStore.Services.PostServices;
    using CozaStore.Services.ProductServices;
    using Microsoft.Extensions.DependencyInjection;

    public static class ApplicationServicesExtensions
    {
        public static void AddApplicationServicesExtensions(this IServiceCollection services)
        {
            services.AddScoped<IProductServices, ProductServices>();
            services.AddScoped<IPostServices, PostServices>();
            services.AddScoped<IContactServices, ContactServices>();
        }
    }
}

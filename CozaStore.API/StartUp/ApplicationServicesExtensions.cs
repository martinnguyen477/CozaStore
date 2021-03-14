using CozaStore.Services.PostServices;
using CozaStore.Services.ProductServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CozaStore.API.StartUp
{
    public static class ApplicationServicesExtensions
    {
        public static void AddApplicationServicesExtensions(this IServiceCollection services)
        {
            services.AddScoped<IProductServices, ProductServices>();
            services.AddScoped<IPostServices, PostServices>();

        }
    }
}

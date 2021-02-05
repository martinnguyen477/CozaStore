// <copyright file="CozaStoreContextFactory.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Data.EntityContext
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;
    using Microsoft.Extensions.Configuration;

    public class CozaStoreContextFactory : IDesignTimeDbContextFactory<CozaStoreContext>
    {
        public CozaStoreContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("CozaStore");

            var optionsBuilder = new DbContextOptionsBuilder<CozaStoreContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new CozaStoreContext(optionsBuilder.Options);
        }
    }
}

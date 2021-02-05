// <copyright file="CozaStoreContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Data.EntityContext
{
    using CozaStore.Data.SeedDataDefault;
    using CozaStore.Model.EntitiesModel;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// CozaStoreContext.
    /// </summary>
    public class CozaStoreContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CozaStoreContext"/> class.
        /// CozaStoreContext.
        /// </summary>
        /// <param name="options">options. ok.</param>
        public CozaStoreContext(DbContextOptions options)
            : base(options)
        {
        }

        #region Table SQL

        public DbSet<CategoryEntities> Categorie { get; set; }

        public DbSet<ProductEntities> Product { get; set; }

        public DbSet<UserEntities> User { get; set; }

        public DbSet<OrderEntities> Order { get; set; }

        public DbSet<OrderDetailEntities> OrderDetail { get; set; }

        public DbSet<PostEntities> Post { get; set; }

        public DbSet<SlideEntities> Slide { get; set; }

        public DbSet<TopicEntities> Topic { get; set; }

        public DbSet<RoleEntities> Role { get; set; }

        public DbSet<SupplierEntities> Supplier { get; set; }

        #endregion

        /// <summary>
        /// OnModelCeating.
        /// </summary>
        /// <param name="modelbuilder">modelBuilder.</param>
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<ProductEntities>().ToTable("Product").HasKey(p => p.Id);
            modelbuilder.Entity<UserEntities>().ToTable("User").HasKey(u => u.Id);
            modelbuilder.Entity<CategoryEntities>().ToTable("Category").HasKey(c => c.Id);
            modelbuilder.Entity<ContactEntities>().ToTable("Contact").HasKey(c => c.Id);
            modelbuilder.Entity<OrderEntities>().ToTable("Order").HasKey(o => o.Id);
            modelbuilder.Entity<OrderDetailEntities>().ToTable("OrderDetail").HasKey(od => od.Id);
            modelbuilder.Entity<PostEntities>().ToTable("Post").HasKey(p => p.Id);
            modelbuilder.Entity<SlideEntities>().ToTable("Slide").HasKey(s => s.Id);
            modelbuilder.Entity<TopicEntities>().ToTable("Topic").HasKey(t => t.Id);
            modelbuilder.Entity<SupplierEntities>().ToTable("Supplier").HasKey(s => s.Id);
            modelbuilder.Entity<RoleEntities>().ToTable("Role").HasKey(r => r.Id);
            modelbuilder.SeedDataDefault();
        }
    }
}

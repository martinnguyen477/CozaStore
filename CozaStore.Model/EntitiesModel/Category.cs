// <copyright file="Category.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.EntitiesModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CozaStore.Model.BaseModel;

    /// <summary>
    /// Category.
    /// </summary>
    [Table("Category")]
    public class CategoryEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets categoryName.
        /// </summary>
        [Required]
        [Column("CategoryName")]
        public string CategoryName { get; set; }

        [Column("ParentId")]
        public int ParentId { get; set; }

        [Column("Orders")]
        public int Orders { get; set; }
    }
}

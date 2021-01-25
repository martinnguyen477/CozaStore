// <copyright file="Supplier.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.EntitiesModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;
    using CozaStore.Model.BaseModel;

    /// <summary>
    /// Supplier.
    /// </summary>
    [Table("Supplier")]
    public class SupplierEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets supplier .
        /// </summary>
        [Required]
        [Column("SupplierName")]
        public string SupplierName { get; set; }
    }
}

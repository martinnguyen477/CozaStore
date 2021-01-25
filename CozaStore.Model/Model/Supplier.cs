// <copyright file="Supplier.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.Model
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
    public class SupplierModel : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets supplier .
        /// </summary>
        public string SupplierName { get; set; }
    }
}

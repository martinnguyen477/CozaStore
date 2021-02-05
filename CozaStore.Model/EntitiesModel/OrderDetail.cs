// <copyright file="OrderDetail.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.EntitiesModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;
    using CozaStore.Model.BaseModel;

    /// <summary>
    /// OrderDetail.
    /// </summary>
    [Table("OrderDetail")]
    public class OrderDetailEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets orderId.
        /// </summary>
        [Column("OrderId")]
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets userId.
        /// </summary>
        [Column("ProductId")]
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets price.
        /// </summary>
        [Column("Price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets quantity.
        /// </summary>
        [Column("Quantity")]
        public decimal Quantity { get; set; }
    }
}

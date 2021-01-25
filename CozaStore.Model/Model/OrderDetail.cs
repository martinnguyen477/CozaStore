// <copyright file="OrderDetail.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;
    using CozaStore.Model.BaseModel;

    /// <summary>
    /// OrderDetail.
    /// </summary>
    public class OrderDetailModel : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets orderId.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets userId.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets price.
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// Gets or sets quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets total.
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Gets or sets discount.
        /// </summary>
        public int Discount { get; set; }

        /// <summary>
        /// Gets or sets billDate.
        /// </summary>
        public DateTime BillDate { get; set; }
    }
}

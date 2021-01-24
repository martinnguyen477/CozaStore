// <copyright file="OrderDetail.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.EntitiesModel
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using CozaStore.Model.BaseModel;

    /// <summary>
    /// OrderDetail.
    /// </summary>
    public class OrderDetail : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets orderId.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets userId.
        /// </summary>
        public int UserId { get; set; }

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
        /// Gets or sets size.
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Gets or sets color.
        /// </summary>
        public int Color { get; set; }

        /// <summary>
        /// Gets or sets shipDate.
        /// </summary>
        public DateTime ShipDate { get; set; }

        /// <summary>
        /// Gets or sets billDate.
        /// </summary>
        public DateTime BillDate { get; set; }
    }
}

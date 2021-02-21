// <copyright file="Order.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.EntitiesModel
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CozaStore.Model.BaseModel;

    /// <summary>
    /// Order.
    /// </summary>
    [Table("Order")]
    public class OrderEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets user Order .
        /// </summary>
        [Required]
        [Column("UserID")]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets adress delivery.
        /// </summary>
        [Required]
        [Column("ShipAddress")]
        public string ShipAdsress { get; set; }

        /// <summary>
        /// Gets or sets phone number delivery.
        /// </summary>
        [Required]
        [Column("ShipPhone")]
        public string ShipPhone { get; set; }

        /// <summary>
        /// Gets or sets phone number delivery.
        /// </summary>
        [Required]
        [Column("ShipEmail")]
        public string ShipEmail { get; set; }

        /// <summary>
        /// Gets or sets order date.
        /// </summary>
        [Required]
        [Column("OrderDate")]
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Gets or sets note order.
        /// </summary>
        [Column("Note")]
        public string Note { get; set; }
    }
}

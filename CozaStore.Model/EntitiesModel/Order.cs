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
        [Column("OrderShipAddress")]
        public string OrderShipAdsress { get; set; }

        /// <summary>
        /// Gets or sets phone number delivery.
        /// </summary>
        [Required]
        [Column("OrderShipPhone")]
        public string OrderShipPhone { get; set; }

        /// <summary>
        /// Gets or sets order date.
        /// </summary>
        [Required]
        [Column("OrderDate")]
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Gets or sets date delivery .
        /// </summary>
        [Column("ShipDate")]
        public DateTime ShipDate { get; set; }

        /// <summary>
        /// Gets or sets note order.
        /// </summary>
        [Column("Note")]
        public string Note { get; set; }
    }
}

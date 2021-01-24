// <copyright file="Order.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.EntitiesModel
{
    using System;
    using CozaStore.Model.BaseModel;

    /// <summary>
    /// Order.
    /// </summary>
    public class Order : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets user Order .
        /// </summary>
        public int UserOrderId { get; set; }

        /// <summary>
        /// Gets or sets adress delivery.
        /// </summary>
        public string OrderShipAdress { get; set; }

        /// <summary>
        /// Gets or sets phone number delivery.
        /// </summary>
        public string OrderShipPhone { get; set; }

        /// <summary>
        /// Gets or sets order date.
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Gets or sets date delivery .
        /// </summary>
        public string ShipDate { get; set; }

        /// <summary>
        /// Gets or sets note order.
        /// </summary>
        public string Note { get; set; }
    }
}

// <copyright file="ListProducts.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.ResponseModel
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ListProducts : BaseResponse
    {
        /// <summary>
        /// Gets or sets product in Category ? .
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets category Name.
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or sets product Name.
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or sets productDescription.
        /// </summary>
        public string ProductDescription { get; set; }

        /// <summary>
        /// Gets or sets price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets supplier.
        /// </summary>
        public int SupplierId { get; set; }

        /// <summary>
        /// Gets or sets image for product.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets quantity Product.
        /// </summary>
        public int Quantity { get; set; }
    }
}

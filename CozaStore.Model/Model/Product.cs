// <copyright file="Product.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CozaStore.Model.BaseModel;

    /// <summary>
    /// Product.
    /// </summary>
    public class ProductModel : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets product in Category ? .
        /// </summary>
        public int CategoryId { get; set; }

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
        public float Price { get; set; }

        /// <summary>
        /// Gets or sets supplier.
        /// </summary>
        public int SupplierId { get; set; }

        /// <summary>
        /// Gets or sets image for product.
        /// </summary>
        public string Image { get; set; }
    }
}

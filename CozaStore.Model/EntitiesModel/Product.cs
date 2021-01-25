// <copyright file="Product.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.EntitiesModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CozaStore.Model.BaseModel;

    /// <summary>
    /// Product.
    /// </summary>
    [Table("Product")]
    public class ProductEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets product in Category ? .
        /// </summary>
        [Column("CategoryId")]
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets product Name.
        /// </summary>
        [Required]
        [Column("ProductName")]
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or sets productDescription.
        /// </summary>
        [Column("Description")]
        public string ProductDescription { get; set; }

        /// <summary>
        /// Gets or sets price.
        /// </summary>
        [Column("Price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets supplier.
        /// </summary>
        [Column("SupplierId")]
        public int SupplierId { get; set; }

        /// <summary>
        /// Gets or sets image for product.
        /// </summary>
        [Column("Image")]
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets quantity Product.
        /// </summary>
        [Column("Quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets product size.
        /// </summary>
        [Column("Size")]
        public string Size { get; set; }

        /// <summary>
        /// Gets or sets product color.
        /// </summary>
        [Column("Color")]
        public string Color { get; set; }
    }
}

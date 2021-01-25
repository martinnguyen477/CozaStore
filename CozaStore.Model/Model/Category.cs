// <copyright file="Category.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CozaStore.Model.BaseModel;

    /// <summary>
    /// Category.
    /// </summary>
    public class CategoryModel : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets categoryName.
        /// </summary>
        public string CategoryName { get; set; }
    }
}

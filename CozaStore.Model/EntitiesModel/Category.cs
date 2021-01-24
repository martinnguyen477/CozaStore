// <copyright file="Category.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.EntitiesModel
{
    using CozaStore.Model.BaseModel;

    /// <summary>
    /// Category.
    /// </summary>
    public class Category : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets categoryName.
        /// </summary>
        public string CategoryName { get; set; }
    }
}

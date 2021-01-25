// <copyright file="Slide.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CozaStore.Model.BaseModel;

    /// <summary>
    /// Slide.
    /// </summary>
    public class SlideModel : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets slideName.
        /// </summary>
        public string SlideName { get; set; }
    }
}

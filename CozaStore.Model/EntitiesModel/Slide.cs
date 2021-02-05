// <copyright file="Slide.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.EntitiesModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CozaStore.Model.BaseModel;

    /// <summary>
    /// Slide.
    /// </summary>
    [Table("Slide")]
    public class SlideEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets slideName.
        /// </summary>
        [Required]
        [Column("SlideName")]
        public string SlideName { get; set; }

        public string Image { get; set; }

        public int Order { get; set; }
    }
}

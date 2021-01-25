// <copyright file="Contact.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.EntitiesModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CozaStore.Model.BaseModel;

    /// <summary>
    /// Contact.
    /// </summary>
    [Table("Contact")]
    public class ContactEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets contactTitle.
        /// </summary>
        [Required]
        [Column("ContactTitle")]
        public string ContactTitle { get; set; }

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        [Required]
        [Column("Email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [Required]
        [Column("Description")]
        public string Description { get; set; }
    }
}

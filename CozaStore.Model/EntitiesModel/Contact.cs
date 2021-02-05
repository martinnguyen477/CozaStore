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
        [Required]
        [MaxLength(200)]
        [Column("FullName")]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        [Required]
        [Column("Email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        [Required]
        [MaxLength(20)]
        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets contactTitle.
        /// </summary>
        [Required]
        [Column("ContactTitle")]
        public string ContactTitle { get; set; }

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [Required]
        [Column("Message")]
        [MaxLength(500)]
        public string Message { get; set; }
    }
}

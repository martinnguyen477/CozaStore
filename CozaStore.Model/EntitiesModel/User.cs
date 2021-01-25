// <copyright file="User.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.EntitiesModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CozaStore.Model.BaseModel;

    /// <summary>
    /// User.
    /// </summary>
    [Table("User")]
    public class UserEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets firstName.
        /// </summary>
        [Required]
        [Column("FirstName")]
        public string FirtName { get; set; }

        /// <summary>
        /// Gets or sets lastName.
        /// </summary>
        [Required]
        [Column("LastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        [Required]
        [Column("Email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets numberPhone.
        /// </summary>
        [Required]
        [Column("Phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets address.
        /// </summary>
        [Required]
        [Column("Address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets sex.
        /// </summary>
        [Required]
        [Column("Sex")]
        public string Sex { get; set; }

        /// <summary>
        /// Gets or sets birthDay.
        /// </summary>
        [Column("Birthday")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public string BirthDay { get; set; }

        /// <summary>
        /// Gets or sets userName.
        /// </summary>
        [Required]
        [Column("UserName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets password.
        /// </summary>
        [Required]
        [Column("Password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets access.
        /// </summary>
        [Column("Access")]
        public int Access { get; set; }
    }
}

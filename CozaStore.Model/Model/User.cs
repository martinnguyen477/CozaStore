// <copyright file="User.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CozaStore.Model.BaseModel;

    /// <summary>
    /// User.
    /// </summary>
    public class UserModel : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets firstName.
        /// </summary>
        public string FirtName { get; set; }

        /// <summary>
        /// Gets or sets lastName.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets numberPhone.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets sex.
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// Gets or sets birthDay.
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public string BirthDay { get; set; }

        /// <summary>
        /// Gets or sets userName.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets access.
        /// </summary>
        public int Access { get; set; }
    }
}

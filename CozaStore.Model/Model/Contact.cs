// <copyright file="Contact.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CozaStore.Model.BaseModel;

    /// <summary>
    /// Contact.
    /// </summary>
    public class ContactModel : BaseTableWithId
    {
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets contactTitle.
        /// </summary>
        public string ContactTitle { get; set; }

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        public string Message { get; set; }
    }
}

// <copyright file="Role.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.EntitiesModel
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class RoleEntities
    {
        /// <summary>
        /// Gets or sets roleId.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets access .
        /// </summary>
        public int Access { get; set; }

        /// <summary>
        /// Gets or sets accessName.
        /// </summary>
        public string AccessName { get; set; }

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        public string Decription { get; set; }
    }
}

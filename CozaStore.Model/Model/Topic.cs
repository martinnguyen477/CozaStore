// <copyright file="Topic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CozaStore.Model.BaseModel;

    /// <summary>
    /// Topic.
    /// </summary>
    public class TopicModel : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets topicName .
        /// </summary>
        public string TopicName { get; set; }
    }
}

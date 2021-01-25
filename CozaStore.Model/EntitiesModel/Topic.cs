// <copyright file="Topic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.EntitiesModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CozaStore.Model.BaseModel;

    /// <summary>
    /// Topic.
    /// </summary>
    [Table("Topic")]
    public class TopicEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets topicName .
        /// </summary>
        [Required]
        [Column("TopicName")]
        public string TopicName { get; set; }
    }
}

// <copyright file="Post.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.EntitiesModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CozaStore.Model.BaseModel;

    /// <summary>
    /// Post.
    /// </summary>
    [Table("Post")]
    public class PostEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets post Title.
        /// </summary>
        [Required]
        [Column("PostTitle")]
        public string PostTitle { get; set; }

        /// <summary>
        /// Gets or sets topicId .
        /// </summary>
        [Column("Topic")]
        public int TopicId { get; set; }

        /// <summary>
        /// Gets or sets image.
        /// </summary>
        [Required]
        [Column("Image")]
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets descriptiop.
        /// </summary>
        [Required]
        [Column(" Description")]
        public string Description { get; set; }
    }
}

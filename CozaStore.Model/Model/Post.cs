// <copyright file="Post.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CozaStore.Model.BaseModel;

    /// <summary>
    /// Post.
    /// </summary>
    public class PostModel : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets post Title.
        /// </summary>
        public string PostTitle { get; set; }

        /// <summary>
        /// Gets or sets topicId .
        /// </summary>
        public int TopicId { get; set; }

        /// <summary>
        /// Gets or sets image.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets descriptiop.
        /// </summary>
        public string Description { get; set; }
    }
}

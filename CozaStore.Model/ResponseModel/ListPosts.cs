// <copyright file="ListPosts.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.ResponseModel
{
    using CozaStore.Model.BaseModel;

    public class ListPosts : BaseTableWithId
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

        public string TopicName { get; set; }
    }
}

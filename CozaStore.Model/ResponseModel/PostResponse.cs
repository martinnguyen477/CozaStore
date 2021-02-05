// <copyright file="PostResponse.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.ResponseModel
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PostResponse : BaseResponse
    {
        /// <summary>
        /// Gets or sets post Title.
        /// </summary>
        public string PostTitle { get; set; }

        /// <summary>
        /// Gets or sets TopicName .
        /// </summary>
        public string TopicName { get; set; }

        /// <summary>
        /// Gets or sets image.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets Detail.
        /// </summary>
        public string Detail { get; set; }
    }
}

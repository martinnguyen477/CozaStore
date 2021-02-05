// <copyright file="BaseResponse.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.ResponseModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Text.Json.Serialization;

    public class BaseResponse
    {
        /// <summary>
        /// Gets or sets id.
        /// </summary>
        [Key]
        public long Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Gets or sets createBy == IdUser.
        /// </summary>
        [JsonIgnore]
        [IgnoreDataMember]
        public int CreateBy { get; set; }

        /// <summary>
        /// Gets or sets updateDate .
        /// </summary>
        [JsonIgnore]
        [IgnoreDataMember]
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// Gets or sets updateBy == Id User Update.
        /// </summary>
        [JsonIgnore]
        [IgnoreDataMember]
        public int UpdateBy { get; set; }

        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonIgnore]
        [IgnoreDataMember]
        public int Status { get; set; }
    }
}

// <copyright file="BaseTable.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.BaseModel
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Text.Json.Serialization;

    /// <summary>
    /// BaseTable.
    /// </summary>
    public class BaseTable
    {
        /// <summary>
        /// Gets or sets createDate.
        /// </summary>
        [JsonIgnore]
        [IgnoreDataMember]
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

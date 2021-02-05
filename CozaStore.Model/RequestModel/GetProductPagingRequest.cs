// <copyright file="GetProductPagingRequest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.RequestModel
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using CozaStore.Model.Common;

    public class GetProductPagingRequest : PagedResultBase
    {
        public string Keyword { get; set; }

        public int? CategoryId { get; set; }
    }
}

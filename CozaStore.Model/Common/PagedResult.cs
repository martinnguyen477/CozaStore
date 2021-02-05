// <copyright file="PagedResult.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.Common
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PagedResult<T> : PagedResultBase
    {
        public List<T> Items { get; set; }
    }
}

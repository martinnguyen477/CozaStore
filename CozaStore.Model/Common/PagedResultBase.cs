// <copyright file="PagedResultBase.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.Common
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PagedResultBase
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int TotalRecords { get; set; }

        public int PageCount
        {
            get
            {
                var pageCount = (double)TotalRecords / PageSize;
                return (int)Math.Ceiling(pageCount);
            }
        }
    }
}

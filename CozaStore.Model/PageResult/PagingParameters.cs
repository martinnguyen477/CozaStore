// <copyright file="PagingParameters.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.PageResult
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PagingParameters
    {
        /// <summary>
        /// số lượng size max.
        /// </summary>
        private const int maxPageSize = 50;

        public int PageNumber { get; set; } = 1;

        private int _pageSize = 10;

        public int PageSize
        {
            get
            {
                return _pageSize;
            }

            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
}

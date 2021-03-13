// <copyright file="PageList.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Model.PageResult
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PageList<T> : List<T>
    {
        // trang hiện tại.
        public int CurrentPage { get; set; }

        // tổng số trang.
        public int TotalPages { get; set; }

        // kích cỡ của trang.
        public int PageSize { get; set; }

        // số lượng.
        public int TotalCount { get; set; }

        // trang tối thiểu phải là trang số 1.
        public bool HasPreviour => CurrentPage > 1;

        // trang cuối cùng nhỏ hơn trang cuối.
        public bool HasNext => CurrentPage < TotalPages;

        public PageList(List<T> items, int count, int pageNumber, int pageSize)
        {
            TotalCount = count;
            PageSize = pageSize;
            CurrentPage = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            AddRange(items);
        }

        public static PageList<T> GetPageList(IQueryable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return new PageList<T>(items, count, pageNumber, pageSize);
        }
    }
}

// <copyright file="IProductServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Services.ProductServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CozaStore.Model.Common;
    using CozaStore.Model.EntitiesModel;
    using CozaStore.Model.Model;
    using CozaStore.Model.PageResult;
    using CozaStore.Model.RequestModel;
    using CozaStore.Model.ResponseModel;

    public interface IProductServices
    {
        /// <summary>
        /// Thêm sản phẩm.
        /// </summary>
        /// <param name="productModel"> Request View.</param>
        /// <returns>insert.</returns>
        Task<int> InsertProduct(ProductModel productModel);

        /// <summary>
        /// Update sản phẩm.
        /// </summary>
        /// <param name="productModel">Request View.</param>
        /// <returns>Update.</returns>
        Task<int> UpdateProduct(ProductModel productModel);

        /// <summary>
        /// Xóa sản phẩm.
        /// </summary>
        /// <param name="productId">productId.</param>
        /// <returns>Delete.</returns>
        Task<int> DeleteProduct(int productId);

        /// <summary>
        /// Get Products.
        /// </summary>
        /// <returns> Get products.</returns>
        Task<List<ListProducts>> GetProducts();

        Task<PageList<ProductEntities>> GetProductPaging(PagingParameters pagingParameters);

        /// <summary>
        /// DS product.
        /// </summary>
        /// <param name="categoryModel">category.</param>
        /// <returns>DS.</returns>
        // Task<List<ListProducts>> ProductsOfSomeType(CategoryModel categoryModel);
    }
}

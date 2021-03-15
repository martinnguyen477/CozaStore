// <copyright file="ProductServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Services.ProductServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using CozaStore.Data.EntityContext;
    using CozaStore.Model.EntitiesModel;
    using CozaStore.Model.Exception;
    using CozaStore.Model.Model;
    using CozaStore.Model.PageResult;
    using CozaStore.Model.ResponseModel;
    using Microsoft.EntityFrameworkCore;

    public class ProductServices : ServicesBase<ProductEntities>, IProductServices
    {
        #region Contructor, Variable Readonly

        private readonly CozaStoreContext _context;
        private readonly IMapper _mapper;

        public ProductServices(CozaStoreContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }

        #endregion Contructor, Variable Readonly

        #region Get Product

        public async Task<List<ListProducts>> GetProducts()
        {
            // var product = _context.Product.ToListAsync();
            //// var productView = _mapper.Map<ListProducts>(product);
            // ListProducts product1 = _mapper.Map<ProductEntities, ListProducts>();
            var result = _context.Product.Select(
               p => new ListProducts()
               {
                   Id = p.Id,
                   CategoryId = p.CategoryId,
                   ProductName = p.ProductName,
                   Price = p.Price,
                   Image = p.Image,
                   ProductDescription = p.ProductDescription,
                   Quantity = p.Quantity,
                   SupplierId = p.SupplierId,
                   CreateDate = p.CreateDate
               }).ToListAsync();
            return await result;
        }

        #endregion Get Product

        #region Delete Product

        public async Task<int> DeleteProduct(int productId)
        {
            // ProductEntities product = _mapper.Map<ProductModel, ProductEntities>(productModel);
            // var product1 = new ProductEntities()
            // {
            //    Id = productModel.Id
            // };
            var product = await _context.Product.FindAsync(productId);
            if (product == null)
            {
                throw new CozaStoreException($"Không tìm thấy sản phẩm {productId}");
            }

            _context.Product.Remove(product);

            return await _context.SaveChangesAsync();
        }

        #endregion Delete Product

        #region Insert Product

        public async Task<int> InsertProduct(ProductModel productModel)
        {
            ProductEntities product = _mapper.Map<ProductModel, ProductEntities>(productModel);
            _context.Product.Add(product);
            return await _context.SaveChangesAsync();
        }

        #endregion Insert Product

        #region Update Product

        public async Task<int> UpdateProduct(ProductModel productModel)
        {
            ProductEntities product = _mapper.Map<ProductModel, ProductEntities>(productModel);
            _context.Product.Update(product);
            return await _context.SaveChangesAsync();
        }

        #endregion Update Product

        #region GetProductPaging

        public Task<PageList<ListProducts>> GetProductsPaging(PagingParameters pagingParameters)
        {
            var product = _context.Product.Select(
               p => new ListProducts()
               {
                   Id = p.Id,
                   CategoryId = p.CategoryId,
                   ProductName = p.ProductName,
                   Price = p.Price,
                   Image = p.Image,
                   ProductDescription = p.ProductDescription,
                   Quantity = p.Quantity,
                   SupplierId = p.SupplierId,
                   CreateDate = p.CreateDate
               }).OrderBy(o => o.Id).ToList();

            var result = PageList<ListProducts>.GetPageList(product, pagingParameters.PageNumber, pagingParameters.PageSize);
            return Task.FromResult(result);
        }

        #endregion GetProductPaging

        #region Search
        public Task<PageList<ListProducts>> SearchProducts(string key, PagingParameters pagingParameters)
        {
            var products = _context.Product.Select(
                p => new ListProducts()
                {
                    Id = p.Id,
                    CategoryId = p.CategoryId,
                    ProductName = p.ProductName,
                    Price = p.Price,
                    Image = p.Image,
                    ProductDescription = p.ProductDescription,
                    Quantity = p.Quantity,
                    SupplierId = p.SupplierId,
                    CreateDate = p.CreateDate
                }).Where(p => p.ProductName.ToLower().Contains(key.ToLower()));
            var product2 = products.OrderBy(s => s.Id).ToList();

            var result = PageList<ListProducts>.GetPageList(product2, pagingParameters.PageNumber, pagingParameters.PageSize);
            return Task.FromResult(result);
        }
        #endregion

        #region Product Category
        public Task<PageList<ListProducts>> ProductsCategory(int idCategory, PagingParameters pagingParameters)
        {
            var product = _context.Product.Select(
                p => new ListProducts
                {
                    Id = p.Id,
                    CategoryId = p.CategoryId,
                    ProductName = p.ProductName,
                    Price = p.Price,
                    Image = p.Image,
                    ProductDescription = p.ProductDescription,
                    Quantity = p.Quantity,
                    SupplierId = p.SupplierId,
                    CreateDate = p.CreateDate
                }).Where(p => p.CategoryId == idCategory).ToList();
            var result = PageList<ListProducts>.GetPageList(product, pagingParameters.PageNumber, pagingParameters.PageSize);
            return Task.FromResult(result);
        }

        public Task<PageList<ListProducts>> NewProducts(PagingParameters pagingParameters)
        {
            var product = _context.Product.Select(
                p => new ListProducts
                {
                    Id = p.Id,
                    CategoryId = p.CategoryId,
                    ProductName = p.ProductName,
                    Price = p.Price,
                    Image = p.Image,
                    ProductDescription = p.ProductDescription,
                    Quantity = p.Quantity,
                    SupplierId = p.SupplierId,
                    CreateDate = p.CreateDate
                }).Where(p => p.CreateDate.Day - DateTime.Now.Day < 7).ToList();

            var result = PageList<ListProducts>.GetPageList(product, pagingParameters.PageNumber, pagingParameters.PageSize);
            return Task.FromResult(result);
        }

        public Task<PageList<ListProductsByTag>> ProductsByTag(int idTag, PagingParameters pagingParameters)
        {
            var product = from p in _context.Product
                          join t in _context.Tags on p.TagId equals t.Id
                          where t.Id == idTag
                          select new ListProductsByTag
                          {
                              Id = p.Id,
                              CategoryId = p.CategoryId,
                              ProductName = p.ProductName,
                              Price = p.Price,
                              Image = p.Image,
                              ProductDescription = p.ProductDescription,
                              Quantity = p.Quantity,
                              SupplierId = p.SupplierId,
                              CreateDate = p.CreateDate,
                              TagId = t.Id,
                              TagName = t.Tag
                          };
            var p1 = product.ToList();
            var result = PageList<ListProductsByTag>.GetPageList(p1, pagingParameters.PageNumber, pagingParameters.PageSize);
            return Task.FromResult(result);
        }
        #endregion

        #region Sản phẩm cùng loại.

        // public async Task<List<ListProducts>> ProductsOfSomeType(CategoryModel categoryModel)
        // {
        //    // var listProduct = _context.Product.Select(p
        //    //    => new ListProducts
        //    //    {
        //    //        Id = p.Id,
        //    //        CategoryId = p.CategoryId,
        //    //        ProductName = p.ProductName,
        //    //        Price = p.Price,
        //    //        Image = p.Image,
        //    //        Color = p.Color,
        //    //        Size = p.Size,
        //    //        ProductDescription = p.ProductDescription,
        //    //        Quantity = p.Quantity,
        //    //        SupplierId = p.SupplierId
        //    //    }).ToListAsync();
        //    var listProduct1 = from p in _context.Set<ProductEntities>()
        //                       from c in _context.Set<CategoryEntities>().Where(o => o.Id == p.CategoryId)
        //                       .Where(o => o.Id == categoryModel.Id)
        //                       select new ListProducts
        //                       {
        //                           Id = p.Id,
        //                           CategoryId = p.CategoryId,
        //                           ProductName = p.ProductName,
        //                           CategoryName = c.CategoryName,
        //                           Price = p.Price,
        //                           Image = p.Image,
        //                           Color = p.Color,
        //                           Size = p.Size,
        //                           ProductDescription = p.ProductDescription,
        //                           Quantity = p.Quantity,
        //                           SupplierId = p.SupplierId
        //                       };
        //    return await listProduct1;
        // }.
        #endregion Sản phẩm cùng loại.
    }
}
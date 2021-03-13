// <copyright file="ProductServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Services.ProductServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using AutoMapper;
    using CozaStore.Data.EntityContext;
    using CozaStore.Model.Common;
    using CozaStore.Model.EntitiesModel;
    using CozaStore.Model.Exception;
    using CozaStore.Model.Model;
    using CozaStore.Model.PageResult;
    using CozaStore.Model.RequestModel;
    using CozaStore.Model.ResponseModel;
    using Microsoft.EntityFrameworkCore;

    public class ProductServices : RepositoryBase<ProductEntities>, IProductServices
    {
        #region Contructor, Variable Readonly
        private readonly CozaStoreContext _context;
        private readonly IMapper _mapper;

        public ProductServices(CozaStoreContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }
        #endregion

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
        #endregion

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
        #endregion

        #region Insert Product
        public async Task<int> InsertProduct(ProductModel productModel)
        {
            ProductEntities product = _mapper.Map<ProductModel, ProductEntities>(productModel);
            _context.Product.Add(product);
            return await _context.SaveChangesAsync();
        }
        #endregion

        #region Update Product
        public async Task<int> UpdateProduct(ProductModel productModel)
        {
            ProductEntities product = _mapper.Map<ProductModel, ProductEntities>(productModel);
            _context.Product.Update(product);
            return await _context.SaveChangesAsync();
        }
        #endregion

        public Task<PageList<ProductEntities>> GetProductPaging(PagingParameters pagingParameters)
        {
            var result = PageList<ProductEntities>.GetPageList(GetAll().OrderBy(s => s.Id), pagingParameters.PageNumber, pagingParameters.PageSize);
            //return Task.FromResult(PageList<ProductEntities>.GetPageList(GetAll().OrderBy(s => s.Id), pagingParameters.PageNumber, pagingParameters.PageSize));
            return Task.FromResult(result);
        }

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
        // }
        #endregion
    }
}

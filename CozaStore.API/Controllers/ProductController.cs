// <copyright file="ProductController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.API.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using CozaStore.Model.EntitiesModel;
    using CozaStore.Model.Model;
    using CozaStore.Model.PageResult;
    using CozaStore.Model.ResponseModel;
    using CozaStore.Services.ProductServices;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region Contructor, Variable Readonly
        private readonly IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }
        #endregion

        #region Get Products
        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            return Ok(await _productServices.GetProducts());
        }
        #endregion

        #region Insert
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] ProductModel productModel)
        {
            await _productServices.InsertProduct(productModel);
            return Ok(productModel);
        }
        #endregion

        #region Update
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ProductModel productModel)
        {
            var status = await _productServices.UpdateProduct(productModel);
            return Ok(productModel);
        }
        #endregion

        #region Delete
        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] ProductModel productModel)
        {
            var status = await _productServices.DeleteProduct(productModel.Id);
            return Ok(status);
        }
        #endregion

        #region Paging ListAll

        [HttpGet("GetProductPaging")]
        public async Task<ActionResult<IEnumerable<ListProducts>>> GetAllPaging([FromQuery] PagingParameters pagingParameters)
        {
            return await _productServices.GetProductsPaging(pagingParameters);
        }
        #endregion

        #region Search

        [HttpGet("Search")]
        public async Task<ActionResult<IEnumerable<ListProducts>>> SearchProduct([FromQuery] PagingParameters pagingParameters, string keyWord)
        {
            return await _productServices.SearchProducts(keyWord, pagingParameters);
        }
        #endregion

        #region Product Category
        [HttpGet("ProductCategory")]
        public async Task<ActionResult<IEnumerable<ListProducts>>> ProductCategory([FromQuery] PagingParameters pagingParameters, int idCategory)
        {
            return await _productServices.ProductsCategory(idCategory, pagingParameters);
        }
        #endregion

        #region New Product
        [HttpGet("NewProduct")]
        public async Task<ActionResult<IEnumerable<ListProducts>>> NewProduct([FromQuery] PagingParameters pagingParameters)
        {
            return await _productServices.NewProducts(pagingParameters);
        }
        #endregion

        #region Products By Tag
        [HttpGet("ProductsByTag")]
        public async Task<ActionResult<IEnumerable<ListProductsByTag>>> ProductsByTag([FromQuery] PagingParameters pagingParameters, int tagId)
        {
            return await _productServices.ProductsByTag(tagId, pagingParameters);
        }
        #endregion

        #region Get Product By Id
        [HttpGet("{idProduct:int}")]
        public ListProducts GetProductById(int idProduct)
        {
            return _productServices.GetProductById(idProduct);
        }
        #endregion
    }
}

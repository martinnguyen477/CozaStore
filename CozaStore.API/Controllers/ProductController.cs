using CozaStore.Model.EntitiesModel;
using CozaStore.Model.Model;
using CozaStore.Model.PageResult;
using CozaStore.Model.ResponseModel;
using CozaStore.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CozaStore.API.Controllers
{
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
            return await _productServices.GetProductPaging(pagingParameters);
        }
        #endregion

        #region Search

        [HttpGet("Search")]
        public async Task<ActionResult<IEnumerable<ListProducts>>> SearchProduct([FromQuery] PagingParameters pagingParameters, string keyWord)
        {
            return await _productServices.SearchProduct(keyWord,pagingParameters);
        }
        #endregion

        #region Product Category
        [HttpGet("ProductCategory")]
        public async Task<ActionResult<IEnumerable<ListProducts>>> ProductCategory( [FromQuery] PagingParameters pagingParameters, int idCategory)
        {
            return await _productServices.ProductCategory(idCategory, pagingParameters);
        }
        #endregion

        #region New Product 
        [HttpGet("NewProduct")]
        public async Task<ActionResult<IEnumerable<ListProducts>>> NewProduct([FromQuery] PagingParameters pagingParameters)
        {
            return await _productServices.NewProduct(pagingParameters);
        }
        #endregion

    }
}

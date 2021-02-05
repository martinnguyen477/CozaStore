using CozaStore.Model.Model;
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
        public async Task<IActionResult> Index()
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
    }
}

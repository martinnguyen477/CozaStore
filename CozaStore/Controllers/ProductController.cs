using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CozaStore.Model.ResponseModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CozaStore.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServiceApiClient _productServiceApiClient;

        public ProductController(IProductServiceApiClient productServiceApiClient)
        {
            _productServiceApiClient = productServiceApiClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var response = await _productServiceApiClient.GetProducts();

            var model = JsonConvert.DeserializeObject<List<ListProducts>>(response);

            return View(model);
        }
    }
}

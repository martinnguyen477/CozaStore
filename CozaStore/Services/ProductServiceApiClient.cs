using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CozaStore.Model.ResponseModel;

namespace CozaStore.WebApp.Services
{
    public class ProductServiceApiClient : IProductServiceApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductServiceApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<string> GetProducts()
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44305");
            var response = await client.GetAsync("api/Product");

            return await response.Content.ReadAsStringAsync();
        }
    }
}

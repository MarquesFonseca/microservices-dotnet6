﻿using GeekShopping.Web.Models;
using GeekShopping.Web.Services.Interfaces;
using GeekShopping.Web.Utils;

namespace GeekShopping.Web.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;
        public const string BasePath = "api/v1/product";

        public ProductService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<ProductModel>> FindAllProduct()
        {
            var response = await _client.GetAsync(BasePath);
            return await response.ReadContentAs<List<ProductModel>>();
        }

        public async Task<ProductModel> FindProductById(long id)
        {
            var response = await _client.GetAsync($"{BasePath}/{id}");
            return await response.ReadContentAs<ProductModel>();
        }

        public async Task<ProductModel> CreateProduct(ProductModel productModel)
        {
            var response = await _client.PostAsJson(BasePath, productModel);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<ProductModel>();
            else
                throw new Exception("Something went wrong when calling API");
        }

        public async Task<ProductModel> UpdateProduct(ProductModel productModel)
        {
            var response = await _client.PutAsJson(BasePath, productModel);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<ProductModel>();
            else
                throw new Exception("Something went wrong when calling API");
        }

        public async Task<bool> DeleteProductById(long id)
        {
            var response = await _client.DeleteAsync($"{BasePath}/{id}");
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<bool>();
            else
                throw new Exception("Something went wrong when calling API");
        }
    }
}

using CustomerSubscriptionAPIClient.Interface;
using CustomerSubscriptionAPIClient.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System;

namespace CustomerSubscriptionAPIClient.Implementation
{
    internal class ProductApiClient : IProductApiClient
    {
        private readonly IHttpClient _httpClient;

        private const string URL = "product";

        public ProductApiClient(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var result = await _httpClient.GetRequest(URL);
            return JsonConvert.DeserializeObject<IEnumerable<Product>>(result);
        }

        public async Task<Product> GetById(Guid id)
        {
            var result = await _httpClient.GetRequest($"{URL}/{id}");
            return JsonConvert.DeserializeObject<Product>(result);
        }

        public async Task<Product> Create(Product product)
        {
            var jsonContent = JsonConvert.SerializeObject(product);

            var result = await _httpClient.PostRequest(URL, jsonContent);
            return JsonConvert.DeserializeObject<Product>(result);
        }

        public async Task<Product> Update(Product product)
        {
            var jsonContent = JsonConvert.SerializeObject(product);

            var result = await _httpClient.PutRequest(URL, jsonContent);
            return JsonConvert.DeserializeObject<Product>(result);
        }

        public async Task Delete(Guid id)
        {
            var result = await _httpClient.DeleteRequest($"{URL}/{id}");
        }
    }
}

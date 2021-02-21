using CustomerSubscriptionAPIClient.Interface;
using CustomerSubscriptionAPIClient.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System;

namespace CustomerSubscriptionAPIClient.Implementation
{
    internal class CustomerApiClient : ICustomerApiClient
    {
        private readonly IHttpClient _httpClient;

        private const string URL = "customer";

        public CustomerApiClient(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            var result = await _httpClient.GetRequest(URL);
            return JsonConvert.DeserializeObject<IEnumerable<Customer>>(result);
        }

        public async Task<Customer> GetById(Guid id)
        {
            var result = await _httpClient.GetRequest($"{URL}/{id}");
            return JsonConvert.DeserializeObject<Customer>(result);
        }

        public async Task<Customer> Create(Customer customer)
        {
            var jsonContent = JsonConvert.SerializeObject(customer);

            var result = await _httpClient.PostRequest(URL, jsonContent);
            return JsonConvert.DeserializeObject<Customer>(result);
        }

        public async Task<Customer> Update(Customer customer)
        {
            var jsonContent = JsonConvert.SerializeObject(customer);

            var result = await _httpClient.PutRequest(URL, jsonContent);
            return JsonConvert.DeserializeObject<Customer>(result);
        }

        public async Task Delete(Guid id)
        {
            var result = await _httpClient.DeleteRequest($"{URL}/{id}");
        }
    }
}

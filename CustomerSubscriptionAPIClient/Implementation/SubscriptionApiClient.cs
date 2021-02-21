using CustomerSubscriptionAPIClient.Interface;
using CustomerSubscriptionAPIClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerSubscriptionAPIClient.Implementation
{
    internal class SubscriptionApiClient : ISubscriptionApiClient
    {
        private readonly IHttpClient _httpClient;

        private const string URL = "subscription";

        public SubscriptionApiClient(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Subscription>> GetAll()
        {
            var result = await _httpClient.GetRequest(URL);
            return JsonConvert.DeserializeObject<IEnumerable<Subscription>>(result);
        }

        public async Task<Subscription> GetById(Guid id)
        {
            var result = await _httpClient.GetRequest($"{URL}/{id}");
            return JsonConvert.DeserializeObject<Subscription>(result);
        }

        public async Task<Subscription> Create(Subscription subscription)
        {
            var jsonContent = JsonConvert.SerializeObject(subscription);

            var result = await _httpClient.PostRequest(URL, jsonContent);
            return JsonConvert.DeserializeObject<Subscription>(result);
        }

        public async Task<Subscription> Update(Subscription subscription)
        {
            var jsonContent = JsonConvert.SerializeObject(subscription);

            var result = await _httpClient.PutRequest(URL, jsonContent);
            return JsonConvert.DeserializeObject<Subscription>(result);
        }

        public async Task Delete(Guid id)
        {
            var result = await _httpClient.DeleteRequest($"{URL}/{id}");
        }
    }
}

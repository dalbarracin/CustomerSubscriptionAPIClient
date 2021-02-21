using CustomerSubscriptionAPIClient.Interface;
using System.Threading.Tasks;
using System.Net.Http;
using System;
using System.Text;

namespace CustomerSubscriptionAPIClient.Infraestructure
{
    internal class HttpApiClient : IHttpClient
    {
        private readonly HttpClient httpClient;
        private const string baseUrl = "http://host.docker.internal:44387/";

        public HttpApiClient()
        {
            if (httpClient == null)
            {
                httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(baseUrl);
            }
        }

        public async Task<string> GetRequest(string url)
        {
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsStringAsync();

            throw new ArgumentException($"The path {baseUrl + url} gets the following status code: " + response.StatusCode);
        }

        public async Task<string> PostRequest(string url, string jsonContent)
        {
            var data = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(url, data);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsStringAsync();

            throw new ArgumentException($"The path {baseUrl + url} gets the following status code: " + response.StatusCode);
        }

        public async Task<string> PutRequest(string url, string jsonContent)
        {
            var data = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await httpClient.PutAsync(url, data);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsStringAsync();

            throw new ArgumentException($"The path {baseUrl + url} gets the following status code: " + response.StatusCode);
        }

        public async Task<string> DeleteRequest(string url)
        {
            var response = await httpClient.DeleteAsync(url);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsStringAsync();

            throw new ArgumentException($"The path {baseUrl + url} gets the following status code: " + response.StatusCode);
        }
    }
}

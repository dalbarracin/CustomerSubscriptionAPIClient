using System.Threading.Tasks;

namespace CustomerSubscriptionAPIClient.Interface
{
    internal interface IHttpClient
    {
        Task<string> GetRequest(string url);
        Task<string> PostRequest(string url, string jsonContent);
        Task<string> PutRequest(string url, string jsonContent);
        Task<string> DeleteRequest(string url);
    }
}

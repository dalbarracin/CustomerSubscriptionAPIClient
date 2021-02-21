using Microsoft.Extensions.DependencyInjection;
using CustomerSubscriptionAPIClient.Implementation;
using CustomerSubscriptionAPIClient.Infraestructure;
using CustomerSubscriptionAPIClient.Interface;

namespace CustomerSubscriptionAPIClient.Registers
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCustomerSubscriptionScoped(this IServiceCollection services)
        {
            services.AddSingleton<IHttpClient, HttpApiClient>();
            services.AddSingleton<ICustomerApiClient, CustomerApiClient>();
            services.AddSingleton<IProductApiClient, ProductApiClient>();
            services.AddSingleton<ISubscriptionApiClient, SubscriptionApiClient>();
            services.AddSingleton<IApiClient, ApiClient>();
        }
    }
}

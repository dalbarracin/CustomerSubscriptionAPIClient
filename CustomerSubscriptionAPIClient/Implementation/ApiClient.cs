using CustomerSubscriptionAPIClient.Interface;

namespace CustomerSubscriptionAPIClient.Implementation
{
    internal class ApiClient : IApiClient
    {
        public ICustomerApiClient Customer { get; }
        public IProductApiClient Product { get; }
        public ISubscriptionApiClient Subscription { get; }

        public ApiClient(ICustomerApiClient customer, IProductApiClient product, ISubscriptionApiClient subscription)
        {
            Customer = customer;
            Product = product;
            Subscription = subscription;
        }
    }
}

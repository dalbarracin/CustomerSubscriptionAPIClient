namespace CustomerSubscriptionAPIClient.Interface
{
    public interface IApiClient
    {
        ICustomerApiClient Customer { get; }
        IProductApiClient Product { get; }
        ISubscriptionApiClient Subscription { get; }
    }
}

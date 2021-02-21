using System;

namespace CustomerSubscriptionAPIClient.Models
{
    public class Subscription
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; }
    }
}

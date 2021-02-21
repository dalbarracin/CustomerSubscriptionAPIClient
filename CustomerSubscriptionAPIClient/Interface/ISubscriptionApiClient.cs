using CustomerSubscriptionAPIClient.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerSubscriptionAPIClient.Interface
{
    public interface ISubscriptionApiClient
    {
        Task<IEnumerable<Subscription>> GetAll();

        Task<Subscription> GetById(Guid id);

        Task<Subscription> Create(Subscription subscription);

        Task<Subscription> Update(Subscription subscription);

        Task Delete(Guid id);
    }
}

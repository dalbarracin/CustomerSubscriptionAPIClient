using CustomerSubscriptionAPIClient.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerSubscriptionAPIClient.Interface
{
    public interface ICustomerApiClient
    {
        Task<IEnumerable<Customer>> GetAll();

        Task<Customer> GetById(Guid id);

        Task<Customer> Create(Customer customer);

        Task<Customer> Update(Customer customer);

        Task Delete(Guid id);
    }
}

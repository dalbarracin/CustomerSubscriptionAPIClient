using CustomerSubscriptionAPIClient.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerSubscriptionAPIClient.Interface
{
    public interface IProductApiClient
    {
        Task<IEnumerable<Product>> GetAll();

        Task<Product> GetById(Guid id);

        Task<Product> Create(Product product);

        Task<Product> Update(Product product);

        Task Delete(Guid id);
    }
}
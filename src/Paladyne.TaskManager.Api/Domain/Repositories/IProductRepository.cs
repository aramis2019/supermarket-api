using System.Collections.Generic;
using System.Threading.Tasks;
using Paladyne.TaskManager.Api.Domain.Models;
using Paladyne.TaskManager.Api.Domain.Models.Queries;

namespace Paladyne.TaskManager.Api.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<QueryResult<Product>> ListAsync(ProductsQuery query);
        Task AddAsync(Product product);
        Task<Product> FindByIdAsync(int id);
        void Update(Product product);
        void Remove(Product product);
    }
}
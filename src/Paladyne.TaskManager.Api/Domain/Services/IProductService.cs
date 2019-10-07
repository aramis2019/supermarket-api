using System.Threading.Tasks;
using Paladyne.TaskManager.Api.Domain.Models;
using Paladyne.TaskManager.Api.Domain.Models.Queries;
using Paladyne.TaskManager.Api.Domain.Services.Communication;

namespace Paladyne.TaskManager.Api.Domain.Services
{
    public interface IProductService
    {
        Task<QueryResult<Product>> ListAsync(ProductsQuery query);
        Task<ProductResponse> SaveAsync(Product product);
        Task<ProductResponse> UpdateAsync(int id, Product product);
        Task<ProductResponse> DeleteAsync(int id);
    }
}
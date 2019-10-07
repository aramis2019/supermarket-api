using System.Collections.Generic;
using System.Threading.Tasks;
using Paladyne.TaskManager.Api.Domain.Models;
using Paladyne.TaskManager.Api.Domain.Services.Communication;

namespace Paladyne.TaskManager.Api.Domain.Services
{
    public interface ICategoryService
    {
         Task<IEnumerable<Category>> ListAsync();
         Task<CategoryResponse> SaveAsync(Category category);
         Task<CategoryResponse> UpdateAsync(int id, Category category);
         Task<CategoryResponse> DeleteAsync(int id);
    }
}
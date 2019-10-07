using System.Threading.Tasks;

namespace Paladyne.TaskManager.Api.Domain.Repositories
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}
using System.Threading.Tasks;
using Paladyne.TaskManager.Api.Domain.Repositories;
using Paladyne.TaskManager.Api.Persistence.Contexts;

namespace Paladyne.TaskManager.Api.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;     
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
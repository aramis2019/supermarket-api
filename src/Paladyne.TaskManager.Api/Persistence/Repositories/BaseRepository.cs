using Paladyne.TaskManager.Api.Persistence.Contexts;

namespace Paladyne.TaskManager.Api.Persistence.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
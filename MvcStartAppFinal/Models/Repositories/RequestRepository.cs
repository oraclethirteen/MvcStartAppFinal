using Microsoft.EntityFrameworkCore;
using MvcStartAppFinal.Models.Db;
using System.Threading.Tasks;

namespace MvcStartAppFinal.Models.Repositories
{
    public class RequestRepository : IRequestRepository
    {
        private readonly MvcStartAppFinalContext _context;

        public RequestRepository(MvcStartAppFinalContext context)
        {
            _context = context;
        }

        public async Task AddRequest(Request request)
        {
            var entry = _context.Entry(request);

            if (entry.State == EntityState.Detached)
            {
                await _context.Requests.AddAsync(request);
            }

            await _context.SaveChangesAsync();
        }

        public async Task<Request[]> GetRequests()
        {
            return await _context.Requests.ToArrayAsync();
        }
    }
}

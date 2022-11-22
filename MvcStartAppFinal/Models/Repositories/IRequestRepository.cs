using MvcStartAppFinal.Models.Db;
using System.Threading.Tasks;

namespace MvcStartAppFinal.Models.Repositories
{
    public interface IRequestRepository
    {
        Task AddRequest(Request request);

        Task<Request[]> GetRequests();
    }
}

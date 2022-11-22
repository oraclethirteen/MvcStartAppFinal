using MvcStartAppFinal.Models.Db;
using System.Threading.Tasks;

namespace MvcStartAppFinal.Models.Repositories
{
    public interface IUserRepository
    {
        Task AddUser(User user);

        Task<User[]> GetUsers();
    }
}

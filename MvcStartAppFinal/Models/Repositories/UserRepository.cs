using Microsoft.EntityFrameworkCore;
using MvcStartAppFinal.Models.Db;
using System.Threading.Tasks;
using System;

namespace MvcStartAppFinal.Models.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MvcStartAppFinalContext _context;

        public UserRepository(MvcStartAppFinalContext context)
        {
            _context = context;
        }

        public async Task AddUser(User user)
        {
            user.Id = Guid.NewGuid();
            user.JoinDate = DateTime.Now;

            var entry = _context.Entry(user);

            if (entry.State == EntityState.Detached)
            {
                await _context.Users.AddAsync(user);
            }

            await _context.SaveChangesAsync();
        }

        public async Task<User[]> GetUsers()
        {
            return await _context.Users.ToArrayAsync();
        }
    }
}

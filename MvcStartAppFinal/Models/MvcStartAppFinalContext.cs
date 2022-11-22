using Microsoft.EntityFrameworkCore;
using MvcStartAppFinal.Models.Db;

namespace MvcStartAppFinal.Models
{
    public class MvcStartAppFinalContext : DbContext
    {
        public MvcStartAppFinalContext(DbContextOptions<MvcStartAppFinalContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }

        public DbSet<UserPost> UserPosts { get; set; }

        public DbSet<Request> Requests { get; set; }
    }
}

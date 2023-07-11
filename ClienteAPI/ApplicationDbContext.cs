using ClienteAPI.Entity;
using Microsoft.EntityFrameworkCore;

namespace ClienteAPI
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}

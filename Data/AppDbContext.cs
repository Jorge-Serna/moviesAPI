using Microsoft.EntityFrameworkCore;
using moviesAPI.Models;
namespace moviesAPI.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace TestAPI.Context
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}

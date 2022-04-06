using Microsoft.EntityFrameworkCore;

namespace TestAPI.Context
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {

        }
    }
}

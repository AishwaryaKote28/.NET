using CrudWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudWeb
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<Products> Products { get; set; }
    }
}
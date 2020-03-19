using Microsoft.EntityFrameworkCore;
using web.api.Model;

namespace web.api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
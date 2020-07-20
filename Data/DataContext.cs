using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
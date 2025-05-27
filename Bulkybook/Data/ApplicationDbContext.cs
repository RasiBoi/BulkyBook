using Bulkybook.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulkybook.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        // DbSet properties for your entities
        public DbSet<Category> Categories { get; set; }
        
    }
}

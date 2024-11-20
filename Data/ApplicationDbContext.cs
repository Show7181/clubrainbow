using clubrainbow.Models;
using Microsoft.EntityFrameworkCore;
namespace clubrainbow.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

          
        }


        public DbSet<Account> Account { get; set; }

    }
}

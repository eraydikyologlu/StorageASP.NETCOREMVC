using Microsoft.EntityFrameworkCore;
using StoreMVC.Models;

namespace StoreMVC.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

         public DbSet<Product> Products { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using storeMVC.Models;

namespace storeMVC.Services
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}

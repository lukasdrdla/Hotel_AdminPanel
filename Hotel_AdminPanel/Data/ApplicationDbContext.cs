using Hotel_AdminPanel.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_AdminPanel.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}

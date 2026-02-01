using Microsoft.EntityFrameworkCore;
using MyCompany.Api.Models;

namespace MyCompany.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}

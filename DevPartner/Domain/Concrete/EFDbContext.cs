using System.Data.Entity;
using Domain.Entities;

namespace Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}

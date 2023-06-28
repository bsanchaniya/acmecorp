using AcmeCorpCustomerManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AcmeCorpCustomerManagementAPI.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}

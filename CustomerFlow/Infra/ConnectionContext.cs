using Microsoft.EntityFrameworkCore;
using CustomerFlow.Model;
using Microsoft.EntityFrameworkCore.Internal;

namespace CustomerFlow.Infra
{
    public class ConnectionContext : DbContext
    {
        public DbSet <Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(
                "Server=PostgreSQL 16;"+
                "Port=8080; Database=customer;"+
                "User Id=postgres;" +
                "Password=;");
    }
}

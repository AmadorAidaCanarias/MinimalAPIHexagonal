using Microsoft.EntityFrameworkCore;
using MinimalApiWithStructure.Enterprise.Domain.Entities;

namespace MinimalApiWithStructure.Gateways.Infrastructure.GatewaySqlServer.DataContext
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}

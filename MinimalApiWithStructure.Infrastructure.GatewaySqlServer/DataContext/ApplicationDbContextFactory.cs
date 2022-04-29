using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MinimalApiWithStructure.Gateways.Infrastructure.GatewaySqlServer.DataContext
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ApplicationDbContext> optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;DataBase=Hexagonal;Integrated Security=False;User=$USER;Password=$PASSWORD");
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}

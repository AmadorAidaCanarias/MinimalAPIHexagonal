using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MinimalApiWithStructure.Enterprise.Domain.Interfaces.Repositories;
using MinimalApiWithStructure.Gateways.Infrastructure.GatewaySqlServer.DataContext;
using MinimalApiWithStructure.Gateways.Infrastructure.GatewaySqlServer.Repositories;

namespace MinimalApiWithStructure.Infrastructure.GatewaySqlServer
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Hexagonal")));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
